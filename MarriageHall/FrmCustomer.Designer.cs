namespace MarriageHall;

partial class FrmCustomer
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
        panel2 = new Panel();
        label3 = new Label();
        panel5 = new Panel();
        txtName = new TextBox();
        label4 = new Label();
        panel3 = new Panel();
        panel7 = new Panel();
        txtAddress = new TextBox();
        label5 = new Label();
        panel6 = new Panel();
        cboGender = new ComboBox();
        label2 = new Label();
        panel4 = new Panel();
        txtPhone = new TextBox();
        label1 = new Label();
        panel8 = new Panel();
        btnBack = new Button();
        btnReset = new Button();
        btnDelete = new Button();
        btnUpdate = new Button();
        btnAdd = new Button();
        label6 = new Label();
        dataGridView1 = new DataGridView();
        panel1.SuspendLayout();
        panel5.SuspendLayout();
        panel3.SuspendLayout();
        panel7.SuspendLayout();
        panel6.SuspendLayout();
        panel4.SuspendLayout();
        panel8.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.MistyRose;
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(label3);
        panel1.Location = new Point(0, 1);
        panel1.Name = "panel1";
        panel1.Size = new Size(1253, 60);
        panel1.TabIndex = 1;
        // 
        // panel2
        // 
        panel2.Location = new Point(0, 66);
        panel2.Name = "panel2";
        panel2.Size = new Size(1253, 125);
        panel2.TabIndex = 12;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(496, 20);
        label3.Name = "label3";
        label3.Size = new Size(265, 28);
        label3.TabIndex = 5;
        label3.Text = "Quản lý khách hàng";
        // 
        // panel5
        // 
        panel5.Controls.Add(txtName);
        panel5.Controls.Add(label4);
        panel5.Location = new Point(37, 5);
        panel5.Name = "panel5";
        panel5.Size = new Size(282, 60);
        panel5.TabIndex = 11;
        // 
        // txtName
        // 
        txtName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtName.Location = new Point(52, 14);
        txtName.Name = "txtName";
        txtName.Size = new Size(213, 30);
        txtName.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(8, 17);
        label4.Name = "label4";
        label4.Size = new Size(38, 24);
        label4.TabIndex = 6;
        label4.Text = "Tên";
        // 
        // panel3
        // 
        panel3.Controls.Add(panel7);
        panel3.Controls.Add(panel6);
        panel3.Controls.Add(panel4);
        panel3.Controls.Add(panel5);
        panel3.Location = new Point(0, 67);
        panel3.Name = "panel3";
        panel3.Size = new Size(1253, 68);
        panel3.TabIndex = 12;
        // 
        // panel7
        // 
        panel7.Controls.Add(txtAddress);
        panel7.Controls.Add(label5);
        panel7.Location = new Point(900, 5);
        panel7.Name = "panel7";
        panel7.Size = new Size(306, 60);
        panel7.TabIndex = 13;
        // 
        // txtAddress
        // 
        txtAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtAddress.Location = new Point(73, 14);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(214, 30);
        txtAddress.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(8, 17);
        label5.Name = "label5";
        label5.Size = new Size(59, 24);
        label5.TabIndex = 6;
        label5.Text = "Địa chỉ";
        // 
        // panel6
        // 
        panel6.Controls.Add(cboGender);
        panel6.Controls.Add(label2);
        panel6.Location = new Point(666, 5);
        panel6.Name = "panel6";
        panel6.Size = new Size(213, 60);
        panel6.TabIndex = 12;
        // 
        // cboGender
        // 
        cboGender.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboGender.FormattingEnabled = true;
        cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
        cboGender.Location = new Point(85, 14);
        cboGender.Name = "cboGender";
        cboGender.Size = new Size(113, 31);
        cboGender.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(8, 17);
        label2.Name = "label2";
        label2.Size = new Size(71, 24);
        label2.TabIndex = 6;
        label2.Text = "Giới tính";
        // 
        // panel4
        // 
        panel4.Controls.Add(txtPhone);
        panel4.Controls.Add(label1);
        panel4.Location = new Point(338, 5);
        panel4.Name = "panel4";
        panel4.Size = new Size(306, 60);
        panel4.TabIndex = 12;
        // 
        // txtPhone
        // 
        txtPhone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtPhone.Location = new Point(117, 14);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(170, 30);
        txtPhone.TabIndex = 7;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(8, 17);
        label1.Name = "label1";
        label1.Size = new Size(103, 24);
        label1.TabIndex = 6;
        label1.Text = "Số điện thoại";
        // 
        // panel8
        // 
        panel8.Controls.Add(btnBack);
        panel8.Controls.Add(btnReset);
        panel8.Controls.Add(btnDelete);
        panel8.Controls.Add(btnUpdate);
        panel8.Controls.Add(btnAdd);
        panel8.Location = new Point(0, 141);
        panel8.Name = "panel8";
        panel8.Size = new Size(1253, 68);
        panel8.TabIndex = 14;
        // 
        // btnBack
        // 
        btnBack.BackColor = Color.Bisque;
        btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(1083, 0);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(123, 64);
        btnBack.TabIndex = 21;
        btnBack.Text = "Quay lại";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.Bisque;
        btnReset.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnReset.Location = new Point(511, 0);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(123, 64);
        btnReset.TabIndex = 20;
        btnReset.Text = "Làm lại";
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Click += btnReset_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Bisque;
        btnDelete.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDelete.Location = new Point(355, 0);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(123, 64);
        btnDelete.TabIndex = 19;
        btnDelete.Text = "Xóa";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.Bisque;
        btnUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnUpdate.Location = new Point(196, 0);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(123, 64);
        btnUpdate.TabIndex = 18;
        btnUpdate.Text = "Sửa";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.Bisque;
        btnAdd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAdd.Location = new Point(37, 0);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(123, 64);
        btnAdd.TabIndex = 17;
        btnAdd.Text = "Thêm";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.Location = new Point(496, 225);
        label6.Name = "label6";
        label6.Size = new Size(263, 25);
        label6.TabIndex = 13;
        label6.Text = "Danh sách khách hàng";
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = Color.Snow;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 268);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(1228, 427);
        dataGridView1.TabIndex = 15;
        // 
        // FrmCustomer
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(1252, 695);
        Controls.Add(dataGridView1);
        Controls.Add(label6);
        Controls.Add(panel8);
        Controls.Add(panel3);
        Controls.Add(panel1);
        Name = "FrmCustomer";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmCustomer";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        panel3.ResumeLayout(false);
        panel7.ResumeLayout(false);
        panel7.PerformLayout();
        panel6.ResumeLayout(false);
        panel6.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        panel8.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label label3;
    private Panel panel2;
    private Panel panel5;
    private TextBox txtName;
    private Label label4;
    private Panel panel3;
    private Panel panel6;
    private Label label2;
    private Panel panel4;
    private TextBox txtPhone;
    private Label label1;
    private Panel panel7;
    private TextBox txtAddress;
    private Label label5;
    private ComboBox cboGender;
    private Panel panel8;
    private Button btnReset;
    private Button btnDelete;
    private Button btnUpdate;
    private Button btnAdd;
    private Label label6;
    private Button btnBack;
    private DataGridView dataGridView1;
}