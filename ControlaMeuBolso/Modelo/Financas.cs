using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlaMeuBolso.Modelo
{
    public class Financas
    {
        public int IdFinancas { get; set; }
        public Categoria categoria { get; set; }
        public double Custo { get; set; }
        public DateTime DataCadastro { get; set; }
        public Tipo tipo { get; set; }
        public Mes mes { get; set; }
    }
}
