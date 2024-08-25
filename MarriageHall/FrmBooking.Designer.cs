namespace MarriageHall;

partial class FrmBooking
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
        label3 = new Label();
        panel2 = new Panel();
        panel5 = new Panel();
        txtNumberOfPeople = new TextBox();
        label4 = new Label();
        panel4 = new Panel();
        cboTime = new ComboBox();
        label2 = new Label();
        panel8 = new Panel();
        comboBox1 = new ComboBox();
        label7 = new Label();
        gbHall = new GroupBox();
        gbFood = new GroupBox();
        listView1 = new ListView();
        panel6 = new Panel();
        btnAdd = new Button();
        cboFood = new ComboBox();
        cboCategory = new ComboBox();
        label6 = new Label();
        label5 = new Label();
        panel3 = new Panel();
        dtpDate = new DateTimePicker();
        label1 = new Label();
        panel7 = new Panel();
        btnBack = new Button();
        btnReset = new Button();
        btnClearBooking = new Button();
        btnBooking = new Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        panel8.SuspendLayout();
        gbFood.SuspendLayout();
        panel6.SuspendLayout();
        panel3.SuspendLayout();
        panel7.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.MistyRose;
        panel1.Controls.Add(label3);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1253, 60);
        panel1.TabIndex = 0;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(561, 18);
        label3.Name = "label3";
        label3.Size = new Size(110, 28);
        label3.TabIndex = 5;
        label3.Text = "Đặt lịch";
        // 
        // panel2
        // 
        panel2.Controls.Add(panel5);
        panel2.Controls.Add(panel4);
        panel2.Controls.Add(panel8);
        panel2.Controls.Add(gbHall);
        panel2.Controls.Add(gbFood);
        panel2.Controls.Add(panel3);
        panel2.Location = new Point(0, 59);
        panel2.Name = "panel2";
        panel2.Size = new Size(1253, 566);
        panel2.TabIndex = 1;
        // 
        // panel5
        // 
        panel5.Controls.Add(txtNumberOfPeople);
        panel5.Controls.Add(label4);
        panel5.Location = new Point(1033, 7);
        panel5.Name = "panel5";
        panel5.Size = new Size(207, 60);
        panel5.TabIndex = 10;
        // 
        // txtNumberOfPeople
        // 
        txtNumberOfPeople.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNumberOfPeople.Location = new Point(87, 14);
        txtNumberOfPeople.Name = "txtNumberOfPeople";
        txtNumberOfPeople.Size = new Size(103, 30);
        txtNumberOfPeople.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(8, 17);
        label4.Name = "label4";
        label4.Size = new Size(73, 24);
        label4.TabIndex = 6;
        label4.Text = "Số người";
        // 
        // panel4
        // 
        panel4.Controls.Add(cboTime);
        panel4.Controls.Add(label2);
        panel4.Location = new Point(765, 7);
        panel4.Name = "panel4";
        panel4.Size = new Size(222, 60);
        panel4.TabIndex = 9;
        // 
        // cboTime
        // 
        cboTime.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboTime.FormattingEnabled = true;
        cboTime.Items.AddRange(new object[] { "Sáng", "Tối" });
        cboTime.Location = new Point(90, 14);
        cboTime.Name = "cboTime";
        cboTime.Size = new Size(113, 31);
        cboTime.TabIndex = 7;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(8, 17);
        label2.Name = "label2";
        label2.Size = new Size(76, 24);
        label2.TabIndex = 6;
        label2.Text = "Thời gian";
        // 
        // panel8
        // 
        panel8.Controls.Add(comboBox1);
        panel8.Controls.Add(label7);
        panel8.Location = new Point(373, 7);
        panel8.Name = "panel8";
        panel8.Size = new Size(349, 60);
        panel8.TabIndex = 11;
        // 
        // comboBox1
        // 
        comboBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Sáng", "Tối" });
        comboBox1.Location = new Point(111, 13);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(224, 31);
        comboBox1.TabIndex = 8;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label7.Location = new Point(8, 17);
        label7.Name = "label7";
        label7.Size = new Size(97, 24);
        label7.TabIndex = 6;
        label7.Text = "Khách hàng";
        // 
        // gbHall
        // 
        gbHall.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        gbHall.Location = new Point(647, 73);
        gbHall.Name = "gbHall";
        gbHall.Size = new Size(593, 485);
        gbHall.TabIndex = 12;
        gbHall.TabStop = false;
        gbHall.Text = "Sảnh";
        // 
        // gbFood
        // 
        gbFood.Controls.Add(listView1);
        gbFood.Controls.Add(panel6);
        gbFood.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        gbFood.Location = new Point(12, 73);
        gbFood.Name = "gbFood";
        gbFood.Size = new Size(629, 485);
        gbFood.TabIndex = 11;
        gbFood.TabStop = false;
        gbFood.Text = "Đồ ăn";
        // 
        // listView1
        // 
        listView1.Location = new Point(6, 114);
        listView1.Name = "listView1";
        listView1.Size = new Size(617, 365);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // panel6
        // 
        panel6.Controls.Add(btnAdd);
        panel6.Controls.Add(cboFood);
        panel6.Controls.Add(cboCategory);
        panel6.Controls.Add(label6);
        panel6.Controls.Add(label5);
        panel6.Location = new Point(8, 31);
        panel6.Name = "panel6";
        panel6.Size = new Size(615, 77);
        panel6.TabIndex = 0;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.Bisque;
        btnAdd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnAdd.Location = new Point(489, 6);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(123, 64);
        btnAdd.TabIndex = 16;
        btnAdd.Text = "Thêm món";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // cboFood
        // 
        cboFood.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboFood.FormattingEnabled = true;
        cboFood.Location = new Point(131, 39);
        cboFood.Name = "cboFood";
        cboFood.Size = new Size(270, 31);
        cboFood.TabIndex = 15;
        // 
        // cboCategory
        // 
        cboCategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboCategory.FormattingEnabled = true;
        cboCategory.Location = new Point(131, 6);
        cboCategory.Name = "cboCategory";
        cboCategory.Size = new Size(270, 31);
        cboCategory.TabIndex = 8;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(3, 42);
        label6.Name = "label6";
        label6.Size = new Size(86, 23);
        label6.TabIndex = 14;
        label6.Text = "Tên món";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.Location = new Point(3, 9);
        label5.Name = "label5";
        label5.Size = new Size(122, 23);
        label5.TabIndex = 13;
        label5.Text = "Thể loại món";
        // 
        // panel3
        // 
        panel3.Controls.Add(dtpDate);
        panel3.Controls.Add(label1);
        panel3.Location = new Point(12, 7);
        panel3.Name = "panel3";
        panel3.Size = new Size(325, 60);
        panel3.TabIndex = 8;
        // 
        // dtpDate
        // 
        dtpDate.CalendarFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dtpDate.Location = new Point(63, 15);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(250, 27);
        dtpDate.TabIndex = 7;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(8, 17);
        label1.Name = "label1";
        label1.Size = new Size(49, 24);
        label1.TabIndex = 6;
        label1.Text = "Ngày";
        // 
        // panel7
        // 
        panel7.Controls.Add(btnBack);
        panel7.Controls.Add(btnReset);
        panel7.Controls.Add(btnClearBooking);
        panel7.Controls.Add(btnBooking);
        panel7.Location = new Point(0, 623);
        panel7.Name = "panel7";
        panel7.Size = new Size(1253, 73);
        panel7.TabIndex = 2;
        // 
        // btnBack
        // 
        btnBack.BackColor = Color.Bisque;
        btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(1117, 0);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(123, 64);
        btnBack.TabIndex = 19;
        btnBack.Text = "Quay lại";
        btnBack.UseVisualStyleBackColor = false;
        // 
        // btnReset
        // 
        btnReset.BackColor = Color.Bisque;
        btnReset.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnReset.Location = new Point(173, 0);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(123, 64);
        btnReset.TabIndex = 19;
        btnReset.Text = "Đặt lại";
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Click += btnReset_Click;
        // 
        // btnClearBooking
        // 
        btnClearBooking.BackColor = Color.Bisque;
        btnClearBooking.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnClearBooking.Location = new Point(326, 0);
        btnClearBooking.Name = "btnClearBooking";
        btnClearBooking.Size = new Size(123, 64);
        btnClearBooking.TabIndex = 18;
        btnClearBooking.Text = "Xóa lịch";
        btnClearBooking.UseVisualStyleBackColor = false;
        btnClearBooking.Click += btnClearBooking_Click;
        // 
        // btnBooking
        // 
        btnBooking.BackColor = Color.Bisque;
        btnBooking.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBooking.Location = new Point(18, 0);
        btnBooking.Name = "btnBooking";
        btnBooking.Size = new Size(123, 64);
        btnBooking.TabIndex = 17;
        btnBooking.Text = "Đặt lịch";
        btnBooking.UseVisualStyleBackColor = false;
        btnBooking.Click += btnBooking_Click;
        // 
        // FrmBooking
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(1252, 695);
        Controls.Add(panel7);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "FrmBooking";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đặt lịch";
        Load += FrmBooking_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        panel8.ResumeLayout(false);
        panel8.PerformLayout();
        gbFood.ResumeLayout(false);
        panel6.ResumeLayout(false);
        panel6.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel7.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label label3;
    private Label label1;
    private Panel panel3;
    private DateTimePicker dtpDate;
    private Panel panel4;
    private Label label2;
    private Panel panel5;
    private Label label4;
    private TextBox txtNumberOfPeople;
    private ComboBox cboTime;
    private GroupBox gbFood;
    private GroupBox gbHall;
    private Panel panel6;
    private ComboBox cboCategory;
    private Label label6;
    private Label label5;
    private ComboBox cboFood;
    private Button btnAdd;
    private ListView listView1;
    private Panel panel7;
    private Button btnClearBooking;
    private Button btnBooking;
    private Button btnReset;
    private Button btnBack;
    private Panel panel8;
    private Label label7;
    private ComboBox comboBox1;
}