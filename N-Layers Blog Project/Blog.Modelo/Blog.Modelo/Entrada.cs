namespace Blog.Modelo
{
    public class Entrada
    {
        public int Id { get; set; }
        public string? NombreEntrada { get; set; }
        public string? ContenidoEntrada { get; set; }
        //Claves foraneas
        public int? UsuarioId { get; set; }
        //Relacion con Usuario 
        public Usuario? Usuario { get; set; }

        //Relacion con DetalleTag
        public List<DetalleTag>? DetalleTag { get; set; }

        //Relacion con DetalleComentario
        public List<DetalleComentario>? DetalleComentario { get; set; }
    }
}