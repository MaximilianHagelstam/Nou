using System.ComponentModel.DataAnnotations;

namespace NouApi.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Body { get; set; }
    }
}
