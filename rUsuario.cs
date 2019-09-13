using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Button1_ChangePicture_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button6_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Legajo_Click(object sender, EventArgs e)
        {

        }

        private void RUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox2_Inhabilitado_CheckedChanged(object sender, EventArgs e)
        {
           /* var toolTip = new ToolTip();
            toolTip.SetToolTip(checkBox2_Inhabilitado, "This checkbox is read-only.");*/
        }
    }
}
