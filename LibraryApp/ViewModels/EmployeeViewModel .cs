using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
<<<<<<< HEAD
using System.IO;
using System.Linq;
=======
>>>>>>> 733a38ebf05e54512f43fbd6e9c0f6cc95425c0a
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
<<<<<<< HEAD
            // Instancié Table employés depuis la base de données
=======
            // Initialisez la table d'employés depuis la base de données
>>>>>>> 733a38ebf05e54512f43fbd6e9c0f6cc95425c0a
            Employees = new ObservableCollection<Employee>(GetEmployeesFromDatabase());

            // Initialisez service ici
            _libraryService = new LibraryService(new LibraryDbContext()); // Assurez-vous de l'initialiser correctement
        }

        private IQueryable<Employee> GetEmployeesFromDatabase()
        {
<<<<<<< HEAD
            // Code pour récupérer les employés depuis la base de données avec Entity Framework Core
=======
            //récupérer les employés depuis la base de données avec Entity Framework Core
>>>>>>> 733a38ebf05e54512f43fbd6e9c0f6cc95425c0a
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
