using System.Net.Http.Json;

namespace localhostMAUI;



public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCallApiBtnClicked(object sender, EventArgs e)
	{
		var httpClient = new HttpClient();
		var baseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5287" : "http://localhost:5287";
		var response = await httpClient.GetAsync($"{baseUrl}/WeatherForecast");

		var data = await response.Content.ReadAsStringAsync();


			

	}
}

