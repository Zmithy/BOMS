using System.ComponentModel;

namespace BOMS.Models
{
    public class Customer 
    {
        // Fields
        private int _Id;
        private string? _Name;
        private string? _Email;
        private string? _Phone;
        private string? _City;
        private string? _Region;
        private string? _PostalCode;



        //Properties
        public int Id { get { return _Id; } set { _Id = value; } }
        
        public string? Name { get { return _Name; }  set { _Name = value; } }
        public string? Email { get { return _Email; } set { _Email = value; } }
        public string? Phone { get { return _Phone; } set { _Phone = value; } }
        public string? City { get { return _City; } set { _City = value; } }
        public  string? Region { get { return _Region; } set { _Region = value; } }
        public string? PostalCode { get { return _PostalCode; } set { _PostalCode = value; } }

      

        public static Customer GenerateRandomCustomer()
        {
            Random r = new Random();
            List<string> names = new List<string>
            {
                "John",
                "Ben",
                "Pierre",
                "Morgan",
                "Trish",
                "Deb",
                "Ron",
                "Dave",
                "Laura"
            };
            List<string> emails = new List<string>
            {
                "bigGuy@domain.com",
                "catlover12@domain.com",
                "truckdriver@domain.com",
                "sportsTeamFan@domain.com",
                "bigSportsTeamFan@domain.com",
                "mailer@domain.com"
            };
            List<string> phones = new List<string>
            {
                "800-123-5567",
                "800-263-0567",
                "800-823-1327",
                "800-427-0567",
                "800-153-9467",
                "800-173-5067",
                "800-123-4416",
            };
            List<string> cities = new List<string>
            {
                "Rivertown",
                "Cityville",
                "Metro City",
                "Small Town USA",
                "Suburbia"
            };
            List<string> region = new List<string>
            {
                "USA",
                "EU",
                "OCE",
                "ASIA",
                "MEA"
            };
            List<string> postalCodes = new List<string>
            {
                "12345",
                "54321",
                "42562",
                "90210",
                "86753"
            };

            Customer customer = new()
            {
                Name = names[r.Next(names.Count)],
                Email = emails[r.Next(emails.Count)],
                Phone = phones[r.Next(phones.Count)],
                City = cities[r.Next(cities.Count)],
                Region = region[r.Next(region.Count)],
                PostalCode = postalCodes[r.Next(postalCodes.Count)]
            };
            
            return customer;
        }


        
    }
}
