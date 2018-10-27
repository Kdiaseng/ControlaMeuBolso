using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlaMeuBolso.DAO;
using ControlaMeuBolso.Modelo;

namespace ControlaMeuBolso.View.ControleUsuario
{
    
    public partial class UCRelatorios : UserControl
    {
        private int financasRedimetoCusto = 2;
        private int mesID = 0;
        private int categoriaId = 0;

        public UCRelatorios()
        {
            InitializeComponent();
        }

        public void UCRelatorios_Load(object sender, EventArgs e)
        {
            carregarGridRelatorio();
            carragarMeses();
            ArrendondarConponent.arrendondarCantos(pnBaixoRelatorio);
            ArrendondarConponent.arrendondarCantos(pnRelarioCima);

            cbMesesRelatorio.SelectedIndex = (DateTime.Now.Month) - 1;
            carregarCircularProgress();

            

            rbDespesasPagas.Checked = true;
        }

        private void carragarMeses()
        {
            MesDAO mesDAO = new MesDAO();
            List<Mes> meslist = new List<Mes>();

            meslist = mesDAO.buscarMeses();

            foreach(var item in meslist)
            {
                cbMesesRelatorio.Items.Add(item.mes.ToString());
            }
        }

        private void carregarCategoria(int tipo)
        {
            cbCategoriaRelatorio.Items.Clear();
            CategoriaDao categoriadao = new CategoriaDao();
            List<Categoria> categorias = new List<Categoria>();

            categorias = categoriadao.buscarCategoria(tipo);
           

            foreach(var item in categorias)
            {
                cbCategoriaRelatorio.Items.Add(item.Descricao);
            }

            cbCategoriaRelatorio.Items.Add("TODOS");
        }

        private void carregarGridRelatorio()
        {
            List<Financas> listaFinancas = new List<Financas>();
            FinancasDAO dao = new FinancasDAO();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Descrição", typeof(string));
            dataTable.Columns.Add("Custo", typeof(string));
            dataTable.Columns.Add("Data de Cadastro", typeof(string));

            listaFinancas = dao.buscarDispesas();

            foreach (var item in listaFinancas)
            {
                dataTable.Rows.Add(item.categoria.Descricao, item.Custo, item.DataCadastro);
            }

            dataGridRelatorios.DataSource = dataTable;

        }

        private void rbDespesasPagas_CheckedChanged(object sender, EventArgs e)
        {
            carregarCategoria(2);// 2 é uma chamada para despesas
            financasRedimetoCusto = 2;
            cbMesesRelatorio.Enabled = true;
            cbCategoriaRelatorio.SelectedIndex = (cbCategoriaRelatorio.Items.Count) - 1;
        }

        private void rbDespesasPendentes_CheckedChanged(object sender, EventArgs e)
        {
            carregarCategoria(2);
            mesID = 0;
            financasRedimetoCusto = 2;
            cbMesesRelatorio.Enabled = false;
            cbCategoriaRelatorio.SelectedIndex = (cbCategoriaRelatorio.Items.Count) - 1;
        }

        private void rbRedimentos_CheckedChanged(object sender, EventArgs e)
        {
            carregarCategoria(1);
            financasRedimetoCusto = 1;
            cbMesesRelatorio.Enabled = true;
            cbCategoriaRelatorio.SelectedIndex = (cbCategoriaRelatorio.Items.Count) - 1 ;
        }

        private void btnPesquisarRelario_Click(object sender, EventArgs e)
        {
            if (cbCategoriaRelatorio.SelectedItem.ToString().Equals("TODOS"))
            {
                categoriaId = 0;
            }
            else
            {
                var categoria = new CategoriaDao().buscarCategoria(financasRedimetoCusto).Find(i => i.Descricao.Equals(cbCategoriaRelatorio.SelectedItem.ToString()));
                categoriaId = categoria.IdCategoria;
            }

            if(cbMesesRelatorio.Enabled == true)
            {
                var meses = new MesDAO().buscarMeses().Find(m => m.mes.Equals(cbMesesRelatorio.SelectedItem.ToString()));
                mesID = meses.IdMes;
            }
            
            FinancasDAO dao = new FinancasDAO();
            var financasResult = dao.SP_BUSCA_FINACAS(mesID, financasRedimetoCusto, categoriaId);
            if (mesID == 0)
            {
                carregarGridRelarioDespesasPendentes(financasResult);
            }
            else
            {
                 carregarGridRelatorio(financasResult);
            }

            carregarCircularProgress();


        }

        private void carregarCircularProgress()
        {
            FinancasDAO financasDAO = new FinancasDAO();
            double rendaRelatorio = financasDAO.BuscarValoresFinanceiros(1, false);
            double despesasFiltro = 0;

            foreach(DataGridViewRow row in dataGridRelatorios.Rows)
            {
                despesasFiltro = despesasFiltro + Convert.ToDouble(row.Cells[1].Value.ToString());

            }

            var porcentagemDespesasFiltro = calcularPorcentagemInteiro(rendaRelatorio, despesasFiltro);
            var processoDespesas = (int)Math.Ceiling(porcentagemDespesasFiltro);

            cpDespesasRelatorio.Value = processoDespesas;
            lbValorPdespesas.Text = processoDespesas.ToString() + "%";

            lbValorTotalDespesas.Text = despesasFiltro.ToString("00.00");
         
        }


        private double calcularPorcentagemInteiro(double renda, double despesas)
        {
            if (renda == 0 || despesas == 0)
            {
                return 0;
            }
            else
            {
                return (despesas / renda) * 100;
            }

        }
        private void carregarGridRelarioDespesasPendentes(List<Financas> financasResult)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Descrição", typeof(string));
            table.Columns.Add("Custo", typeof(string));
            table.Columns.Add("Tipo despesa", typeof(string));

            dataGridRelatorios.DataSource = null;

            foreach (var item in financasResult)
            {
                table.Rows.Add(item.categoria.Descricao,
                                      item.Custo,
                                      "PENDENTE");
            }

            dataGridRelatorios.DataSource = table;
        }

        private void carregarGridRelatorio(List<Financas> financasResult)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Descrição", typeof(string));
            dataTable.Columns.Add("Custo", typeof(string));
            dataTable.Columns.Add("Data de Cadastro", typeof(string));
                        

            foreach (var item in financasResult)
            {
                dataTable.Rows.Add(item.categoria.Descricao, item.Custo, item.DataCadastro);
            }

            dataGridRelatorios.DataSource = dataTable;
        }
    }
}
