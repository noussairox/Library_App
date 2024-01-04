using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LibraryApp.Services
{
    public class LivreService
    {
        private readonly LibraryDbContext _dbContext;

        public LivreService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Read - Obtient la liste de tous les livres
        public List<Livre> GetLivres()
        {
            return _dbContext.Livres.ToList();
        }

        // Create
        public void AddLivre(Livre livre)
        {
            _dbContext.Livres.Add(livre);
            _dbContext.SaveChanges();
        }

        // Update
        public void UpdateLivre(Livre livre)
        {
            var existingLivre = _dbContext.Livres.Find(livre.Id);

            if (existingLivre != null)
            {
                
                existingLivre.Titre = livre.Titre;
                existingLivre.Auteur = livre.Auteur;
                existingLivre.ISBN = livre.ISBN;
                existingLivre.DatePublication = livre.DatePublication;
                existingLivre.QuantiteDisponible = livre.QuantiteDisponible;
                existingLivre.Image = livre.Image;

                _dbContext.SaveChanges();
            }
        }

        // Delete 
        public void DeleteLivre(int livreId)
        {
            var livreToDelete = _dbContext.Livres.Find(livreId);

            if (livreToDelete != null)
            {
                _dbContext.Livres.Remove(livreToDelete);
                _dbContext.SaveChanges();
            }
        }

        public string ExportLivresToCsv()
        {
            var livres = _dbContext.Livres.ToList();

            // Crée une ligne d'en-tête CSV
            var csvContent = new StringBuilder();
            csvContent.AppendLine("ID,Titre,Auteur,ISBN,DatePublication,QuantiteDisponible,Image");

            // Ajoute chaque livre comme une ligne CSV
            foreach (var livre in livres)
            {
                csvContent.AppendLine($"{livre.Id},{livre.Titre},{livre.Auteur},{livre.ISBN}," +
                                      $"{livre.DatePublication},{livre.QuantiteDisponible},{livre.Image}");
            }

            return csvContent.ToString();
        }
    }
}
