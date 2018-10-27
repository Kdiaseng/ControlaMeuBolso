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
    public partial class FrmCadastroRenda : Form
    {
        private UCPrincipal uCPrincipal;

        public FrmCadastroRenda(UCPrincipal uCPrincipal)
        {
            this.uCPrincipal = uCPrincipal;
            InitializeComponent();
        }

        private void btnSalvarCadastroRenda_Click(object sender, EventArgs e)
        {
            salvaRendimento();
            uCPrincipal.UCPrincipal_Load(sender, e);
        }

        private void salvaRendimento()
        {
            CategoriaDao categoriaDao = new CategoriaDao();
            FinancasDAO financasDAO = new FinancasDAO();
            var listaCategoria = categoriaDao.buscarCategoria(1);

            Categoria categoria = new Categoria();
            categoria = listaCategoria.Find(l => l.Descricao.Equals(cbCategoriaRenda.SelectedItem.ToString()));
            Financas financas = new Financas()
            {
                categoria = new Categoria()
                {
                    Descricao = categoria.Descricao,
                    IdCategoria = categoria.IdCategoria
                },
                Custo = Convert.ToDouble(txCustorenda.Text.ToString()),
                DataCadastro = dtDataCadastroRenda.Value,
                tipo = new Tipo
                {
                    IdTipo = 1
                },
                mes = new Mes()
                {
                    IdMes = dtDataCadastroRenda.Value.Month
                }

            };

            if(financasDAO.cadastrarFinancas(financas,false))
            {
                limparDados(); // Colocar em uma classe auxuliar
                MessageBox.Show("Rendimento cadastrado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Não foi possível cadastra rendimento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void limparDados()
        {
            txCustorenda.Text = "";
        }

        private void btnCancelarCadastroRenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FrmCadastroRenda_Load(object sender, EventArgs e)
        {
            ArrendondarConponent.arrendondarCantos(pnBotaoRenda);
            ArrendondarConponent.arrendondarCantos(pnRenda);
           preencherCategoria();
          cbCategoriaRenda.SelectedIndex = 0;

        }

        private void preencherCategoria()
        {
            CategoriaDao categoriaDao = new CategoriaDao();
            var lista = categoriaDao.buscarCategoria(1);

            foreach (var item in lista)
            {
                cbCategoriaRenda.Items.Add(item.Descricao);
            }

        }

        private void BtnFecharCadatroRenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txCustorenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txCustorenda.Text.Contains(","))
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
