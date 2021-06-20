﻿using System.Collections.Generic;
using Xamarin.CommunityToolkit.Sample.Models;
using Xamarin.CommunityToolkit.Sample.Pages.TestCases;
using Xamarin.CommunityToolkit.Sample.Pages.TestCases.AlertFromPopup;
using Xamarin.CommunityToolkit.Sample.Pages.TestCases.PopupFromModal;

namespace Xamarin.CommunityToolkit.Sample.ViewModels.TestCases
{
	public class TestCasesGalleryViewModel : BaseGalleryViewModel
	{
		protected override IEnumerable<SectionModel> CreateItems() => new[]
		{
			new SectionModel(
				typeof(TouchEffectButtonPage),
				"TouchEffect + Button",
				"TouchEffect must automatically invoke button'c command execution."),

			new SectionModel(
				typeof(TouchEffectCollectionViewPage),
				"TouchEffect + CollectionView",
				"Using TouchEffect's LongPress should allow still use items selection."),

			new SectionModel(
				typeof(MediaElementSourcePage),
				"MediaElement with Source as string",
				"MediaElement should reproduce the video."),

			new SectionModel(
				typeof(TabViewBindingPage),
				"TabView BindingContext",
				"TabView with BindingContext into MainPage and other BindingContext into TabViewItem."),

			new SectionModel(
				typeof(PopupFromModalPage),
				"Popup into modal",
				"Using Popup into modal page show the popup"),

			new SectionModel(
				typeof(AlertFromPopupPage),
				"Alert from Popup",
				"Displaying Alert on top of Popup should maake page even darker"),
		};
	}
}