namespace Xamarin.CommunityToolkit.Sample.Pages.TestCases.AlertFromPopup
{
	public partial class SimplePopup
	{
		public SimplePopup() => InitializeComponent();

		async void OpenAlert(object sender, System.EventArgs e) => await App.Current.MainPage.DisplayActionSheet("Hi", "there", "Cancel");
	}
}