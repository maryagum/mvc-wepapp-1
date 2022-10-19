using System.ComponentModel.DataAnnotations;
namespace Personagens.Models;
public class Personagem{
    // [Key] aponta que a propriedade indicada será a chave primária no banco de dados gerado a partir deste model
    [Key]
    public int Id{get;set;}

    // [Required] indica que a propriedade não pode receber um valor nulo (equivalente ao NotNull no banco de dados)
    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
    public string Nome{get;set;}

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
    public double? Altura{get;set;}
    
    
    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
    // [Display] indica como o nome da propriedade será exibido nas views
    [Display(Name = "Data de estreia da série/livro")]
    public DateTime? DataEstreia{get;set;}

    
    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
    [Display(Name = "O personagem está vivo ou morto?")]
    public bool? IsAlive{get;set;}


    
}