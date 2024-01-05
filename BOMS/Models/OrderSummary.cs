namespace BOMS.Models
{
    public class OrderSummary
    {
        //Fields
        private int _Id;
        private bool _Outstanding;
        private DateTime _DateCreated = DateTime.Now;
        private int _Discount;
        private string _Name = string.Empty;
        private string _Email = string.Empty;

        // Properties
        public int Id { get { return _Id; } set { _Id = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public int Discount { get { return _Discount; } set { _Discount = value; } }
        public bool Outstanding { get { return _Outstanding; } set { _Outstanding = value; } }
        public DateTime DateCreated { get { return _DateCreated; } set { _DateCreated = value; } }
    }
}
