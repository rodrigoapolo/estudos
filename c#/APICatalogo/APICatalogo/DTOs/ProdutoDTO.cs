using APICatalogo.Models;
using APICatalogo.Validations;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs
{
    public class ProdutoDTO
    {
        public int ProdutoId { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "O nome deve ter no maximo {1} e no minimo {2} caracteres",
            MinimumLength = 5)]
        [PrimeiraLetraMaiuscula]
        public string? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string? Descricao { get; set; }
        [Required]
        public decimal Preco { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }
        public int CategoriaId { get; set; }
    }
}
