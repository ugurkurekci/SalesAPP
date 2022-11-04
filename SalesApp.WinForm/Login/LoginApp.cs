using Sales.Api.Business.Dto;
using System.Text;
using System.Text.Json;

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

    private void login_button01_Click(object sender, EventArgs e)
    {

        string url = "https://localhost:7224/api/User/";
        HttpClient httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(url);

        UserLoginDto userLoginDto = new UserLoginDto
        {
            Username = username_txb01.Text,
            Password = password_txb02.Text
        };

        string serializeUserLogin = JsonSerializer.Serialize(userLoginDto);
        StringContent stringContent = new StringContent(serializeUserLogin, Encoding.UTF8, "application/json");
        HttpResponseMessage result = httpClient.PostAsync("Login", stringContent).Result;
        if (result.IsSuccessStatusCode)
            MessageBox.Show("Login baþarýlý.");
        else
            MessageBox.Show($"Login baþarýsýz.. Hata Kodu: {result.StatusCode}");



    }
}