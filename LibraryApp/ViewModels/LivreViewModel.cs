using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using LibraryApp.Models;
using LibraryApp.Services;
using System.Linq;
using Microsoft.Win32;

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

    }
}
