using System.ComponentModel.DataAnnotations;

namespace NouApi.Dtos
{
    public class MessageCreateDto
    {
        [Required]
        public string Body { get; set; }

        [Required]
        public string User { get; set; }
    }
}
