using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        Proccess proccess;
        public Form2(Proccess proccess, bool flagNewOrChange)
        {
            InitializeComponent();
            this.proccess = proccess;
            if (flagNewOrChange)
            {
              text_name.Text = proccess.name;
                text_desc.Text = proccess.desc;
                text_memory.Text = proccess.memoryForProccess.ToString();
                text_priority.Text = proccess.priority.ToString();
                text_proc.Text = proccess.proccessor_number.ToString();
                text_user.Text = proccess.user.ToString();
            }
        }
        public Form2(List <Proccess> proccesses, bool flagNewOrChange)
        {
            InitializeComponent();
            proccesses.Add(new Proccess("", 0, 0, 0, "", 0));
            this.proccess = proccesses[proccesses.Count - 1];
            if (flagNewOrChange)
            {
                text_name.Text = proccess.name;
                text_desc.Text = proccess.desc;
                text_memory.Text = proccess.memoryForProccess.ToString();
                text_priority.Text = proccess.priority.ToString();
                text_proc.Text = proccess.proccessor_number.ToString();
                text_user.Text = proccess.user.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            proccess.name = text_name.Text;
            proccess.desc = text_desc.Text;
            proccess.memoryForProccess = Convert.ToInt16(text_memory.Text);
            proccess.priority = Convert.ToInt32(text_priority.Text);
            proccess.proccessor_number = Convert.ToByte(text_proc.Text);
            proccess.user = Convert.ToInt32(text_user.Text);
            this.Close();
        }

        private void decline_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
