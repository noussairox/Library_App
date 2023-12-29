using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryApp.Services
{
     class MemberService
    {
        private readonly LibraryDbContext _dbContext;

        public MemberService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        //Read
        public List<Membre> GetMembres()
        {
            return _dbContext.Membres.ToList();
        }
        public void AddMembre(Membre membre)
        {
            _dbContext.Membres.Add(membre);
            _dbContext.SaveChanges();
        }

        // MemberService.cs


        public void UpdateMembre(Membre membre)
        {
            try
            {
                if (membre != null)
                {
                    // Récupérer le membre correspondant dans la base de données en utilisant son ID
                    var actualMembre = _dbContext.Membres.Find(membre.MembreId);

                    if (actualMembre != null)
                    {
                        // Afficher des informations sur le membre avant la mise à jour
                        MessageBox.Show($"Updating Membre with MembreId: {membre.MembreId}\nBefore Update: {actualMembre},{membre.DateInscription},nouveau -->,{actualMembre.DateInscription}");

                        // Mettre à jour les propriétés du membre avec les nouvelles valeurs
                        actualMembre.Prenom = membre.Prenom;
                        actualMembre.Nom = membre.Nom;
                        actualMembre.Adresse = membre.Adresse;
                        actualMembre.NumeroTelephone = membre.NumeroTelephone;
                        actualMembre.Email = membre.Email;
                        actualMembre.DateInscription = membre.DateInscription;

                        // Afficher des informations sur le membre après la mise à jour
                        MessageBox.Show($"After Update: {actualMembre}");

                        // Essayer de sauvegarder les modifications
                        _dbContext.SaveChanges();

                        MessageBox.Show("Changes saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Membre not found in the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Membre object provided for update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Membre: {ex.Message}");
            }
        }
        public void DeleteMembre(int membreId)
        {
            try
            {
                var membreToDelete = _dbContext.Membres.Find(membreId);

                if (membreToDelete != null)
                {
                    _dbContext.Membres.Remove(membreToDelete);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Adhérent supprimé avec succès.");
                }
                else
                {
                    MessageBox.Show("Adhérent non trouvé dans la base de données.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'adhérent : {ex.Message}", "Erreur de suppression", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //export csv
        public string ExportMemberToCsv()
        {
            var members = _dbContext.Membres.ToList();

            // Créer une ligne d'en-tête CSV
            var csvContent = new StringBuilder();
            csvContent.AppendLine("ID,Prenom,Nom,Adresse,NumeroTelephone,Email,DateInscription");

            // Ajouter chaque employé comme une ligne CSV
            foreach (var member in members)
            {
                csvContent.AppendLine($"{member.MembreId},{member.Prenom},{member.Nom},{member.Adresse}" +
                    $",{member.NumeroTelephone},{member.Email},{member.DateInscription}");
            }

            return csvContent.ToString();
        }


    }
}
