using Microsoft.AspNetCore.Identity;

namespace Project_PRN222.ViewModels.Management
{
    public class RoleViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Permission { get; set; }
    }
}
