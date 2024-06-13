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
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
