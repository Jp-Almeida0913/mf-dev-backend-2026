using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2026.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Data é obrigatório.")]
        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo Km é obrigatório.")]
        [Display(Name = "Quilometragem")]
        public int km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel TipoCombustivel { get; set; }

        [Required(ErrorMessage = "O campo Veículo é obrigatório.")]
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Diesel
    }
}
