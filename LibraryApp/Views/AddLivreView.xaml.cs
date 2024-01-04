using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour AddLivreView.xaml
    /// </summary>
    public partial class AddLivreView : Page
    {

        private readonly LivreService _livreService;
        private Livre selectedLivre;

        public AddLivreView()
        {
            InitializeComponent();
            DataContext = new LivreViewModel();

            _livreService = new LivreService(new LibraryDbContext());

            LoadLivres();

        }

        private void LoadLivres()
        {
            LivresDataGrid.ItemsSource = _livreService.GetLivres();
        }

        private void AjouterLivreBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newLivre = new Livre
                {
                    Titre = TitreTextBox.Text,
                    Auteur = AuteurTextBox.Text,
                    ISBN = ISBNTextBox.Text,
                    DatePublication = DatePublicationDatePicker.SelectedDate ?? DateTime.Now,
                    QuantiteDisponible = int.Parse(QuantiteDisponibleTextBox.Text),
                };

                try
                {
                    // Sélectionner une image
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Image files |*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
                    if (openFileDialog.ShowDialog() == true)
                    {
                        // Obtenez le chemin de l'image sélectionnée
                        string imagePath = openFileDialog.FileName;

                        // Gérer l'image, par exemple, en la convertissant en tableau de bytes
                        byte[] imageBytes = File.ReadAllBytes(imagePath);

                        // Ajouter le tableau de bytes à votre objet Livre
                        newLivre.Image = imageBytes;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur s'est produite lors de la gestion de l'image : {ex.Message}");
                }

                _livreService.AddLivre(newLivre);
                LoadLivres();

                TitreTextBox.Text = "";
                AuteurTextBox.Text = "";
                ISBNTextBox.Text = "";
                DatePublicationDatePicker.SelectedDate = DateTime.Now;
                QuantiteDisponibleTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de l'ajout du livre : {ex.Message}", "Erreur d'ajout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LivresDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LivresDataGrid.SelectedItem != null && LivresDataGrid.SelectedItem is Livre selected)
            {
                selectedLivre = selected;
                // Remplir les champs avec les données du livre sélectionné
                TitreTextBox.Text = selected.Titre;
                AuteurTextBox.Text = selected.Auteur;
                ISBNTextBox.Text = selected.ISBN;
                DatePublicationDatePicker.SelectedDate = selected.DatePublication;
                QuantiteDisponibleTextBox.Text = selected.QuantiteDisponible.ToString();
            }
        }

        private void UpdateLivreBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedLivre != null)
                {
                    // Mettre à jour les propriétés du livre avec les nouvelles valeurs
                    selectedLivre.Titre = TitreTextBox.Text;
                    selectedLivre.Auteur = AuteurTextBox.Text;
                    selectedLivre.ISBN = ISBNTextBox.Text;
                    selectedLivre.DatePublication = DatePublicationDatePicker.SelectedDate ?? DateTime.Now;
                    selectedLivre.QuantiteDisponible = int.Parse(QuantiteDisponibleTextBox.Text);

                    // Appeler la méthode UpdateLivre du service
                    _livreService.UpdateLivre(selectedLivre);

                    LoadLivres();

                    // Réinitialiser les champs après la mise à jour
                    TitreTextBox.Text = "";
                    AuteurTextBox.Text = "";
                    ISBNTextBox.Text = "";
                    DatePublicationDatePicker.SelectedDate = DateTime.Now;
                    QuantiteDisponibleTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un livre à mettre à jour.", "Aucun livre sélectionné", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la mise à jour du livre : {ex.Message}", "Erreur de mise à jour", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteLivreBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedLivre != null)
                {
                    // Appeler la méthode DeleteLivre du service
                    _livreService.DeleteLivre(selectedLivre.Id);

                    LoadLivres();

                    // Réinitialiser les champs après la suppression
                    TitreTextBox.Text = "";
                    AuteurTextBox.Text = "";
                    ISBNTextBox.Text = "";
                    DatePublicationDatePicker.SelectedDate = DateTime.Now;
                    QuantiteDisponibleTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un livre à supprimer.", "Aucun livre sélectionné", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la suppression du livre : {ex.Message}", "Erreur de suppression", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
