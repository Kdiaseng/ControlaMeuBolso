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

namespace ControlaMeuBolso.View.ControleUsuario
{
    public partial class UCPrincipal : UserControl
    {
        public UCPrincipal()
        {
            InitializeComponent();
        }

        public void UCPrincipal_Load(object sender, EventArgs e)
        {
            mostrarValoresCustoseRenda();
            ArrendondarConponent.arrendondarCantos(pnPendentes);
        }

        private void mostrarValoresCustoseRenda()
        {
            FinancasDAO financasDAO = new FinancasDAO();
            double saldo = 0;
            double renda = 0;
            double despesas = 0;
            int processo = 0;
            double porcentagemDespesas = 0;
            double despesasPendentes = 0;
            double saldoSeguro = 0;

            renda = financasDAO.BuscarValoresFinanceiros(1,false);
            despesas = financasDAO.BuscarValoresFinanceiros(2,false);
            despesasPendentes = financasDAO.BuscarValoresFinanceiros(2, true);

            lbValorDespesas.Text = "R$ " + despesas.ToString("0.00");
            lbValorRenda.Text = "R$ " + renda.ToString("0.00");
            lbDespesasPendente.Text = "R$ " + despesasPendentes.ToString("0.00");

            saldo = renda - despesas;
            lbValorSaldo.Text = "R$ " + saldo.ToString("0.00");


            saldoSeguro = saldo - despesasPendentes;
            lbSaldoSeguro.Text = "R$ " + saldoSeguro.ToString("0.00");

            porcentagemDespesas = calcularPorcentagemInteiro(renda, despesas);
            processo = (int)Math.Ceiling(porcentagemDespesas);

            circularProgressBar.Value = processo;
            lbprocess.Text = processo.ToString() + "%";
          
        }

        private double calcularPorcentagemInteiro(double renda, double despesas)
        {
            if(renda == 0 || despesas == 0)
            {
                return 0;
            }
            else
            {
                return (despesas/renda)*100;
            }
            
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            FrmCadastroDespesas frmCadastro = new FrmCadastroDespesas(this);
            frmCadastro.Show();
           
        }

        private void btnAdicionarRenda_Click(object sender, EventArgs e)
        {
           
            FrmCadastroRenda frmCadastro = new FrmCadastroRenda(this);
            frmCadastro.Show();
            setVisiblePanel(false);

        }

        private void btnMostrarRelatorio_Click(object sender, EventArgs e)
        {
                
        }

        public void setVisiblePanel(bool visivel)
        {
           
        }
    }
}
