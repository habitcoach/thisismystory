using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Build04MyApp.Models
{
    public class ClientStory
    {
        public DateTime id { get; set; }
        [Required(ErrorMessage ="Please enter your name")]
       
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter Title of the story")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter your story")]
        [MaxLength(700, ErrorMessage = "Cannot excees 700 words")]
        public string StoryDes { get; set; }
        [Required(ErrorMessage ="Please enter your email address")]
        [EmailAddress(ErrorMessage ="Please enter valid email address")]
        public string  Email { get; set; }
       
        public string Phone { get; set; }
        public string  Images { get; set; }

        public ClientStory()
        {
            this.id = DateTime.Now;
            this.Name = "defautl";
            this.Title = "defautl";
            this.StoryDes = "defautl";
            this.Email = "defualt";
            this.Images = "default";
            this.Phone = "default";
        }
    }
}
