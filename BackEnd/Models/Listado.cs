using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BackEnd.Models
{
    public class Listado
    {
        [Key]
        public int ID   { get; set; }
        
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
        

        public int ContenidoID { get; set; }
        public Contenido Contenido { get; set; }
        
        
    }
}