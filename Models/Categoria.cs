using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Categorias")]
    //Tabela "Categorias" do BD que vai definir toda vez
    //que for usar as informações presentes na classe
    //"Categoria" abaixo. 
    public class Categoria
    {
        [Key] 
        //Key: Chave Primaria, Id
        public int Id { get; set; }

        [Display(Name = "Nome da categoria")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Descrição da categoria")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
