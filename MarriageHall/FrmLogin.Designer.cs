namespace MarriageHall;

partial class FrmLogin
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
        panel1 = new Panel();
        label3 = new Label();
        label2 = new Label();
        panel2 = new Panel();
        txtPassword = new TextBox();
        txtUserName = new TextBox();
        label5 = new Label();
        label4 = new Label();
        label1 = new Label();
        btnLogin = new Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.MistyRose;
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Location = new Point(-2, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(471, 501);
        panel1.TabIndex = 0;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Verdana", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label3.Location = new Point(28, 215);
        label3.Name = "label3";
        label3.Size = new Size(399, 34);
        label3.TabIndex = 4;
        label3.Text = "Stylish and Professional";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Vivaldi", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label2.Location = new Point(92, 148);
        label2.Name = "label2";
        label2.Size = new Size(267, 47);
        label2.TabIndex = 3;
        label2.Text = "Marriage Hall";
        // 
        // panel2
        // 
        panel2.Controls.Add(txtPassword);
        panel2.Controls.Add(txtUserName);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(label4);
        panel2.Location = new Point(475, 175);
        panel2.Name = "panel2";
        panel2.Size = new Size(581, 157);
        panel2.TabIndex = 1;
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtPassword.Location = new Point(184, 84);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(312, 30);
        txtPassword.TabIndex = 3;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // txtUserName
        // 
        txtUserName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtUserName.Location = new Point(184, 37);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(312, 30);
        txtUserName.TabIndex = 2;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(38, 87);
        label5.Name = "label5";
        label5.Size = new Size(91, 23);
        label5.TabIndex = 1;
        label5.Text = "Mật khẩu";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(38, 40);
        label4.Name = "label4";
        label4.Size = new Size(140, 23);
        label4.TabIndex = 0;
        label4.Text = "Tên đăng nhập";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Vivaldi", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label1.Location = new Point(638, 52);
        label1.Name = "label1";
        label1.Size = new Size(267, 47);
        label1.TabIndex = 2;
        label1.Text = "Marriage Hall";
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.Bisque;
        btnLogin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLogin.Location = new Point(642, 363);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(263, 42);
        btnLogin.TabIndex = 3;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // FrmLogin
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(1068, 499);
        Controls.Add(btnLogin);
        Controls.Add(label1);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label label2;
    private Panel panel2;
    private Label label1;
    private Label label3;
    private TextBox txtUserName;
    private Label label5;
    private Label label4;
    private TextBox txtPassword;
    private Button btnLogin;
}
