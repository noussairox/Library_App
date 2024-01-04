using LibraryApp.Models;
using LibraryApp.Services;
using System.Collections.ObjectModel;

namespace LibraryApp.ViewModels
{
    public class ReservationViewModel
    {
        private readonly ReservationService _reservationService;

        public ObservableCollection<Reservation> Reservations { get; set; }

        public ReservationViewModel()
        {
            _reservationService = new ReservationService(new LibraryDbContext());
            Reservations = new ObservableCollection<Reservation>(_reservationService.GetReservations());
        }
    }
}
