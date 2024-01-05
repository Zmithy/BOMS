using System.ComponentModel.DataAnnotations;

namespace BOMS.Models
{
    public class Book 
    {
        // Fields
        private int _Id;
        [Display(Name = "")]
        private string? _Title;

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required.")]
        private decimal _Price;
        

        [Display(Name = "ISBN")]
        [Required(ErrorMessage = "ISBN is required.")]
        private string _ISBN = "";

        [Display(Name = "Notes")]
        private string? _Notes;


        // Properties
        public int Id { get { return _Id; } set { _Id = value; } }
        public string? Title { get { return _Title;} set { _Title = value; } }
        public decimal Price { get { return _Price; } set { _Price = value; } }
        public string ISBN { get { return _ISBN; } set { _ISBN = value; } }
        public string? Notes { get { return _Notes; } set { _Notes = value; } }

        
    }

    
}
