using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GalloTube.Models;

[Table("Video")]
public class Video
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "O Nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 100 caracteres")]
    public string Title { get; set; }

    [Display(Name = "Descricao")]
    [Required(ErrorMessage = "A Descricao é obrigatória")]
    [StringLength(8000, ErrorMessage = "A Descricao deve possuir no máximo 8000 caracteres")]
    public string Description { get; set; }

    [Column(TypeName = "UploadDate")]
    [Display(Name = "Data do video")]
    [Required(ErrorMessage = "Data do video é obrigatório")]
    public Int16 VideoDate { get; set; }

    [Display(Name = "Duração (em minutos)")]
    [Required(ErrorMessage = "A Duração é obrigatória")]
    public Int16 Duration { get; set; }

    [StringLength(200)]
    [Display(Name = "Thumbnail")]
    public string Image { get; set; }

[Display(Name = "VideoFile")]
    [Required(ErrorMessage = "O Título é obrigatório")]
    [StringLength(200, ErrorMessage = "O VideoFile deve possuir no máximo 200 caracteres")]
    public string VideoFile { get; set; }
}