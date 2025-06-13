using Project_PRN222.Models;

namespace Project_PRN222.ViewModels.Management
{
    public class UserIndexViewModel
    {
        public List<UserViewModel> Users { get; set; }
        public string SearchQuery { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public List<string> Roles { get; set; } = default!;
    }
}
