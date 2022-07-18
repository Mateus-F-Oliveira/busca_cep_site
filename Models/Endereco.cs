using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAppBuscaCepV2.Models
{
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        [Required]
        [StringLength(10)]
        public string? Cep { get; set; }
        [Required]
        [StringLength(100)]
        public string? Rua { get; set; }
        [Required]
        [StringLength(100)]
        public string? Bairro { get; set; }
        [Required]
        [StringLength(100)]
        public string? Cidade { get; set; }
        [Required]
        [StringLength(2)]
        public string? Estado { get; set; }
        [Required]
        public int UsuarioId { get; set; }
        [JsonIgnore]
        public virtual Usuario? Usuario { get; set; } 
    }
}
