using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LibraryService _libraryService;

        public MainWindow()
        {
            InitializeComponent();
            _libraryService = new LibraryService(new LibraryDbContext());

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Récupérez la valeur du CheckBox
            RoleType role = IsAdministrator.IsChecked == true ? RoleType.Administrator : RoleType.Employee;

            // Authentifiez l'utilisateur
            Employee authenticatedEmployee = _libraryService.AuthenticateUser(username, password);

            if (authenticatedEmployee != null)
            {
                // Redirigez en fonction du rôle
                if (role == RoleType.Administrator)
                {
                    // Ouvrez la vue de l'administrateur
                    mainFrame.Navigate(new EmployeesView());
                }
                else
                {
                    // Ouvrez la vue du membre
                    mainFrame.Navigate(new MembersView());
                }
            }
            else
            {
                // Affichez un message d'erreur en cas d'échec de l'authentification
                MessageBox.Show("L'authentification a échoué. Veuillez vérifier votre nom d'utilisateur et votre mot de passe.");
            }
        }




        private void mainFrame_Navigated_1(object sender, NavigationEventArgs e)
        {

        }
    }
}
