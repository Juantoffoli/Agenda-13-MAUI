using MauiAppHotel.Views;

namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar rotas para navegação
            Routing.RegisterRoute(nameof(SobrePage), typeof(SobrePage));
            Routing.RegisterRoute(nameof(HospedagemContratada), typeof(HospedagemContratada));
        }
    }
}
