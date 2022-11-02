namespace SalesApp.WinForm;

public partial class RegisterApp : Form
{
    public RegisterApp()
    {
        InitializeComponent();
    }

    private void RegisterApp_Load(object sender, EventArgs e)
    {
    }

    private void RegisterApp_FormClosed(object sender, FormClosedEventArgs e)
    {
        LoginApp loginApp = new LoginApp();
        loginApp.Show();
    }

    private void username_txb01_TextChanged(object sender, EventArgs e)
    {

    }
}