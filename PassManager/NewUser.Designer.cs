namespace PassManager
{
    partial class F_NewUser
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
            Tb_login = new TextBox();
            Tb_name = new TextBox();
            Tb_password = new TextBox();
            Tb_confirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Btn_submit = new Button();
            SuspendLayout();
            // 
            // Tb_login
            // 
            Tb_login.Location = new Point(77, 38);
            Tb_login.Name = "Tb_login";
            Tb_login.Size = new Size(100, 23);
            Tb_login.TabIndex = 0;
            // 
            // Tb_name
            // 
            Tb_name.Location = new Point(77, 9);
            Tb_name.Name = "Tb_name";
            Tb_name.Size = new Size(175, 23);
            Tb_name.TabIndex = 1;
            // 
            // Tb_password
            // 
            Tb_password.Location = new Point(77, 67);
            Tb_password.Name = "Tb_password";
            Tb_password.Size = new Size(100, 23);
            Tb_password.TabIndex = 2;
            // 
            // Tb_confirmPassword
            // 
            Tb_confirmPassword.Location = new Point(77, 96);
            Tb_confirmPassword.Name = "Tb_confirmPassword";
            Tb_confirmPassword.Size = new Size(100, 23);
            Tb_confirmPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 38);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.Location = new Point(14, 88);
            label4.Name = "label4";
            label4.Size = new Size(57, 31);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password";
            // 
            // Btn_submit
            // 
            Btn_submit.Location = new Point(183, 38);
            Btn_submit.Name = "Btn_submit";
            Btn_submit.Size = new Size(69, 23);
            Btn_submit.TabIndex = 8;
            Btn_submit.Text = "Submit";
            Btn_submit.UseVisualStyleBackColor = true;
            Btn_submit.Click += Btn_submit_Click;
            // 
            // F_NewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 138);
            Controls.Add(Btn_submit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Tb_confirmPassword);
            Controls.Add(Tb_password);
            Controls.Add(Tb_name);
            Controls.Add(Tb_login);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_NewUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tb_login;
        private TextBox Tb_name;
        private TextBox Tb_password;
        private TextBox Tb_confirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Btn_submit;
    }
}