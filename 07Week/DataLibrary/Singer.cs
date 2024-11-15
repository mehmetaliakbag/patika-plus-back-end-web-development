namespace DataLibrary
{
    public class Singer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int AlbumSalesMillion { get; set; }

        // Constructor to initialize all properties
        public Singer(string firstName, string lastName, string genre, int releaseYear, int albumSalesMillion)
        {
            FirstName = firstName;
            LastName = lastName;
            Genre = genre;
            ReleaseYear = releaseYear;
            AlbumSalesMillion = albumSalesMillion;
        }

        // Constructor for artists without a last name (single-name artists)
        public Singer(string firstName, string genre, int releaseYear, int albumSalesMillion)
        {
            FirstName = firstName;
            Genre = genre;
            ReleaseYear = releaseYear;
            AlbumSalesMillion = albumSalesMillion;
        }

    }
}