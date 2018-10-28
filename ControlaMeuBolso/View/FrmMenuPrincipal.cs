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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnPrincipal.Height;
            panelSlide.Top = btnPrincipal.Top;
            lbTitulo.Text = "Controla meu bolso";
            ucPrincipal.BringToFront();

        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnDespesas.Height;
            panelSlide.Top = btnDespesas.Top;
            lbTitulo.Text = "Histórico de Despesas";
            ucDespesas.BringToFront();
            ucDespesas.UCDespesas_Load(sender, e);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnRelatorio.Height;
            panelSlide.Top = btnRelatorio.Top;
            ucRelatorios.BringToFront();
            lbTitulo.Text = "Relatório Mensal";
            ucRelatorios.UCRelatorios_Load(sender, e);
        }

        private void btnPoupanca_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnPoupanca.Height;
            panelSlide.Top = btnPoupanca.Top;
          //  ucPrincipal.BringToFront();
            lbTitulo.Text = "Histórico de Poupança";
        }

        private void btnMetas_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnMetas.Height;
            panelSlide.Top = btnMetas.Top;
            //  ucPrincipal.BringToFront();
            lbTitulo.Text = "Programe suas Metas";
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            panelSlide.Height = btnPrincipal.Height;
            panelSlide.Top = btnPrincipal.Top;
            ucPrincipal.BringToFront();
            
        }
    }
}
