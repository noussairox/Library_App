using LibraryApp.Models;
using LibraryApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.ViewModels
{
    class MemberViewModel
    {
        //private readonly MemberService _membreservice;
        public ObservableCollection<Membre> Membres { get; set; }

        public MemberViewModel()
        {
            Membres = new ObservableCollection<Membre>(GetMembresFromDatabase());
        }
        private IQueryable<Membre> GetMembresFromDatabase()
        {
            var dbContext = new LibraryDbContext();
            return dbContext.Membres;
        }

    }
}
