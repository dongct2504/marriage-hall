namespace MarriageHall;

partial class FrmViewBooking
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
        dataGridView1 = new DataGridView();
        panel1 = new Panel();
        label3 = new Label();
        panel7 = new Panel();
        btnDownloadBooking = new Button();
        btnBack = new Button();
        btnClearBooking = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        panel7.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.BackgroundColor = Color.Snow;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 66);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(1228, 551);
        dataGridView1.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.BackColor = Color.MistyRose;
        panel1.Controls.Add(label3);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1253, 60);
        panel1.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(501, 18);
        label3.Name = "label3";
        label3.Size = new Size(200, 28);
        label3.TabIndex = 5;
        label3.Text = "Các lịch đã đặt";
        // 
        // panel7
        // 
        panel7.Controls.Add(btnDownloadBooking);
        panel7.Controls.Add(btnBack);
        panel7.Controls.Add(btnClearBooking);
        panel7.Location = new Point(0, 623);
        panel7.Name = "panel7";
        panel7.Size = new Size(1253, 73);
        panel7.TabIndex = 3;
        // 
        // btnDownloadBooking
        // 
        btnDownloadBooking.BackColor = Color.Bisque;
        btnDownloadBooking.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnDownloadBooking.Location = new Point(310, 0);
        btnDownloadBooking.Name = "btnDownloadBooking";
        btnDownloadBooking.Size = new Size(123, 64);
        btnDownloadBooking.TabIndex = 20;
        btnDownloadBooking.Text = "Tải lịch";
        btnDownloadBooking.UseVisualStyleBackColor = false;
        btnDownloadBooking.Click += btnDownloadBooking_Click;
        // 
        // btnBack
        // 
        btnBack.BackColor = Color.Bisque;
        btnBack.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnBack.Location = new Point(821, 0);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(123, 64);
        btnBack.TabIndex = 19;
        btnBack.Text = "Quay lại";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // 
        // btnClearBooking
        // 
        btnClearBooking.BackColor = Color.Bisque;
        btnClearBooking.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btnClearBooking.Location = new Point(561, 0);
        btnClearBooking.Name = "btnClearBooking";
        btnClearBooking.Size = new Size(123, 64);
        btnClearBooking.TabIndex = 18;
        btnClearBooking.Text = "Xóa lịch";
        btnClearBooking.UseVisualStyleBackColor = false;
        btnClearBooking.Click += btnClearBooking_Click;
        // 
        // FrmViewBooking
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1252, 695);
        Controls.Add(panel7);
        Controls.Add(panel1);
        Controls.Add(dataGridView1);
        Name = "FrmViewBooking";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmViewBooking";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel7.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Panel panel1;
    private Label label3;
    private Panel panel7;
    private Button btnBack;
    private Button btnClearBooking;
    private Button btnDownloadBooking;
}