using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryApp.Views
{
    /// <summary>
    /// Logique d'interaction pour LivresView.xaml
    /// </summary>
    public partial class LivresView : Page
    {
        private readonly LivreService _livreService ;
        public LivresView()
        {
            InitializeComponent();
            DataContext = new LivreViewModel();

            _livreService = new LivreService(new LibraryDbContext()); // Initialisez votre LibraryService
        }

        private void AjouterLivreButton_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = new Frame();
            AddLivreView addLivreView = new AddLivreView();
            frame.Content = addLivreView;
            Window mainWindow = Window.GetWindow((Button)sender);
            mainWindow.Content = frame;
        }

        private void ExportCsvButton_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "Livres",
                DefaultExt = ".csv",
                Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*"
            };

            // Affichez la boîte de dialogue de sauvegarde
            if (saveFileDialog.ShowDialog() == true)
            {
                var filePath = saveFileDialog.FileName;

                // Appel de la méthode d'exportation dans le ViewModel
                ((MemberViewModel)DataContext).ExportToCsv(filePath);

                MessageBox.Show($"Les Livres ont été exportés avec succès vers : {filePath}", "Exportation réussie", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
