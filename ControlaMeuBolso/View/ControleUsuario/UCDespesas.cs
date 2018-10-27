using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlaMeuBolso.Modelo;
using ControlaMeuBolso.DAO;

namespace ControlaMeuBolso.View.ControleUsuario
{
    public partial class UCDespesas : UserControl
    {
        public UCDespesas()
        {
            InitializeComponent();
        }

        public void UCDespesas_Load(object sender, EventArgs e)
        {
            carregarValorDespesas();
            carregarGridDespesas();
            arrendondarPanel(pnBaixoDespesas,pnTopDespesas);
        }

        private void arrendondarPanel(params Panel[] panels)
        {
            foreach(var item in panels)
            {
                ArrendondarConponent.arrendondarCantos(item);
            }
            
        }

        private void carregarGridDespesas()
        {
            List<Financas> listaFinancas = new List<Financas>();
            FinancasDAO dao = new FinancasDAO();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Descrição", typeof(string));
            dataTable.Columns.Add("Custo", typeof(string));
            dataTable.Columns.Add("Data de Cadastro", typeof(string));

            listaFinancas = dao.buscarDispesas();

            foreach(var item in listaFinancas)
            {
                dataTable.Rows.Add(item.categoria.Descricao, item.Custo, item.DataCadastro);
            }

            dataGridDespesas.DataSource = dataTable;

        }

        private void carregarValorDespesas()
        {
            FinancasDAO financasDAO = new FinancasDAO();
            double dispesasTotal = financasDAO.BuscarValoresFinanceiros(2, false);
            lbDespesasValor.Text = "R$ " + dispesasTotal.ToString("0.00");
        }
    }
}
