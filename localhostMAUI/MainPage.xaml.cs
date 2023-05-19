using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace localhostMAUI;



public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCallApiBtnClicked(object sender, EventArgs e)
	{
      
       var baseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://192.168.10.130:3000" : "http://192.168.10.130:3000";
     

        HttpClient httpClient = new HttpClient();

     
        StringContent httpContent = new StringContent(@"{ ""email"": ""a@a.cl"", ""password"": ""prueba2023"" }", Encoding.UTF8, "application/json");
        var response = await httpClient.PostAsync($"{baseUrl}/auth-server/login", httpContent);

     
        var token = await response.Content.ReadAsStringAsync();
        var token2 = await response.Content.ReadAsStringAsync();



        //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


        var response2 = await httpClient.GetAsync($"{baseUrl}/user-server");


        token2 = await response2.Content.ReadAsStringAsync();

        //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token2);
                

        await DisplayAlert("Resultado", token2 ,"OK");


       








    }
}

