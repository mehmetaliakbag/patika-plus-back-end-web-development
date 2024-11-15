using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    // Represents a TV series with relevant details like name, genre, director, and platform
    public class TVSeries
    {
        public string Name { get; set; }           // Name of the TV series
        public int ProductYear { get; set; }       // Year the series was produced
        public string Genre { get; set; }          // Genre of the TV series
        public int ReleaseYear { get; set; }       // Year the series was released
        public string Director { get; set; }       // Director of the TV series
        public string OriginalPlatform { get; set; } // Original platform where the series aired

        // Constructor to initialize a TV series with all properties
        public TVSeries(string name, int productYear, string genre, int releaseYear, string director, string originalPlatform)
        {
            Name = name;
            ProductYear = productYear;
            Genre = genre;
            ReleaseYear = releaseYear;
            Director = director;
            OriginalPlatform = originalPlatform;
        }

    }
}
