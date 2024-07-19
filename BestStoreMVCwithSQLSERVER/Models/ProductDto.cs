using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BestStoreMVCwithSQLSERVER.Models
{
    public class ProductDto
    {
        public string Name { get; set; } = string.Empty;
        [Required, MaxLength(100)]
        public string Brand { get; set; } = string.Empty;
        [Required, MaxLength(100)]
        public string Category { get; set; } = string.Empty;
        [Required]
        public string Price { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public IFormFile? ImageFile { get; set; }
    }
}
