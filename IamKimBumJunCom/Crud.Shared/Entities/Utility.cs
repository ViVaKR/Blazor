using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud.Shared.Entities;

public class Utility
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(100)]
    public required string Title { get; set; }

    [StringLength(20)]
    public required string Category { get; set; }

    [MaxLength]
    public required string Description { get; set; }
}
