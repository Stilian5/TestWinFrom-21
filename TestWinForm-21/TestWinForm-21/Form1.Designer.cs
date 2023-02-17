namespace TestWinForm_21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.txtEGN = new System.Windows.Forms.TextBox();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Pol = new System.Windows.Forms.GroupBox();
            this.Pol.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(145, 98);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(201, 27);
            this.txtSurName.TabIndex = 2;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(145, 148);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(201, 27);
            this.txtFamilyName.TabIndex = 3;
            // 
            // txtEGN
            // 
            this.txtEGN.Location = new System.Drawing.Point(145, 200);
            this.txtEGN.Name = "txtEGN";
            this.txtEGN.Size = new System.Drawing.Size(201, 27);
            this.txtEGN.TabIndex = 4;
            this.txtEGN.TextChanged += new System.EventHandler(this.txtEGN_TextChanged);
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(145, 257);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(201, 27);
            this.txtWork.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Презиме";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ЕГН";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Сфера на работа";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(433, 340);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(252, 53);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "РЕГИСТРАЦИЯ";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Мъж";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(35, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 24);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Жена";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Pol
            // 
            this.Pol.Controls.Add(this.checkBox2);
            this.Pol.Controls.Add(this.checkBox1);
            this.Pol.Location = new System.Drawing.Point(471, 43);
            this.Pol.Name = "Pol";
            this.Pol.Size = new System.Drawing.Size(214, 125);
            this.Pol.TabIndex = 16;
            this.Pol.TabStop = false;
            this.Pol.Text = "Пол";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.Pol);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.txtEGN);
            this.Controls.Add(this.txtFamilyName);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pol.ResumeLayout(false);
            this.Pol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtName;
        private TextBox txtSurName;
        private TextBox txtFamilyName;
        private TextBox txtEGN;
        private TextBox txtWork;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button btnRegister;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox Pol;
    }
}