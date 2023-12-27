using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.ViewModels;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace LibraryApp.Views
{
    public partial class EmployeesView : Page
    {
        private readonly LibraryService _libraryService;

        public EmployeesView()
        {
            InitializeComponent();
            DataContext = new EmployeeViewModel();

            _libraryService = new LibraryService(new LibraryDbContext()); // Initialisez votre LibraryService
        }

        private void EmployeesView_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newEmployee = new Employee
                {
                    Name = NomTextBox.Text,
                    FirstName = PrenomTextBox.Text,
                    Email = EmailTextBox.Text,
                    Role = (RoleType)Enum.Parse(typeof(RoleType), RoleTextBox.Text.ToString())

                };

                _libraryService.AddEmployee(newEmployee);
                RefreshDataGrid();

                NomTextBox.Text = "";
                PrenomTextBox.Text = "";
                EmailTextBox.Text = "";
                RoleTextBox.Text = "";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EmployeesDataGrid.SelectedItem != null && EmployeesDataGrid.SelectedItem is Employee selectedEmployee)
                {
                    MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet employé ?", "Confirmation de suppression", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        _libraryService.DeleteEmployee(selectedEmployee.Id);
                        RefreshDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un employé à supprimer.", "Aucun employé sélectionné", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la suppression de l'employé : {ex.Message}", "Erreur de suppression", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EmployeesDataGrid.SelectedItem != null && EmployeesDataGrid.SelectedItem is Employee selectedEmployee)
                {
                    var updatedEmployee = new Employee
                    {
                        Id = selectedEmployee.Id,
                        Name = NomTextBox.Text,
                        FirstName = PrenomTextBox.Text,
                        Email = EmailTextBox.Text,
                        Role = (RoleType)Enum.Parse(typeof(RoleType), RoleTextBox.Text.ToString())
                    };

                    _libraryService.UpdateEmployee(updatedEmployee);
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un employé à mettre à jour.", "Aucun employé sélectionné", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la mise à jour de l'employé : {ex.Message}", "Erreur de mise à jour", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void EmployeesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem != null && EmployeesDataGrid.SelectedItem is Employee selectedEmployee)
            {
                // Afficher les détails de l'employé sélectionné dans les TextBox associés
                NomTextBox.Text = selectedEmployee.Name;
                PrenomTextBox.Text = selectedEmployee.FirstName;
                EmailTextBox.Text = selectedEmployee.Email;
                RoleTextBox.Text = selectedEmployee.Role.ToString();
            }
        }


        private void RefreshDataGrid()
        {
            EmployeesDataGrid.ItemsSource = _libraryService.GetEmployees();
        }

        private void ExportCsvButton_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "Employees",
                DefaultExt = ".csv",
                Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*"
            };

            // Affichez la boîte de dialogue de sauvegarde
            if (saveFileDialog.ShowDialog() == true)
            {
                var filePath = saveFileDialog.FileName;

                // Appel de la méthode d'exportation dans le ViewModel
                ((EmployeeViewModel)DataContext).ExportToCsv(filePath);

                MessageBox.Show($"Les employés ont été exportés avec succès vers : {filePath}", "Exportation réussie", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Actualiser_Click(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Instanciez le cadre (Frame) pour la navigation
            Frame frame = new Frame();

            // Créez une instance de la page MembersView
            MembersView membersView = new MembersView();

            // Définissez la page à afficher dans le cadre
            frame.Content = membersView;

            // Obtenez la fenêtre principale à partir du bouton cliqué
            Window mainWindow = Window.GetWindow((Button)sender);

            // Définissez la fenêtre principale pour afficher le cadre
            mainWindow.Content = frame;
        }

        
    }
}
