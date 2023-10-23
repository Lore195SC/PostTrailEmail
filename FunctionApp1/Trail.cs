
namespace FunctionApp
{
    public class Trail
    {
        public Trail(int id, string mapsLink, string tripAdvisorLink, double latitude, double longitude, string image, string city, string link)
        {
            Id = id;
            MapsLink = mapsLink;
            TripAdvisorLink = tripAdvisorLink;
            Latitude = latitude;
            Longitude = longitude;
            Image = image;
            City = city;
            LinkGame = link;
        }

        public int Id { get; set; }
        public string MapsLink { get; set; }
        public string TripAdvisorLink { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public string LinkGame { get; set; }
    }
}
