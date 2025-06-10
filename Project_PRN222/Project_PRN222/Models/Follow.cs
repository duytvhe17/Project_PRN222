using System.ComponentModel.DataAnnotations;

namespace Project_PRN222.Models
{
    public class Follow
    {
        public Guid ComicId { get; set; }
        public Guid UserId { get; set; }
        public Comic Comic { get; set; }
        public User User { get; set; }
    }
}
