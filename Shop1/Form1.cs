using System;
using System.Windows.Forms;

namespace Shop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddBalance_Click(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(Labelbalance.Text);
            balance += Convert.ToInt32(textBoxAddBalance.Text);
            Labelbalance.Text = balance.ToString();
            textBoxAddBalance.Clear();
        }
    }
}
