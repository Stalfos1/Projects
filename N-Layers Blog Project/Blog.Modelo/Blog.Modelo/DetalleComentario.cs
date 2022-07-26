using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Modelo
{
    public class DetalleComentario
    {
        //Claves foraneas
        public int? ComentarioId { get; set; }
        public int? EntradaId { get; set; }
        public int Id { get; set; }
        public Comentario? Comentario { get; set; }
        public Entrada? Entrada { get; set; }
    }
}
