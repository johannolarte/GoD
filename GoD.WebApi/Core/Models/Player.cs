using System.ComponentModel.DataAnnotations;

namespace GoD.WebApi.Core.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}