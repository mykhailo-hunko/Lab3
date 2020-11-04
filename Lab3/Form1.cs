using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        int MaxCount = 0;
         public Manager manager;
        int selectedIndex = 0;
        public Form1()
        {
           
            InitializeComponent();
             manager = new Manager();
            MaxCount = manager.listOfComputers.Count + 1;
            inizialazeDrop();
          
        }
        private void inizialazeDrop()
        {
            list.Items.Clear();
            for (int i = 0; i < MaxCount + 1; i++)
            {
                if(((Сomputer)manager.listOfComputers[i]) != null)
                {
                   list.Items.Add("Компьютер " + i + ": " + ((Сomputer)manager.listOfComputers[i]).name);
                }
                
            }
           
        }
        private void inizialazeGrid(int numberOfComp)
        {
          
                    dataGridView1.Rows.Clear();
                    string[] grid = new string[6];
            
                Сomputer comp = ((Сomputer)manager.listOfComputers[numberOfComp]);

                  for (int j = 0; j < comp.proccess.Count; j++)
                  {
                      grid[0] = comp.proccess[j].name;
                      grid[1] = comp.proccess[j].priority.ToString();
                      grid[2] = comp.proccess[j].proccessor_number.ToString();
                      grid[3] = comp.proccess[j].memoryForProccess.ToString();
                      grid[4] = comp.proccess[j].desc;
                      if(comp.proccess[j].user == 1)
                      {
                          grid[5] = "Admin";
                      }
                      else
                      {
                          grid[5] = "User";
                      }
                        dataGridView1.Rows.Add(grid);
                  
                  }
          
        }

        private void add_proc_Click(object sender, EventArgs e)
        {
           
        }

        private void change_Click(object sender, EventArgs e)
        {
            Add(false);
        }

        private void add_Click(object sender, EventArgs e)
        {   if(list.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите компьютер!!!", "Ошибка");
                return;
            }

            Add(true);
           
        }
        private void Add(bool addTrueChangeFalse)
        {
            
            int addNumber = 0;
            Form3 form;
            if (addTrueChangeFalse)
            {
                addNumber = MaxCount;
                    manager.listOfComputers.Add(addNumber, new Сomputer(0, new List<Proccess>(), 0, 0));
             
               
                form = new Form3((Сomputer)manager.listOfComputers[addNumber], true);
                form.ShowDialog();
                if (((Сomputer)manager.listOfComputers[addNumber]).ram == 0)
                {
                    manager.listOfComputers.Remove(addNumber);
                }
            }
            else
            {
                if (list.SelectedItem != null)
                {
                     form = new Form3((Сomputer)manager.listOfComputers[selectedIndex], true);
                    form.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Сначала выберите компьютер!!!", "Ошибка");
                }
            }
            MaxCount++;
            inizialazeDrop();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(list.SelectedItem != null)
            { 
                    manager.listOfComputers.Remove(list.SelectedIndex + 1);
                        inizialazeDrop();
                dataGridView1.Rows.Clear();
            } 
            else
            {
                MessageBox.Show("Сначала выберите компьютер!!!", "Ошибка");
            }
            
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = list.SelectedItem.ToString();
            selectedIndex = Convert.ToInt32(str.Substring(10, 11).Substring(0, 1));
            proc_number.Text = selectedIndex.ToString();
            inizialazeGrid(selectedIndex);
        }

        private void change_proc_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(((Сomputer)manager.listOfComputers[selectedIndex]).proccess[dataGridView1.CurrentRow.Index], true);
            form.ShowDialog();
            inizialazeGrid(selectedIndex);
        }
    }
}
