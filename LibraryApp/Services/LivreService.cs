using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class LivreService
    {
        private readonly LibraryDbContext _dbContext;

        public LivreService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Livre> GetLivres()
        {
            return _dbContext.Livres.ToList();
        }
    }
}
