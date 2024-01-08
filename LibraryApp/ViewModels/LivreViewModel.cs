using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using LibraryApp.Models;
using LibraryApp.Services;
using System.Linq;
using Microsoft.Win32;
using System.Windows;

namespace LibraryApp.ViewModels
{
    public class LivreViewModel
    {
        private readonly LivreService _livreService;

        public ObservableCollection<Livre> Livres { get; set; }

        public LivreViewModel()
        {
            Livres = new ObservableCollection<Livre>(GetLivresFromDatabase());
            _livreService = new LivreService(new LibraryDbContext());
        }

        private IQueryable<Livre> GetLivresFromDatabase()
        {
            var dbContext = new LibraryDbContext();
            return dbContext.Livres;
        }

        public void ExportToCsv(string filePath)
        {
            var csvContent = _livreService.ExportLivresToCsv();

            // Enregistrez le contenu CSV dans le fichier spécifié
            File.WriteAllText(filePath, csvContent);
        }
        public void ImportFromCsv(string filePath)
        {
            _livreService.ImportLivresFromCsv(filePath);

            // Mettez à jour la collection après l'importation
            Livres.Clear();
            foreach (var livre in GetLivresFromDatabase())
            {
                Livres.Add(livre);
            }

            MessageBox.Show("Les livres ont été importés avec succès.", "Importation réussie", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
