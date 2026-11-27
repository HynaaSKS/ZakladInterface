using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZakladInterface.Tridy;

namespace ZakladInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Vytvoření dvou samostatných zařízení
        Lampa lampa = new Lampa();
        Ventilator ventilator = new Ventilator();
        Projektor projektor = new Projektor();

        public MainWindow()
        {
            InitializeComponent();

            AktualizujStav();
        }

        // Zapnutí vybraného zařízení
        private void BtnZapnout_Click(
            object sender, RoutedEventArgs e)
        {
            if (cmbZarizeni.SelectedIndex == 0)
            {
                lampa.Zapni();
            }
            else if (cmbZarizeni.SelectedIndex == 1)
            {
                ventilator.Zapni();
            }
            else if (cmbZarizeni.SelectedIndex == 2)
            {
                projektor.Zapni();
            }

            AktualizujStav();
        }

        // Vypnutí vybraného zařízení
        private void BtnVypnout_Click(
            object sender, RoutedEventArgs e)
        {
            if (cmbZarizeni.SelectedIndex == 0)
            {
                lampa.Vypni();
            }
            else if (cmbZarizeni.SelectedIndex == 1)
            {
                ventilator.Vypni();
            }
            else if (cmbZarizeni.SelectedIndex == 2)
            {
                projektor.Vypni();
            }

            AktualizujStav();
        }

        // Změna vybraného zařízení
        private void CmbZarizeni_SelectionChanged(
            object sender, SelectionChangedEventArgs e)
        {
            // Ochrana při inicializaci okna
            if (txtStav == null)
                return;

            AktualizujStav();
        }

        // Zobrazení aktuálního stavu
        private void AktualizujStav()
        {
            if (cmbZarizeni.SelectedIndex == 0)
            {
                if (lampa.JeZapnuto)
                    txtStav.Text = "Lampa je zapnutá.";
                else
                    txtStav.Text = "Lampa je vypnutá.";
            }
            else if (cmbZarizeni.SelectedIndex == 1)
            {
                if (ventilator.JeZapnuto)
                    txtStav.Text = "Ventilátor je zapnutý.";
                else
                    txtStav.Text = "Ventilátor je vypnutý.";
            }
            else if (cmbZarizeni.SelectedIndex == 2)
            {
                if (projektor.JeZapnuto)
                    txtStav.Text = "Projektor je zapnutý.";
                else
                    txtStav.Text = "Projektor je vypnutý.";
            }
            string stavLampy;
            string stavVentilatoru;
            string stavProjektoru;

            if (lampa.JeZapnuto)
                stavLampy = "Zapnuto";
            else
                stavLampy = "Vypnuto";

            if (ventilator.JeZapnuto)
                stavVentilatoru = "Zapnuto";
            else
                stavVentilatoru = "Vypnuto";
            if (projektor.JeZapnuto)
                stavProjektoru = "Zapnuto";
            else
                stavProjektoru = "Vypnuto";

            txtPrehled.Text =
                $"Lampa: {stavLampy}\n" +
                $"Ventilátor: {stavVentilatoru}\n" +
                $"Projektor: {stavProjektoru}";
        }
    }
}