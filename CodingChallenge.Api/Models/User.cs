namespace CodingChallenge.Api.Models
{
    public class User
    {
        private string firstName;
        private string lastName;

        public int Id { get; set; }
        public string FirstName
        {
            get
            {
                return string.IsNullOrEmpty(firstName) ? "" : firstName.Trim();
            }

            set
            {
                firstName = value;
            }
        }
        public string LastName {
            get
            {
                return string.IsNullOrEmpty(lastName) ? "" : lastName.Trim();
            }

            set
            {
                lastName = value;
            }
        }
        public string Name {
            get
            {
                return string.Concat(FirstName, " ", LastName).Trim();
            }
        }
    }
}