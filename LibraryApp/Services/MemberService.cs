using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
     class MemberService
    {
        private readonly LibraryDbContext _dbContext;

        public MemberService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        //Read
        public List<Membre> GetMembres()
        {
            return _dbContext.Membres.ToList();
        }
        public void AddMembre(Membre membre)
        {
            _dbContext.Membres.Add(membre);
            _dbContext.SaveChanges();
        }

    }
}
