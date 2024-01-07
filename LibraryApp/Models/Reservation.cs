using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateReservation { get; set; }

        [Required]
        public string NomEmprunteur { get; set; }
        
        [Required]
        public string Cin { get; set; }

        [Required]
        public bool EstEmprunte { get; set; }

        [Required]
        public int? LivreId { get; set; } // Peut être nullable pour gérer le cas où la réservation est liée à un livre

        public Livre Livre { get; set; }
    }
}
