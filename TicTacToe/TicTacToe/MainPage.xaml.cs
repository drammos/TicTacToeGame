namespace TicTacToe;


public partial class MainPage : ContentPage
{
	bool start = false;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClickedStartGame(object sender, EventArgs e)
	{

		start = true;

		if (start) {
			var nextPage = new StartGame();
			Navigation.PushAsync(nextPage);
		}

	}
}

