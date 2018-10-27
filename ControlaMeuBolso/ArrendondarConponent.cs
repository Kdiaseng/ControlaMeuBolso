using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlaMeuBolso
{
    public class ArrendondarConponent
    {
        public static void arrendondarCantos(Panel panel)
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel.Size.Width, panel.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel.Width - 12, panel.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel.Width - 24, panel.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel.Region = new Region(PastaGrafica);
        }
    }
}
