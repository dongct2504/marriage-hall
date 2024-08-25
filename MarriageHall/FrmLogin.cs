namespace MarriageHall;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        FrmDashboard frmDashboard = new FrmDashboard();
        Hide();
        frmDashboard.ShowDialog();
        Show();
    }
}
