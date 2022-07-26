using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Modelo
{
    public class Comentario
    {
        public int Id { get; set; }
        public string? NombreComentario { get; set; }
        public string? ContenidoComentario { get; set; }
        //Claves foraneas
        public int? UsuarioId { get; set; }
        //Relacion con Usuario
        public Usuario? Usuario { get; set; }

        //Relacion detalleComentario
        public List <DetalleComentario>? DetalleComentario { get; set; }
    }
}
