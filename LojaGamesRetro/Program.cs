using System.Globalization;
using LojaGamesRetro.Forms;

namespace LojaGamesRetro
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // forca pt-BR pra moeda e data sairem certinho (R$ e dd/MM/yyyy)
            var cultura = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.DefaultThreadCurrentUICulture = cultura;

            ApplicationConfiguration.Initialize();

            // primeiro mostra o splash, depois abre o menu
            using (var splash = new FrmSplash())
            {
                splash.ShowDialog();
            }

            Application.Run(new FrmMenu());
        }
    }
}
