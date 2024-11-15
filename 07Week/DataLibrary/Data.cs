using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    // Data class provides static methods to generate lists of different data types
    public class Data
    {
        // Returns a list of integers (numbers)
        public static List<int> Numbers()
        {
            List<int> numbers = new List<int>()
            {
                -8, -18, -12, -6, 0, 5, 8, 14, 20, 18
            };

            return numbers;
        }

        // Returns a list of Singer objects with sample data
        public static List<Singer> Singers()
        {
            List<Singer> singers = new List<Singer>();

            singers.Add(new Singer("Ajda", "Pekkan", "Pop", 1968, 20));
            singers.Add(new Singer("Sezen", "Aksu", "Türk Halk Müziği \\ Pop", 1971, 10));
            singers.Add(new Singer("Funda", "Arar", "Pop", 1999, 3));
            singers.Add(new Singer("Sertap", "Erener", "Pop", 1994, 5));
            singers.Add(new Singer("Sıla", "Pop", 2009, 3));
            singers.Add(new Singer("Serdar", "Ortaç", "Pop", 1994, 10));
            singers.Add(new Singer("Tarkan", "Pop", 1992, 40));
            singers.Add(new Singer("Hande", "Yener", "Pop", 1999, 7));
            singers.Add(new Singer("Hadise", "Pop", 2005, 5));
            singers.Add(new Singer("Gülben", "Ergen", "Pop \\ Türk Halk Müziği", 1997, 10));
            singers.Add(new Singer("Neşet", "Ertaş", "Türk Halk Müziği \\ Türk Sanat Müziği", 1960, 2));

            return singers;
        }

        // Returns a list of TVSeries objects with sample data
        public static List<TVSeries> TvSeries()
        {
            List<TVSeries> tvSeries = new List<TVSeries>();

            tvSeries.Add(new TVSeries("Avrupa Yakası", 2004, "Komedi", 2004, "Yüksel Aksu", "Kanal D"));
            tvSeries.Add(new TVSeries("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"));
            tvSeries.Add(new TVSeries("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"));
            tvSeries.Add(new TVSeries("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"));
            tvSeries.Add(new TVSeries("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"));
            tvSeries.Add(new TVSeries("Arka Sokaklar", 2004, "Polisiye, Dram", 2004, "Orhan Oğuz", "Kanal D"));
            tvSeries.Add(new TVSeries("Aşk-ı Memnu", 2008, "Dram, Romantik", 2008, "Hilal Saral", "Kanal D"));
            tvSeries.Add(new TVSeries("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", 2011, "Mercan Çilingiroğlu", "Star TV"));
            tvSeries.Add(new TVSeries("Yaprak Dökümü", 2006, "Dram", 2006, "Serdar Akar", "Kanal D"));

            return tvSeries;
        }

        // Returns a list of Author objects with sample data
        public static List<Author> Authors()
        {
            List<Author> authors = new List<Author>()
            {
            new Author { AuthorId = 1, Name = "George Orwell" },
            new Author { AuthorId = 2, Name = "J.K. Rowling" },
            new Author { AuthorId = 3, Name = "Harper Lee" }
            };

            return authors;
        }

        // Returns a list of Book objects with sample data, associating books with their respective authors
        public static List<Book> Books()
        {
            List<Book> books = new List<Book>()
            {
            new Book { BookId = 1, Title = "1984", AuthorId = 1 },
            new Book { BookId = 2, Title = "Animal Farm", AuthorId = 1 },
            new Book { BookId = 3, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 2 },
            new Book { BookId = 4, Title = "To Kill a Mockingbird", AuthorId = 3 }
            };

            return books;
        }

        // Returns a list of Student objects with sample data
        public static List<Student> Students()
        {
            List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "John", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Sarah", ClassId = 1 },
            new Student { StudentId = 3, StudentName = "Tom", ClassId = 2 },
            new Student { StudentId = 4, StudentName = "Alice", ClassId = 3 },
            new Student { StudentId = 5, StudentName = "Mark", ClassId = 3 }
        };

            return students;
        }

        // Returns a list of Class objects with sample data
        public static List<Class> Classes() 
        {
            List<Class> classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Math" },
            new Class { ClassId = 2, ClassName = "Science" },
            new Class { ClassId = 3, ClassName = "History" }
        };

            return classes;
        }


    }
}
