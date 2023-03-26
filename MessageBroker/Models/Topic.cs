using System.ComponentModel.DataAnnotations;

namespace MessageBroker.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}