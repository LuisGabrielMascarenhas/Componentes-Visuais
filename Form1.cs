using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentes_visuais
{
    public partial class ComponentesVisuais : Form
    {
        public ComponentesVisuais()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mmAbrir_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_Click(object sender, EventArgs e)
        {

        }

        private void mmSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvando Arquivo ... ", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
