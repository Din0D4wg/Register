namespace MyFirstC_prog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtfname = new TextBox();
            txtlname = new TextBox();
            txtage = new TextBox();
            txtemail = new TextBox();
            txtphone = new TextBox();
            txtusername = new TextBox();
            txtpass = new TextBox();
            gender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 90);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 131);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 173);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(51, 213);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(361, 90);
            label6.Name = "label6";
            label6.Size = new Size(40, 17);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(361, 131);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 6;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(361, 173);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 7;
            label8.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(361, 213);
            label9.Name = "label9";
            label9.Size = new Size(66, 17);
            label9.TabIndex = 8;
            label9.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(439, 313);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(558, 313);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(141, 84);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(129, 23);
            txtfname.TabIndex = 11;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(141, 125);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(129, 23);
            txtlname.TabIndex = 12;
            // 
            // txtage
            // 
            txtage.Location = new Point(141, 167);
            txtage.Name = "txtage";
            txtage.Size = new Size(129, 23);
            txtage.TabIndex = 13;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(439, 84);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(129, 23);
            txtemail.TabIndex = 14;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(439, 125);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(129, 23);
            txtphone.TabIndex = 15;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(439, 167);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(129, 23);
            txtusername.TabIndex = 16;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(439, 207);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(129, 23);
            txtpass.TabIndex = 17;
            txtpass.UseSystemPasswordChar = true;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            gender.Location = new Point(141, 207);
            gender.Name = "gender";
            gender.Size = new Size(129, 23);
            gender.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(706, 373);
            Controls.Add(gender);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Controls.Add(txtphone);
            Controls.Add(txtemail);
            Controls.Add(txtage);
            Controls.Add(txtlname);
            Controls.Add(txtfname);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
        private TextBox txtfname;
        private TextBox txtlname;
        private TextBox txtage;
        private TextBox txtemail;
        private TextBox txtphone;
        private TextBox txtusername;
        private TextBox txtpass;
        private ComboBox gender;
    }
}
