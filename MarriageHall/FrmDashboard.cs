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

    private void btnViewBooking_Click(object sender, EventArgs e)
    {
        FrmViewBooking frmViewBooking = new FrmViewBooking();
        Hide();
        frmViewBooking.ShowDialog();
        Show();
    }

    private void btnCustomer_Click(object sender, EventArgs e)
    {
        FrmCustomer frmCustomer = new FrmCustomer();
        Hide();
        frmCustomer.ShowDialog();
        Show();
    }
}
