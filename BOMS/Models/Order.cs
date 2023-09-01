using System.ComponentModel.DataAnnotations;

namespace BOMS.Models
{
    public class Order
    {

        // Fields
        [Required]
        private int _Id;

        [Required]
        private DateOnly _Date = DateOnly.FromDateTime(DateTime.Now);

        [Required]
        private  Customer _Customer = new();
         
        [Required]
        private bool _Outstanding;
        [Required]
        private List<Book> _Books = new();

        // Properties 
        public int Id { get { return _Id; }set { _Id = value; } }
        public DateOnly Date { get { return _Date; } set { _Date = value; } }
        public Customer Customer { get { return _Customer; } set { _Customer = value; } }
        public bool Outstanding { get { return _Outstanding; } set { _Outstanding = value; } }
        public List<Book> Books { get { return _Books; } set { _Books = value; } }


        // Dev work
        // customer needs to be its own object 
        
    }
}

  