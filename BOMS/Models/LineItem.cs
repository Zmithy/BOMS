namespace BOMS.Models
{
    public class LineItem
    {
        // Fields
        private int _Id;
        private int _Order_Id;
        private int _Book_Id;


        // Properties
        public int Id { get { return _Id; } set { _Id = value; } }
        public int Order_Id { get { return _Order_Id; } set { _Order_Id = value; } }
        public int Book_Id { get { return _Book_Id; } set { _Book_Id = value; } }


        // Methods
    }
}
