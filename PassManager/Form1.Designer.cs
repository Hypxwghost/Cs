namespace PassManager;

partial class F_Main
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
        Btn_login = new Button();
        Tb_user = new TextBox();
        Tb_pass = new TextBox();
        label1 = new Label();
        label2 = new Label();
        Btn_newUser = new Button();
        SuspendLayout();
        // 
        // Btn_login
        // 
        Btn_login.Location = new Point(66, 59);
        Btn_login.Name = "Btn_login";
        Btn_login.Size = new Size(100, 23);
        Btn_login.TabIndex = 0;
        Btn_login.Text = "Login";
        Btn_login.TextImageRelation = TextImageRelation.ImageAboveText;
        Btn_login.UseVisualStyleBackColor = true;
        Btn_login.Click += Btn_login_Click;
        // 
        // Tb_user
        // 
        Tb_user.Location = new Point(66, 6);
        Tb_user.Name = "Tb_user";
        Tb_user.Size = new Size(100, 23);
        Tb_user.TabIndex = 1;
        // 
        // Tb_pass
        // 
        Tb_pass.Location = new Point(66, 30);
        Tb_pass.Name = "Tb_pass";
        Tb_pass.PasswordChar = '*';
        Tb_pass.Size = new Size(100, 23);
        Tb_pass.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(30, 9);
        label1.Name = "label1";
        label1.Size = new Size(30, 15);
        label1.TabIndex = 3;
        label1.Text = "User";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(3, 33);
        label2.Name = "label2";
        label2.Size = new Size(57, 15);
        label2.TabIndex = 4;
        label2.Text = "Password";
        // 
        // Btn_newUser
        // 
        Btn_newUser.Location = new Point(66, 88);
        Btn_newUser.Name = "Btn_newUser";
        Btn_newUser.Size = new Size(98, 23);
        Btn_newUser.TabIndex = 5;
        Btn_newUser.Text = "New User";
        Btn_newUser.UseVisualStyleBackColor = true;
        Btn_newUser.Click += Btn_newUser_Click;
        // 
        // F_Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(176, 121);
        Controls.Add(Btn_newUser);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(Tb_pass);
        Controls.Add(Tb_user);
        Controls.Add(Btn_login);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "F_Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "PassManager";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button Btn_login;
    private TextBox Tb_user;
    private TextBox Tb_pass;
    private Label label1;
    private Label label2;
    private Button Btn_newUser;
}
