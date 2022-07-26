namespace Blog.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? NombreUsuario { get; set; }
        public int? EdadUsuario { get; set; }
        public string? SexoUsuario { get; set; }

        //relacion con blog
        public List<Entrada>? Entrada { get; set; }
        //relacion con comentario
        public List<Comentario>? Comentario { get; set; }
    }
}