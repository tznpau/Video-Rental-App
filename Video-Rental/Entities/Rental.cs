using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental.Entities
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int ClientId { get; set; }
        public int FilmId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public RentalStatus Status { get; set; }

        public Rental() { }

        public Rental (int rentalId, int clientId, int filmId, DateTime rentalDate, DateTime dueDate, RentalStatus status)
        {
            ClientId = clientId;
            FilmId = filmId;
            RentalId = rentalId;
            RentalDate = rentalDate;
            DueDate = dueDate;
            Status = status;
        }
    }
}
