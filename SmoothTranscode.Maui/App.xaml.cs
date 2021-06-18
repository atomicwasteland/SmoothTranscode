using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;
using WindowsConfiguration = Microsoft.Maui.Controls.PlatformConfiguration.Windows;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SmoothTranscode.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override IWindow CreateWindow(IActivationState activationState)
        {
            On<WindowsConfiguration>().SetImageDirectory("Assets");

            return new Window(new UI.MainPage());
        }
    }
}
