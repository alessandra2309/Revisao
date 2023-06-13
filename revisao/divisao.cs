using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao
{
    public partial class divisao : Form
    {
        public divisao()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void tx_valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_valor1.Text);
                int b = Convert.ToInt32(tx_valor2.Text);

                int c = a / b;
                lb_resultado.Text = c.ToString();
                MessageBox.Show(c.ToString());
            }catch(Exception ex)
            {
                MessageBox.Show("erro ao dividir!");
            }
            finally
            {
                MessageBox.Show("vai executar de qualquer forma!");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
