using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.ViewModels;
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
    }
 }

