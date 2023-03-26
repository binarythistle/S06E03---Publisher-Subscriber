using System.ComponentModel.DataAnnotations;

namespace MessageBroker.Models
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int TopicId { get; set; }
    }
}