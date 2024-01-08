using LibraryApp.Models;
using LibraryApp.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace LibraryApp.ViewModels
{
    public class ReservationViewModel
    {
        private readonly ReservationService _reservationService;

        public ObservableCollection<Reservation> Reservations { get; set; }

        public ReservationViewModel()
        {
            Reservations = new ObservableCollection<Reservation>(GetLivresFromDatabase());
            _reservationService = new ReservationService(new LibraryDbContext());
        }
        private IQueryable<Reservation> GetLivresFromDatabase()
        {
            var dbContext = new LibraryDbContext();
            return dbContext.Reservations;
        }
    }
}
