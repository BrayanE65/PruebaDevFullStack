using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BackEnd.Models
{
    public class Categoria
    {
        [Key]
        public int ID   { get; set; }     
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public List<Listado> Listados { get; set; }
        
        
        
        
        
    }
}