using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Services
{
    public class ReservationService
    {
        private readonly LibraryDbContext _dbContext;

        public ReservationService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList();
        }
    }
}
