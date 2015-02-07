namespace Task14.View
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnChangeFirst = new System.Windows.Forms.Button();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddToFirst = new System.Windows.Forms.Button();
            this.lblFirstFolder = new System.Windows.Forms.Label();
            this.btnChooseFirst = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSecondFolder = new System.Windows.Forms.Label();
            this.btnChooseSecond = new System.Windows.Forms.Button();
            this.btnSynchronize = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textFileSecond = new System.Windows.Forms.TextBox();
            this.btnAddFileToSecond = new System.Windows.Forms.Button();
            this.btnDeleteSecond = new System.Windows.Forms.Button();
            this.btnChangeSecond = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblFirstFolder);
            this.groupBox1.Controls.Add(this.btnChooseFirst);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChangeFirst);
            this.groupBox4.Controls.Add(this.btnDeleteFirst);
            this.groupBox4.Location = new System.Drawing.Point(7, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 54);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete / Change file";
            // 
            // btnChangeFirst
            // 
            this.btnChangeFirst.Location = new System.Drawing.Point(161, 19);
            this.btnChangeFirst.Name = "btnChangeFirst";
            this.btnChangeFirst.Size = new System.Drawing.Size(99, 23);
            this.btnChangeFirst.TabIndex = 4;
            this.btnChangeFirst.Text = "Change file";
            this.btnChangeFirst.UseVisualStyleBackColor = true;
            this.btnChangeFirst.Click += new System.EventHandler(this.btnChangeFirst_Click);
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.Location = new System.Drawing.Point(33, 19);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteFirst.TabIndex = 3;
            this.btnDeleteFirst.Text = "Delete file";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnAddToFirst);
            this.groupBox3.Location = new System.Drawing.Point(7, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add new  file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnAddToFirst
            // 
            this.btnAddToFirst.Location = new System.Drawing.Point(161, 18);
            this.btnAddToFirst.Name = "btnAddToFirst";
            this.btnAddToFirst.Size = new System.Drawing.Size(99, 23);
            this.btnAddToFirst.TabIndex = 0;
            this.btnAddToFirst.Text = "Add";
            this.btnAddToFirst.UseVisualStyleBackColor = true;
            this.btnAddToFirst.Click += new System.EventHandler(this.btnAddToFirst_Click);
            // 
            // lblFirstFolder
            // 
            this.lblFirstFolder.AutoSize = true;
            this.lblFirstFolder.Location = new System.Drawing.Point(112, 25);
            this.lblFirstFolder.Name = "lblFirstFolder";
            this.lblFirstFolder.Size = new System.Drawing.Size(0, 13);
            this.lblFirstFolder.TabIndex = 1;
            // 
            // btnChooseFirst
            // 
            this.btnChooseFirst.Location = new System.Drawing.Point(13, 20);
            this.btnChooseFirst.Name = "btnChooseFirst";
            this.btnChooseFirst.Size = new System.Drawing.Size(99, 23);
            this.btnChooseFirst.TabIndex = 0;
            this.btnChooseFirst.Text = "Choose the folder";
            this.btnChooseFirst.UseVisualStyleBackColor = true;
            this.btnChooseFirst.Click += new System.EventHandler(this.btnChooseFirst_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.lblSecondFolder);
            this.groupBox2.Controls.Add(this.btnChooseSecond);
            this.groupBox2.Location = new System.Drawing.Point(317, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directory 2";
            // 
            // lblSecondFolder
            // 
            this.lblSecondFolder.AutoSize = true;
            this.lblSecondFolder.Location = new System.Drawing.Point(118, 25);
            this.lblSecondFolder.Name = "lblSecondFolder";
            this.lblSecondFolder.Size = new System.Drawing.Size(0, 13);
            this.lblSecondFolder.TabIndex = 1;
            // 
            // btnChooseSecond
            // 
            this.btnChooseSecond.Location = new System.Drawing.Point(7, 20);
            this.btnChooseSecond.Name = "btnChooseSecond";
            this.btnChooseSecond.Size = new System.Drawing.Size(105, 23);
            this.btnChooseSecond.TabIndex = 0;
            this.btnChooseSecond.Text = "Choose the folder";
            this.btnChooseSecond.UseVisualStyleBackColor = true;
            this.btnChooseSecond.Click += new System.EventHandler(this.btnChooseSecond_Click);
            // 
            // btnSynchronize
            // 
            this.btnSynchronize.Location = new System.Drawing.Point(230, 193);
            this.btnSynchronize.Name = "btnSynchronize";
            this.btnSynchronize.Size = new System.Drawing.Size(160, 23);
            this.btnSynchronize.TabIndex = 2;
            this.btnSynchronize.Text = "Synchronize";
            this.btnSynchronize.UseVisualStyleBackColor = true;
            this.btnSynchronize.Click += new System.EventHandler(this.btnSynchronize_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddFileToSecond);
            this.groupBox5.Controls.Add(this.textFileSecond);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(7, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(292, 52);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add new file";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnChangeSecond);
            this.groupBox6.Controls.Add(this.btnDeleteSecond);
            this.groupBox6.Location = new System.Drawing.Point(7, 109);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(292, 53);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Delete / Change file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // textFileSecond
            // 
            this.textFileSecond.Location = new System.Drawing.Point(51, 15);
            this.textFileSecond.Name = "textFileSecond";
            this.textFileSecond.Size = new System.Drawing.Size(108, 20);
            this.textFileSecond.TabIndex = 1;
            // 
            // btnAddFileToSecond
            // 
            this.btnAddFileToSecond.Location = new System.Drawing.Point(165, 13);
            this.btnAddFileToSecond.Name = "btnAddFileToSecond";
            this.btnAddFileToSecond.Size = new System.Drawing.Size(99, 23);
            this.btnAddFileToSecond.TabIndex = 2;
            this.btnAddFileToSecond.Text = "Add";
            this.btnAddFileToSecond.UseVisualStyleBackColor = true;
            this.btnAddFileToSecond.Click += new System.EventHandler(this.btnAddFileToSecond_Click);
            // 
            // btnDeleteSecond
            // 
            this.btnDeleteSecond.Location = new System.Drawing.Point(33, 19);
            this.btnDeleteSecond.Name = "btnDeleteSecond";
            this.btnDeleteSecond.Size = new System.Drawing.Size(99, 23);
            this.btnDeleteSecond.TabIndex = 0;
            this.btnDeleteSecond.Text = "Delete file";
            this.btnDeleteSecond.UseVisualStyleBackColor = true;
            this.btnDeleteSecond.Click += new System.EventHandler(this.btnDeleteSecond_Click);
            // 
            // btnChangeSecond
            // 
            this.btnChangeSecond.Location = new System.Drawing.Point(165, 18);
            this.btnChangeSecond.Name = "btnChangeSecond";
            this.btnChangeSecond.Size = new System.Drawing.Size(99, 23);
            this.btnChangeSecond.TabIndex = 1;
            this.btnChangeSecond.Text = "Change file";
            this.btnChangeSecond.UseVisualStyleBackColor = true;
            this.btnChangeSecond.Click += new System.EventHandler(this.btnChangeSecond_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 223);
            this.Controls.Add(this.btnSynchronize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Synchronize";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFirstFolder;
        private System.Windows.Forms.Button btnChooseFirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSecondFolder;
        private System.Windows.Forms.Button btnChooseSecond;
        private System.Windows.Forms.Button btnSynchronize;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddToFirst;
        private System.Windows.Forms.Button btnChangeFirst;
        private System.Windows.Forms.Button btnDeleteFirst;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnChangeSecond;
        private System.Windows.Forms.Button btnDeleteSecond;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddFileToSecond;
        private System.Windows.Forms.TextBox textFileSecond;
        private System.Windows.Forms.Label label2;

    }
}

