using ControlaMeuBolso.DAO;
using ControlaMeuBolso.Modelo;
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
    public partial class Frm_cadastroCatergoria : Form
    {
        int tipo;
        FrmCadastroRenda frmCadastroRenda = null;
        FrmCadastroDespesas frmCadastroDespesas = null;
        public Frm_cadastroCatergoria(FrmCadastroRenda frmCadastroRenda, string titulo, string lbCategoria,int idtipo)
        {
            InitializeComponent();
            lbTituloAddCategoria.Text = titulo;
            tipo = idtipo;
            this.frmCadastroRenda = frmCadastroRenda;
            this.lbcategoria.Text = lbCategoria;
        }

        public Frm_cadastroCatergoria(FrmCadastroDespesas frmCadastroDespesas, string titulo, string lbCategoria, int idtipo)
        {
            InitializeComponent();
            lbTituloAddCategoria.Text = titulo;
            this.frmCadastroDespesas = frmCadastroDespesas;
            tipo = idtipo;
            this.lbcategoria.Text = lbCategoria;
        }

        private void btnCancelarCadastroRenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarCadastroRenda_Click(object sender, EventArgs e)
        {
            CategoriaDao categoriaDao = new CategoriaDao();
            Categoria categoria = new Categoria() { Descricao = txCadastroCategoria.Text.ToString().ToUpper(),Tipo = new Tipo() { IdTipo = tipo} };

            if (categoriaDao.cadastrarCategoria(categoria))
            {
                MessageBox.Show("Categoria cadastrada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (frmCadastroRenda != null)
                {
                    frmCadastroRenda.FrmCadastroRenda_Load(sender,e);
                }
                else if (frmCadastroDespesas != null)
                {
                    frmCadastroDespesas.FrmCadastroDespesas_Load(sender,e);
                }
            }            
            else
            {
                MessageBox.Show("Algo deu errado tente novamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
