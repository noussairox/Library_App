using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.ViewModels;
using Microsoft.EntityFrameworkCore;
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

namespace LibraryApp.Views
{
    /// <summary>
    /// Logique d'interaction pour MembersView.xaml
    /// </summary>
    public partial class MembersView : Page
    {
        private readonly MemberService _memberService;

        public MembersView()
        {
            InitializeComponent();
            DataContext = new MemberViewModel();

            _memberService = new MemberService(new LibraryDbContext());

            DateInscription.SelectedDate = DateTime.Now;
            LoadMembers();




        }

        private void AjouterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var newMember = new Membre
                {
                    Prenom = Prenom.Text,
                    Nom = Nom.Text,
                    Adresse = Adresse.Text,
                    NumeroTelephone = NumeroTelephone.Text,
                    Email = Email.Text,
                    DateInscription = DateInscription.SelectedDate ?? DateTime.Now
                };

                _memberService.AddMembre(newMember);
                
                LoadMembers();

                Prenom.Text = "";
                Nom.Text = "";
                Adresse.Text = "";
                NumeroTelephone.Text = "";
                Email.Text = "";
                DateInscription.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadMembers()
        {
            // Charger les membres depuis le service et les assigner à la propriété Members
            MembersDataGrid.ItemsSource = _memberService.GetMembres();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadMembers();
        }


        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MembersDataGrid.SelectedItem != null && MembersDataGrid.SelectedItem is Membre selectedMembre)
                {
                    MessageBox.Show($"Selected Membre: {selectedMembre.Prenom}, {selectedMembre.Nom}, {selectedMembre.Adresse},{selectedMembre.DateInscription}");

                    // Créer un objet Membre avec les modifications
                    var updatedMembre = new Membre
                    {
                        MembreId = selectedMembre.MembreId,
                        Prenom = Prenom.Text,
                        Nom = Nom.Text,
                        Adresse = Adresse.Text,
                        NumeroTelephone = NumeroTelephone.Text,
                        Email = Email.Text,
                        DateInscription = DateInscription.SelectedDate ?? DateTime.Now,
                    };

                    // Appeler la méthode UpdateMembre du service
                    _memberService.UpdateMembre(updatedMembre);

                    MessageBox.Show("Mise à jour réussie!");
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un adhérent à mettre à jour.", "Aucun Adhérant sélectionné", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la mise à jour de l'adhérant : {ex.Message}", "Erreur de mise à jour", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MembersDataGrid.SelectedItem != null && MembersDataGrid.SelectedItem is Membre selectedMembre)
                {
                    MessageBox.Show($"Selected Membre to delete: {selectedMembre.Prenom}, {selectedMembre.Nom}, {selectedMembre.Adresse}, {selectedMembre.DateInscription}");

                    // Appeler la méthode DeleteMembre du service
                    _memberService.DeleteMembre(selectedMembre.MembreId);

                    // Recharger la liste des membres après la suppression
                    LoadMembers();

                    MessageBox.Show("Suppression réussie!");
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un adhérent à supprimer.", "Aucun Adhérant sélectionné", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la suppression de l'adhérant : {ex.Message}", "Erreur de suppression", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExportCsvButton_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "Members",
                DefaultExt = ".csv",
                Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*"
            };

            // Affichez la boîte de dialogue de sauvegarde
            if (saveFileDialog.ShowDialog() == true)
            {
                var filePath = saveFileDialog.FileName;

                // Appel de la méthode d'exportation dans le ViewModel
                ((MemberViewModel)DataContext).ExportToCsv(filePath);

                MessageBox.Show($"Les employés ont été exportés avec succès vers : {filePath}", "Exportation réussie", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MembersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (MembersDataGrid.SelectedItem != null && MembersDataGrid.SelectedItem is Membre selectedMembre)
            {
                Console.WriteLine($"Selected Member ID: {selectedMembre.MembreId}");
                MessageBox.Show($"Selected Member ID: {selectedMembre.MembreId}");
                Prenom.Text = selectedMembre.Prenom;
                Nom.Text = selectedMembre.Nom;
                Adresse.Text = selectedMembre.Adresse;
                NumeroTelephone.Text = selectedMembre.NumeroTelephone;
                Email.Text = selectedMembre.Email;
                DateInscription.SelectedDate = selectedMembre.DateInscription;
            }
        }

        private void LivreButton_Click(object sender, RoutedEventArgs e)
        {
                Frame frame = new Frame();
                LivresView livresView = new LivresView();
                frame.Content = livresView;
                Window mainWindow = Window.GetWindow((Button)sender);
                mainWindow.Content = frame;
        }

    }
}

