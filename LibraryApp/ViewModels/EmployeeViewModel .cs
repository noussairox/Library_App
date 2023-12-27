using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using LibraryApp.Models;
using LibraryApp.Services;

namespace LibraryApp.ViewModels
{
    public class EmployeeViewModel
    {
        private readonly LibraryService _libraryService;

        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeeViewModel()
        {
            // Instancié Table employés depuis la base de données
            Employees = new ObservableCollection<Employee>(GetEmployeesFromDatabase());

            // Initialisez service ici
            _libraryService = new LibraryService(new LibraryDbContext()); // Assurez-vous de l'initialiser correctement
        }

        private IQueryable<Employee> GetEmployeesFromDatabase()
        {
            // Code pour récupérer les employés depuis la base de données avec Entity Framework Core
            var dbContext = new LibraryDbContext(); 
            return dbContext.Employees;
        }

        public void ExportToCsv(string filePath)
        {
            var csvContent = _libraryService.ExportEmployeesToCsv();

            // Enregistrez le contenu CSV dans le fichier spécifié
            File.WriteAllText(filePath, csvContent);
        }
    }
}
