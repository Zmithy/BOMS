using System.ComponentModel.DataAnnotations;

namespace BOMS.Models
{
    public class Order 
    {

        // Fields
        [Required]
        private int _Id;

        
        private DateTime _Date = DateTime.Now;
        

        [Required]
        private  Customer _Customer = new();
         
        [Required]
        private bool _Outstanding;
        

        // Properties 
        public int Id { get { return _Id; }set { _Id = value; } }
        public DateTime Date { get { return _Date; } set { _Date = value; } }
        public Customer Customer { get { return _Customer; } set { _Customer = value; } }
        public bool Outstanding { get { return _Outstanding; } set { _Outstanding = value; } }
 
    }
}

  