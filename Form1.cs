using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcularmedia_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, media;
            nota1 = Convert.ToInt16(txtnota1.Text);
            nota2 = Convert.ToInt16(txtnota2.Text);
            nota3 = Convert.ToInt16(txtnota3.Text);
            nota4 = Convert.ToInt16(txtnota4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            MessageBox.Show("O Resultado é: " + media);
        }
    }
}
