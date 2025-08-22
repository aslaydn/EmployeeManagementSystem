using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.DTOs
{
    public class EmployeeGrouping2
    {
        [Required]
        public string JobName { get; set; } = string.Empty;
        [Required, Range(1, 99999, ErrorMessage =" seçmeniz gerekiyor.")]
        public int BranchId { get; set; }
        [Required, Range(1, 99999, ErrorMessage = "İlçe seçmeniz gerekiyor.")]
        public int TownId { get; set; }
        [Required]
        public string? Other {  get; set; }
    }
}
