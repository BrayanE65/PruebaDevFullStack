using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BackEnd.Models
{
    public class Contenido
    {
        [Key]
        public int ID   { get; set; }
        public string Nombre { get; set; }
        public int PesoEnMB { get; set; }
        public DateTime FechaDeSubida { get; set; }
         
        public int UsuarioId { get; set; }
        public Usuario Usuarios { get; set; }
         
        public List<Listado> Listados { get; set; }
        
        
    }
}