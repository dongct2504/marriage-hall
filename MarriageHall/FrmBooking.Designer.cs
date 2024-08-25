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
        gbHall = new GroupBox();
        gbFood = new GroupBox();
        panel6 = new Panel();
        cboFood = new ComboBox();
        cboCategory = new ComboBox();
        label6 = new Label();
        label5 = new Label();
        panel5 = new Panel();
        txtNumberOfPeople = new TextBox();
        label4 = new Label();
        panel4 = new Panel();
        cboTime = new ComboBox();
        label2 = new Label();
        panel3 = new Panel();
        dtpDate = new DateTimePicker();
        label1 = new Label();
        button1 = new Button();
        listView1 = new ListView();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        gbFood.SuspendLayout();
        panel6.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        panel3.SuspendLayout();
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
        panel2.Controls.Add(gbHall);
        panel2.Controls.Add(gbFood);
        panel2.Controls.Add(panel5);
        panel2.Controls.Add(panel4);
        panel2.Controls.Add(panel3);
        panel2.Location = new Point(0, 59);
        panel2.Name = "panel2";
        panel2.Size = new Size(1253, 572);
        panel2.TabIndex = 1;
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
        // panel6
        // 
        panel6.Controls.Add(button1);
        panel6.Controls.Add(cboFood);
        panel6.Controls.Add(cboCategory);
        panel6.Controls.Add(label6);
        panel6.Controls.Add(label5);
        panel6.Location = new Point(8, 31);
        panel6.Name = "panel6";
        panel6.Size = new Size(615, 77);
        panel6.TabIndex = 0;
        // 
        // cboFood
        // 
        cboFood.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboFood.FormattingEnabled = true;
        cboFood.Items.AddRange(new object[] { "Day", "Night" });
        cboFood.Location = new Point(131, 39);
        cboFood.Name = "cboFood";
        cboFood.Size = new Size(270, 31);
        cboFood.TabIndex = 15;
        // 
        // cboCategory
        // 
        cboCategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboCategory.FormattingEnabled = true;
        cboCategory.Items.AddRange(new object[] { "Day", "Night" });
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
        // panel5
        // 
        panel5.Controls.Add(txtNumberOfPeople);
        panel5.Controls.Add(label4);
        panel5.Location = new Point(918, 7);
        panel5.Name = "panel5";
        panel5.Size = new Size(322, 60);
        panel5.TabIndex = 10;
        // 
        // txtNumberOfPeople
        // 
        txtNumberOfPeople.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNumberOfPeople.Location = new Point(87, 14);
        txtNumberOfPeople.Name = "txtNumberOfPeople";
        txtNumberOfPeople.Size = new Size(219, 30);
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
        label4.Text = "Số lượng";
        // 
        // panel4
        // 
        panel4.Controls.Add(cboTime);
        panel4.Controls.Add(label2);
        panel4.Location = new Point(449, 7);
        panel4.Name = "panel4";
        panel4.Size = new Size(350, 60);
        panel4.TabIndex = 9;
        // 
        // cboTime
        // 
        cboTime.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboTime.FormattingEnabled = true;
        cboTime.Items.AddRange(new object[] { "Day", "Night" });
        cboTime.Location = new Point(90, 14);
        cboTime.Name = "cboTime";
        cboTime.Size = new Size(237, 31);
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
        // button1
        // 
        button1.BackColor = Color.Bisque;
        button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(489, 6);
        button1.Name = "button1";
        button1.Size = new Size(123, 64);
        button1.TabIndex = 16;
        button1.Text = "Thêm món";
        button1.UseVisualStyleBackColor = false;
        // 
        // listView1
        // 
        listView1.Location = new Point(6, 114);
        listView1.Name = "listView1";
        listView1.Size = new Size(617, 365);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // FrmBooking
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Snow;
        ClientSize = new Size(1252, 629);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "FrmBooking";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đặt lịch";
        Load += FrmBooking_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        gbFood.ResumeLayout(false);
        panel6.ResumeLayout(false);
        panel6.PerformLayout();
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
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
    private Button button1;
    private ListView listView1;
}