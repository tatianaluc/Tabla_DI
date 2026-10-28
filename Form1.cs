using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM2_DI_TiendaAnimales_DeLuca_Tatiana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosAnimalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosAnimalesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productosAnimalesTableAdapter);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosAnimalesTableAdapter.ProductosAnimales' Puede moverla o quitarla según sea necesario.
            this.productosAnimalesTableAdapter1.Fill(this.productosAnimalesTableAdapter.ProductosAnimales);

        }
    }
}
