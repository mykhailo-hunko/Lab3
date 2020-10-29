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
    public partial class Form3 : Form
    {
        Сomputer comp;
        public Form3(Сomputer comp, bool flagNewOrChange)
        {
            InitializeComponent();
            this.comp = comp;
            if (flagNewOrChange)
            {
                text_name.Text = comp.name;
                text_memory.Text = comp.ram.ToString();
                text_proc_number.Text = comp.numberOfProccessors.ToString();
                text_proc.Text = comp.proccessor.ToString();
            }
        }
        private void decline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            comp.ram = Convert.ToInt32(text_memory.Text);
            comp.numberOfProccessors = Convert.ToInt32(text_proc_number.Text);
            comp.proccessor = Convert.ToInt32(text_proc.Text);
            comp.createName();
            this.Close();
        }
    }
}
