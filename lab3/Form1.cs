namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string FileFormat { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Ebook in {FileFormat} format)";
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] books =
                        {
                new Book { Title = "C# In a Nutshell", Author = "John Doe" },
                new Magazine { Title = "Tech Weekly", Author = "Joe Mama", IssueNumber = 77 },
                new Ebook { Title = "C# Residuals", Author = "Chris Brown", FileFormat = "PDF" },
                new Textbook { Title = "We Don't Trust You", Author = "Dr. Future", Subject = "MetroBoomin" },
                new AudioBook { Title = "The Perfect Luv Tape", Author = "Lil Uzi Vert", Narrator = "Playboi Carti", Duration = 3.5 }
          


        };
            DisplayBooksInfo(books);
        }

        public void DisplayBooksInfo(Book[] books)
        {
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }

        public class Textbook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Textbook on {Subject}) by {Author}";
            }
        }

        public class AudioBook : Book
        {
            public string Narrator { get; set; }
            public double Duration { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Audiobook, Narrated by {Narrator}, {Duration} hours)";
            }
        }

    }
}
