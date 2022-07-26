using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Modelo
{
    public class Tag
    {
        public int Id { get; set; }
        public string? TipoTag { get; set; }
        public string? NombreTag { get; set; }
        //Relacion detalleTag
        public List <DetalleTag>? DetalleTag { get; set; }
    }
}
