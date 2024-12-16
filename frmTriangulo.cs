using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S12DS_prjTriangulo
{
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void frmTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        public void Limpar()
        {
            txtLado1.Clear();
            txtLado2.Clear();
            txtLado3.Clear();
            picTriangulo.Image = null;
            txtLado1.Focus();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            int ld1, ld2, ld3;
            ld1= Convert.ToInt32(txtLado1.Text);
            ld2 = Convert.ToInt32(txtLado2.Text);
            ld3= Convert.ToInt32(txtLado3.Text);
            if(ld1< ld2 + ld3&& ld2< ld3 + ld1 && ld3<ld1 + ld2 )
            {
                if(ld1 == ld2 && ld2 == ld3)//triângulo com 3 lados iguais
                {
                    picTriangulo.Load("../../img/trianguloequilatero.png");
                    picTriangulo.Visible = true;
                    MessageBox.Show("Triângulo Equilatero", "***TRIÂNGULO***",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                else
                {
                    if(ld1 == ld2 || ld2 == ld3 || ld3 == ld1)
                    {
                        picTriangulo.Load("../../img/trianguloisoceles.png");
                        picTriangulo.Visible = true;
                        MessageBox.Show("Triângulo Isóceles", "***TRIÂNGULO***",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        picTriangulo.Load("../../img/trianguloescaleno.png");
                        picTriangulo.Visible = true;
                        MessageBox.Show("Triângulo Escaleno", "***TRIÂNGULO***",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                picTriangulo.Load("../../img/imgErro.jpg");
                picTriangulo.Visible = true;
                MessageBox.Show("Valores informados não foram triângulos", "***ERRO***",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnNovo.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ClassSair fechar = new ClassSair();
            fechar.fim();
            Limpar();
        }
    }
}
