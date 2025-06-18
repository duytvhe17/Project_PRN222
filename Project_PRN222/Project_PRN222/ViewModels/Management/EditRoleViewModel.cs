using Project_PRN222.Models;
using System.ComponentModel.DataAnnotations;

namespace Project_PRN222.ViewModels.Management
{
    public class EditRoleViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public List<string> SelectedPermission { get; set; } = default!;
        public List<string> Permissions { get; set; } = default!;
    }
}
