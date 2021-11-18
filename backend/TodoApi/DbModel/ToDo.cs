using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.DbModel
{
    /// <summary>
    /// ToDo DbModel
    /// </summary>
    public class ToDo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; init; }

        [Required(ErrorMessage = "Title is required.")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Title { get; set; }

        [MaxLength(150)]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
    }
}