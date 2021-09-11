using System.ComponentModel.DataAnnotations;

namespace NouApi.Dtos
{
    public class MessageReadDto
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public string User { get; set; }
    }
}
