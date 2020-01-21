using System.ComponentModel.DataAnnotations;

namespace EFBasics.Data
{
    public class SettingsDataModel
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Value { get; set; }
    }
}
