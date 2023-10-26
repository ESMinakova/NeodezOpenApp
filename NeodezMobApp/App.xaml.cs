#if __ANDROID__
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif

using Application = Microsoft.Maui.Controls.Application;
namespace NeodezMobApp;



public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("UnderLine", (handler, view) =>
		{
#if __ANDROID__
			
			handler.PlatformView.Bottom = 15;
			handler.PlatformView.SetOutlineAmbientShadowColor(Colors.Blue.ToAndroid());
            handler.PlatformView.SetOutlineSpotShadowColor(Colors.Black.ToAndroid());            
#endif
        });

		MainPage = new AppShell();
	}
}
