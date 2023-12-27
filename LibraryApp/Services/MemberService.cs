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

        public void UpdateMembre(Membre membre)
        {
            // Check the value of MembreId
            MessageBox.Show($"Updating Membre with MembreId: {membre.MembreId}");

            var actualMembre = _dbContext.Membres.Find(membre.MembreId);

            if (actualMembre != null)
            {
                // Display information about the Membre
                MessageBox.Show($"Updating Database\n{actualMembre}");

                actualMembre.Prenom = membre.Prenom;
                actualMembre.Nom = membre.Nom;
                actualMembre.Adresse = membre.Adresse;
                actualMembre.NumeroTelephone = membre.NumeroTelephone;
                actualMembre.Email = membre.Email;
                actualMembre.DateInscription = DateTime.Now; // Utilisez la date actuelle

                // Try saving changes
                try
                {
                    _dbContext.SaveChanges();
                    MessageBox.Show("Changes saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving changes: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Membre not found in the database.");
            }
        }


    }
}
