using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int LivreId { get; set; }

        [Required]
        public DateTime DateReservation { get; set; }

        [Required]
        public string NomEmprunteur { get; set; }

        [Required]
        public bool EstEmprunte { get; set; }

        [ForeignKey("Id")]
        public Livre Livre { get; set; }
    }

}
