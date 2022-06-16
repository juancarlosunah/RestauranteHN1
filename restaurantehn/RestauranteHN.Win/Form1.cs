using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestauranteHN.BL;

namespace RestauranteHN.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var comidasBL = new ComidasBL();
            var listadeComidas = comidasBL.ObtenerComidas();

            foreach (var Comidas in listadeComidas)

                MessageBox.Show(Comidas.Descripcion);
        }
    }
}
