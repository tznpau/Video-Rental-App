using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental.Entities
{
    [Serializable]
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public Film() { }

        public Film(int filmId, string title, decimal price, bool isAvailable)
        {
            FilmId = filmId;
            Title = title;
            Price = price;
            IsAvailable = isAvailable;
        }
    }
}
