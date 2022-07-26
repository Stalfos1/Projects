using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog.DAL
{
    public class Context : DbContext
    {
        private string _connectString;

        public Context()
        {
            _connectString = "Data Source=D:\\blogCorregido.db;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectString);
        }

        public DbSet<Blog.Modelo.Entrada>? Entradas { get; set; }
        public DbSet<Blog.Modelo.Comentario>? Comentarios { get; set; }
        public DbSet<Blog.Modelo.Usuario>? Usuarios { get; set; }
        public DbSet<Blog.Modelo.Tag>? Tags { get; set; }
        public DbSet<Blog.Modelo.DetalleComentario>? DetalleComentarios { get; set; }
        public DbSet<Blog.Modelo.DetalleTag>? DetalleTags { get; set; }
    }
}