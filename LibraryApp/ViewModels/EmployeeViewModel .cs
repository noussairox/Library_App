using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using LibraryApp.Models;

namespace LibraryApp.ViewModels
{
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }


        public EmployeeViewModel()
        {
            // Initialisez la table d'employés depuis la base de données
            Employees = new ObservableCollection<Employee>(GetEmployeesFromDatabase());


        }

        private IQueryable<Employee> GetEmployeesFromDatabase()
        {
            //récupérer les employés depuis la base de données avec Entity Framework Core
            var dbContext = new LibraryDbContext(); 
            return dbContext.Employees;
        }
    }
}
