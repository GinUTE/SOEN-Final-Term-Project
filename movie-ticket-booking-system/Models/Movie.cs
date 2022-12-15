namespace movie_ticket_booking_system.Models
{
    public class Movie
    {
        public string MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string ReleaseDate { get; set; }
        public string Runtime { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public byte[] Thumbnail { get; set; }
    }
}