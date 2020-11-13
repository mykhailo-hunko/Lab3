using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class valid : Form
    {
        public valid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_pass.Text.Equals("1001")) {
                Form1.isAdmin = true;

            } else
            {
                MessageBox.Show("Неверный пароль", "ОШИБКА");
            }
            this.Close();

        }
    }
}
