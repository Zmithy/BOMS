using System.ComponentModel.DataAnnotations;

namespace BOMS.Models
{
    public class Book 
    {
        // Fields
        private int _Id;
        private string? _Title;
        private decimal _Price;
        private int _Discount;
        private string _ISBN = "";
        private string? _Notes;


        // Properties
        public int Id { get { return _Id; } set { _Id = value; } }
        public string? Title { get { return _Title;} set { _Title = value; } }
        public decimal Price { get { return _Price; } set { _Price = value; } }
        public int Discount { get { return _Discount; } set { _Discount = value; } }
        public string ISBN { get { return _ISBN; } set { _ISBN = value; } }
        public string? Notes { get { return _Notes; } set { _Notes = value; } }

        
    }

    
}
