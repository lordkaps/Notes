using Microsoft.Maui.ApplicationModel;

namespace Notes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if(BindingContext is Models.About about)
        // Navegue até o URL especificado no navegador do sistema.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
    }
}