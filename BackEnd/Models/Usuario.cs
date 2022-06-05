using Microsoft.AspNetCore.Identity;

namespace BackEnd.Models
{
    public class Usuario
     {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        
        public List<Contenido> Contenidos { get; set; }
       
    }
}