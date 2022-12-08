namespace movie_ticket_booking_system.Models
{
    internal class Account
    {
        public Account(string phone, string password)
        {
            Phone = phone;
            Password = password;
        }

        public string Phone { get; set; }
        public string Password { get; set; }
    }
}