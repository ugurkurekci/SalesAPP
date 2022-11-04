using Sales.Api.Business.Dto;
using System.Text;
using System.Text.Json;

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

    private void login_button01_Click(object sender, EventArgs e)
    {
        string url = "https://localhost:7224/api/User/";
        HttpClient httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(url);

        UserRegisterDto userLoginDto = new UserRegisterDto
        {
            Username = username_txb01.Text,
            Email = email_txb02.Text,
            Password = password_txb03.Text
        };

        string serializeUserLogin = JsonSerializer.Serialize(userLoginDto);
        StringContent stringContent = new StringContent(serializeUserLogin, Encoding.UTF8, "application/json");
        HttpResponseMessage result = httpClient.PostAsync("Register", stringContent).Result;
        if (result.IsSuccessStatusCode)
            MessageBox.Show("Kayýt baþarýlý.");
        else
            MessageBox.Show($"Kayýt baþarýsýz.. Hata Kodu: {result.StatusCode}");
    }
}