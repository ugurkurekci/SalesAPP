namespace SalesApp.WinForm;

public partial class LoginApp : Form
{


    public LoginApp()
    {
        InitializeComponent();
    }



    private void LoginApp_Load(object sender, EventArgs e)
    {

    }

    private void registered_lbl02_Click(object sender, EventArgs e)
    {
        RegisterApp registerApp = new RegisterApp();
        registerApp.Show();
        this.Hide();
    }

    private void LoginApp_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}