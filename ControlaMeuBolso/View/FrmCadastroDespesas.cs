using ControlaMeuBolso.DAO;
using ControlaMeuBolso.Modelo;
using ControlaMeuBolso.View.ControleUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlaMeuBolso.View
{
    public partial class FrmCadastroDespesas : Form
    {
        UCPrincipal principal;
        public FrmCadastroDespesas(UCPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void carregarCategoria()
        {
            CategoriaDao categoriaDao = new CategoriaDao();
            var lista = categoriaDao.buscarCategoria(2);

            foreach(var item in lista)
            {
                cbCategoria.Items.Add(item.Descricao);
            }

            

        }

        private void BtnFecharCadatro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastroDespesas_Load(object sender, EventArgs e)
        {

            carregarCategoria();
            ArrendondarConponent.arrendondarCantos(pnBotao);
            ArrendondarConponent.arrendondarCantos(pnCategoriaCusto);
            ArrendondarConponent.arrendondarCantos(pnDespesasP);

            cbCategoria.SelectedIndex = 0;

        }

        private void btnSalvarCadastro_Click_1(object sender, EventArgs e)
        {
            if (rbDesepesasPendentes.Checked)
            {
                SalvarDespesasPendentes(true);
               
            }else if (rbDespesasPagas.Checked)
            {
                SalvarDespesasPendentes(false);
               
            }
            
            principal.UCPrincipal_Load(sender, e);
        }

        private void limparDados()
        {
            txCusto.Text = "";
        }

        private void SalvarDespesasPendentes(Boolean isPendende)
        {
            FinancasDAO financasDAO = new FinancasDAO();
            CategoriaDao categoriaDao = new CategoriaDao();
            var lista = categoriaDao.buscarCategoria(2);

            Categoria categoriaAux = lista.Find(p => p.Descricao.Equals(cbCategoria.SelectedItem.ToString()));

            Financas financas = new Financas()
            {
                categoria = new Categoria()
                {
                    IdCategoria = categoriaAux.IdCategoria
                },
                Custo = Convert.ToDouble(txCusto.Text.ToString()),
                tipo = new Tipo()
                {
                    IdTipo = 2
                },
                DataCadastro = dtDataCadastro.Value,
                mes = new Mes()
                {
                    IdMes = dtDataCadastro.Value.Month
                }

            };

            financasDAO.cadastrarFinancas(financas, isPendende);
            
            limparDados();
            MessageBox.Show("Despesa cadastrada com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void rbDesepesasPendentes_CheckedChanged(object sender, EventArgs e)
        {
            dtDataCadastro.Enabled = false;
        }

        private void rbDespesasPagas_CheckedChanged(object sender, EventArgs e)
        {
            dtDataCadastro.Enabled = true;
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txCusto.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
