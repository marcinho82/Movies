using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.filmes.Models
{
    [Table("Genres")]
    public class Genres
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int genreId { get; set; }
        [StringLength(255)]
        public string genreName { get; set; }
    }
}
