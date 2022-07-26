using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Modelo
{
    public class DetalleTag
    {
        //Claves foraneas
        public int? TagId { get; set; }
        public int? EntradaId { get; set; }


        public int Id { get; set; }
        public Tag? Tag { get; set; }
        public Entrada? Entrada { get; set; }
    }
}
