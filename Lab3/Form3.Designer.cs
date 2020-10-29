namespace Lab3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.decline = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.text_memory = new System.Windows.Forms.TextBox();
            this.text_proc = new System.Windows.Forms.TextBox();
            this.text_proc_number = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decline
            // 
            this.decline.Location = new System.Drawing.Point(289, 300);
            this.decline.Name = "decline";
            this.decline.Size = new System.Drawing.Size(86, 23);
            this.decline.TabIndex = 27;
            this.decline.Text = "Отменить";
            this.decline.UseVisualStyleBackColor = true;
            this.decline.Click += new System.EventHandler(this.decline_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(101, 300);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(92, 23);
            this.accept.TabIndex = 26;
            this.accept.Text = "Подтвердить";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // text_memory
            // 
            this.text_memory.Location = new System.Drawing.Point(242, 232);
            this.text_memory.Name = "text_memory";
            this.text_memory.Size = new System.Drawing.Size(234, 20);
            this.text_memory.TabIndex = 23;
            // 
            // text_proc
            // 
            this.text_proc.Location = new System.Drawing.Point(242, 174);
            this.text_proc.Name = "text_proc";
            this.text_proc.Size = new System.Drawing.Size(234, 20);
            this.text_proc.TabIndex = 22;
            // 
            // text_proc_number
            // 
            this.text_proc_number.Location = new System.Drawing.Point(242, 118);
            this.text_proc_number.Name = "text_proc_number";
            this.text_proc_number.Size = new System.Drawing.Size(234, 20);
            this.text_proc_number.TabIndex = 21;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(242, 48);
            this.text_name.Name = "text_name";
            this.text_name.ReadOnly = true;
            this.text_name.Size = new System.Drawing.Size(234, 20);
            this.text_name.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Количество процессоров:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Частота ЦП:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Память:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 356);
            this.Controls.Add(this.decline);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.text_memory);
            this.Controls.Add(this.text_proc);
            this.Controls.Add(this.text_proc_number);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decline;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.TextBox text_memory;
        private System.Windows.Forms.TextBox text_proc;
        private System.Windows.Forms.TextBox text_proc_number;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}