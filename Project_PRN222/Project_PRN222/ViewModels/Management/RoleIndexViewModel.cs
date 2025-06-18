using Microsoft.AspNetCore.Identity;

namespace Project_PRN222.ViewModels.Management
{
    public class RoleIndexViewModel
    {
        public List<RoleViewModel> Roles { get; set; }
        public string SearchQuery { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
