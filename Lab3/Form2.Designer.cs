namespace Lab3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_proc = new System.Windows.Forms.TextBox();
            this.text_memory = new System.Windows.Forms.TextBox();
            this.text_desc = new System.Windows.Forms.TextBox();
            this.text_priority = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название процесса:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Приоритет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(71, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Память:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(71, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ЦП:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(71, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пользователь:";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(282, 40);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(234, 20);
            this.text_name.TabIndex = 6;
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(282, 110);
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(234, 20);
            this.text_user.TabIndex = 7;
            // 
            // text_proc
            // 
            this.text_proc.Location = new System.Drawing.Point(282, 166);
            this.text_proc.Name = "text_proc";
            this.text_proc.Size = new System.Drawing.Size(234, 20);
            this.text_proc.TabIndex = 8;
            // 
            // text_memory
            // 
            this.text_memory.Location = new System.Drawing.Point(282, 224);
            this.text_memory.Name = "text_memory";
            this.text_memory.Size = new System.Drawing.Size(234, 20);
            this.text_memory.TabIndex = 9;
            // 
            // text_desc
            // 
            this.text_desc.Location = new System.Drawing.Point(282, 281);
            this.text_desc.Name = "text_desc";
            this.text_desc.Size = new System.Drawing.Size(234, 20);
            this.text_desc.TabIndex = 10;
            // 
            // text_priority
            // 
            this.text_priority.Location = new System.Drawing.Point(282, 344);
            this.text_priority.Name = "text_priority";
            this.text_priority.Size = new System.Drawing.Size(234, 20);
            this.text_priority.TabIndex = 11;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(140, 408);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(92, 23);
            this.accept.TabIndex = 12;
            this.accept.Text = "Подтвердить";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // decline
            // 
            this.decline.Location = new System.Drawing.Point(328, 408);
            this.decline.Name = "decline";
            this.decline.Size = new System.Drawing.Size(86, 23);
            this.decline.TabIndex = 13;
            this.decline.Text = "Отменить";
            this.decline.UseVisualStyleBackColor = true;
            this.decline.Click += new System.EventHandler(this.decline_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 455);
            this.Controls.Add(this.decline);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.text_priority);
            this.Controls.Add(this.text_desc);
            this.Controls.Add(this.text_memory);
            this.Controls.Add(this.text_proc);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.TextBox text_proc;
        private System.Windows.Forms.TextBox text_memory;
        private System.Windows.Forms.TextBox text_desc;
        private System.Windows.Forms.TextBox text_priority;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button decline;
    }
}