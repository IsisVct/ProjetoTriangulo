using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S12DS_prjTriangulo
{
    internal class ClassSair
    {
        public void fim()
        {

            string texto = "Deseja encerrar o programa Triângulos?";
            string titulo = "+++   ENCERRANDO   +++";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }
    }
}

 