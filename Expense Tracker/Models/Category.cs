using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models {
    public class Category {

        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Column(TypeName = "NVARCHAR(5)")]
        public string Icon { get; set; } = String.Empty;
        [Column(TypeName = "NVARCHAR(10)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon { get { return this.Icon + " " + this.Title; } }
    }
}
