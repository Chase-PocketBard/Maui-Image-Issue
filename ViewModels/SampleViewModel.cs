namespace ImageTest.ViewModels;

public partial class SampleViewModel : BaseViewModel
{
	int count = 0;

	[ObservableProperty]
	public string theImage = "dotnet_bot.svg";

	[ObservableProperty]
	public string message = "Click me";

	[RelayCommand]
	private void OnCounterClicked()
	{
		count++;

		if (count == 1)
			Message = $"Clicked {count} time";
		else
			Message = $"Clicked {count} times";

		SemanticScreenReader.Announce(Message);

		TheImage = "https://picsum.photos/200";

    }
}
