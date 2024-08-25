namespace MarriageHall;

partial class FrmDashboard
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
        panel1 = new Panel();
        label1 = new Label();
        btnBooking = new Button();
        btnManagement = new Button();
        btnLogout = new Button();
        panel2 = new Panel();
        panel3 = new Panel();
        label2 = new Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(btnLogout);
        panel1.Controls.Add(label1);
        panel1.Location = new Point(-1, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1164, 68);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Vivaldi", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label1.Location = new Point(13, 9);
        label1.Name = "label1";
        label1.Size = new Size(267, 47);
        label1.TabIndex = 3;
        label1.Text = "Marriage Hall";
        // 
        // btnBooking
        // 
        btnBooking.BackColor = Color.Bisque;
        btnBooking.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBooking.Location = new Point(69, 69);
        btnBooking.Name = "btnBooking";
        btnBooking.Size = new Size(162, 42);
        btnBooking.TabIndex = 4;
        btnBooking.Text = "Đặt lịch";
        btnBooking.UseVisualStyleBackColor = false;
        btnBooking.Click += btnBooking_Click;
        // 
        // btnManagement
        // 
        btnManagement.BackColor = Color.Bisque;
        btnManagement.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnManagement.Location = new Point(69, 142);
        btnManagement.Name = "btnManagement";
        btnManagement.Size = new Size(162, 42);
        btnManagement.TabIndex = 5;
        btnManagement.Text = "Quản lý";
        btnManagement.UseVisualStyleBackColor = false;
        btnManagement.Click += btnManagement_Click;
        // 
        // btnLogout
        // 
        btnLogout.BackColor = Color.Bisque;
        btnLogout.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnLogout.Location = new Point(991, 9);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(162, 42);
        btnLogout.TabIndex = 6;
        btnLogout.Text = "Đăng xuất";
        btnLogout.UseVisualStyleBackColor = false;
        // 
        // panel2
        // 
        panel2.Controls.Add(btnManagement);
        panel2.Controls.Add(btnBooking);
        panel2.Location = new Point(-1, 74);
        panel2.Name = "panel2";
        panel2.Size = new Size(322, 455);
        panel2.TabIndex = 1;
        // 
        // panel3
        // 
        panel3.Controls.Add(label2);
        panel3.Location = new Point(327, 74);
        panel3.Name = "panel3";
        panel3.Size = new Size(836, 455);
        panel3.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(13, 11);
        label2.Name = "label2";
        label2.Size = new Size(173, 28);
        label2.TabIndex = 7;
        label2.Text = "Về chúng tôi";
        // 
        // FrmDashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(1164, 528);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "FrmDashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Trang chủ";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Button btnBooking;
    private Button btnLogout;
    private Button btnManagement;
    private Panel panel2;
    private Panel panel3;
    private Label label2;
}