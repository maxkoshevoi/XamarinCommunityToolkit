using Xamarin.CommunityToolkit.Extensions;

namespace Xamarin.CommunityToolkit.Sample.Pages.TestCases.AlertFromPopup
{
	public partial class AlertFromPopupPage : BasePage
	{
		public AlertFromPopupPage() => InitializeComponent();

		void ShowPopup(object sender, System.EventArgs e) => Navigation.ShowPopup(new SimplePopup());
	}
}