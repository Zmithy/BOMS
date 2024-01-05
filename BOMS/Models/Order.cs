using System.ComponentModel.DataAnnotations;

namespace BOMS.Models
{
    public class Order 
    {

        // Fields
        [Required]
        private int _Id;
        private DateTime _DateCreated = DateTime.Now;
        private int _CustomerId = new();
        [Required]
        private bool _Outstanding = true;
        private int _Discount = 0;
        

        // Properties 
        public int Id { get { return _Id; }set { _Id = value; } }
        public DateTime DateCreated { get { return _DateCreated; } set { _DateCreated = value; } }
        public int CustomerId { get { return _CustomerId; } set { _CustomerId = value; } }
        public bool Outstanding { get { return _Outstanding; } set { _Outstanding = value; } }
        public int Discount { get { return _Discount; } set { _Discount = value; } }
 
    }
}

  