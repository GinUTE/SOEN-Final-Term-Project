namespace movie_ticket_booking_system.Models
{
    internal class User
    {
        public User(string phone, string fullName, string dateOfBirth, bool isMale, string email, string city)
        {
            Phone = phone;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            IsMale = isMale;
            Email = email;
            City = city;
        }

        public string Phone { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public bool IsMale { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}