using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarriageHall;
public partial class FrmDashboard : Form
{
    public FrmDashboard()
    {
        InitializeComponent();
    }

    private void btnBooking_Click(object sender, EventArgs e)
    {
        FrmBooking frmBooking = new FrmBooking();
        Hide();
        frmBooking.ShowDialog();
        Show();
    }

    private void btnManagement_Click(object sender, EventArgs e)
    {

    }
}
