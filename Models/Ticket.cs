namespace ConsoleTheater.Models
{
    public class Ticket
    {
        public string Time { get; set; }
        public Movie Movie { get; set; }
        public decimal Price { get; set; }


        public Ticket(string time, Movie movie, decimal price)
        {
            Time = time;
            Movie = movie;
            Price = price;
        }

    }
}