namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ComboBox();
            this.change = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_proc = new System.Windows.Forms.Button();
            this.delete_proc = new System.Windows.Forms.Button();
            this.change_proc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.proc_number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.proc_persent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proc_memory = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компьютеры:";
            // 
            // list
            // 
            this.list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(187, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(335, 21);
            this.list.TabIndex = 1;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(551, 12);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 2;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(632, 11);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(713, 11);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.process,
            this.priority,
            this.processor,
            this.memory,
            this.desc,
            this.user});
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 368);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // process
            // 
            this.process.HeaderText = "Процесс";
            this.process.Name = "process";
            // 
            // priority
            // 
            this.priority.HeaderText = "Приоритет";
            this.priority.Name = "priority";
            // 
            // processor
            // 
            this.processor.HeaderText = "ЦП";
            this.processor.Name = "processor";
            // 
            // memory
            // 
            this.memory.HeaderText = "Память";
            this.memory.Name = "memory";
            // 
            // desc
            // 
            this.desc.HeaderText = "Описание";
            this.desc.Name = "desc";
            // 
            // user
            // 
            this.user.HeaderText = "Пользователь";
            this.user.Name = "user";
            // 
            // add_proc
            // 
            this.add_proc.Location = new System.Drawing.Point(17, 437);
            this.add_proc.Name = "add_proc";
            this.add_proc.Size = new System.Drawing.Size(120, 23);
            this.add_proc.TabIndex = 6;
            this.add_proc.Text = "Добавить процесс";
            this.add_proc.UseVisualStyleBackColor = true;
            this.add_proc.Click += new System.EventHandler(this.add_proc_Click);
            // 
            // delete_proc
            // 
            this.delete_proc.Location = new System.Drawing.Point(143, 437);
            this.delete_proc.Name = "delete_proc";
            this.delete_proc.Size = new System.Drawing.Size(136, 23);
            this.delete_proc.TabIndex = 7;
            this.delete_proc.Text = "Удалить процесс";
            this.delete_proc.UseVisualStyleBackColor = true;
            this.delete_proc.Click += new System.EventHandler(this.delete_proc_Click);
            // 
            // change_proc
            // 
            this.change_proc.Location = new System.Drawing.Point(652, 437);
            this.change_proc.Name = "change_proc";
            this.change_proc.Size = new System.Drawing.Size(131, 23);
            this.change_proc.TabIndex = 8;
            this.change_proc.Text = "Изменить процесс";
            this.change_proc.UseVisualStyleBackColor = true;
            this.change_proc.Click += new System.EventHandler(this.change_proc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество процессов:";
            // 
            // proc_number
            // 
            this.proc_number.AutoSize = true;
            this.proc_number.Location = new System.Drawing.Point(150, 477);
            this.proc_number.Name = "proc_number";
            this.proc_number.Size = new System.Drawing.Size(13, 13);
            this.proc_number.TabIndex = 10;
            this.proc_number.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Загрузка ЦП:";
            // 
            // proc_persent
            // 
            this.proc_persent.AutoSize = true;
            this.proc_persent.Location = new System.Drawing.Point(266, 477);
            this.proc_persent.Name = "proc_persent";
            this.proc_persent.Size = new System.Drawing.Size(13, 13);
            this.proc_persent.TabIndex = 12;
            this.proc_persent.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Использовано ОЗУ:";
            // 
            // proc_memory
            // 
            this.proc_memory.AutoSize = true;
            this.proc_memory.Location = new System.Drawing.Point(415, 477);
            this.proc_memory.Name = "proc_memory";
            this.proc_memory.Size = new System.Drawing.Size(13, 13);
            this.proc_memory.TabIndex = 14;
            this.proc_memory.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.proc_memory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.proc_persent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proc_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.change_proc);
            this.Controls.Add(this.delete_proc);
            this.Controls.Add(this.add_proc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.change);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.Button add_proc;
        private System.Windows.Forms.Button delete_proc;
        private System.Windows.Forms.Button change_proc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label proc_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label proc_persent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label proc_memory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
    }
}

