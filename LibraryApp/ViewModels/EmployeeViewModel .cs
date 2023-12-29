using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using LibraryApp.Models;
using LibraryApp.Services;

namespace LibraryApp.ViewModels
{
    public class EmployeeViewModel
    {
        private readonly LibraryService _libraryService;
        private bool _isAdministrator;


        public ObservableCollection<Employee> Employees { get; set; }
        public bool IsAdministrator
        {
            get { return _isAdministrator; }
            set
            {
                _isAdministrator = value;
                OnPropertyChanged(nameof(IsAdministrator));
            }
        }
        public EmployeeViewModel()
        {
            // Initialisez la table d'employés depuis la base de données
            Employees = new ObservableCollection<Employee>(GetEmployeesFromDatabase());

            // Initialisez service ici
            _libraryService = new LibraryService(new LibraryDbContext());
        }

        private IQueryable<Employee> GetEmployeesFromDatabase()
        {

            //récupérer les employés depuis la base de données avec Entity Framework Core
            var dbContext = new LibraryDbContext(); 
            return dbContext.Employees;
        }

        public void ExportToCsv(string filePath)
        {
            var csvContent = _libraryService.ExportEmployeesToCsv();

            // Enregistrez le contenu CSV dans le fichier spécifié
            File.WriteAllText(filePath, csvContent);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
