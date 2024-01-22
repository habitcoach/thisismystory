using System.Xml.Schema;

namespace Build04MyApp.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public string Image { get; set; }

        public string Quote { get; set; }

        public Enum? Genre { get; set; }

        public Story()
        {
            Id = 0;
            Title = "default";
            Description = "default";
            Image = "default";
            ShortDescription = "default";
            Quote = "default";
            Genre = null;
        }
        public Story(int Id, string Title, string Description, string Image, string ShortDescription, string Quote, Enum Genre)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
            this.ShortDescription = ShortDescription;
            this.Quote = Quote;
            this.Genre = Genre;
        }
    }
}
