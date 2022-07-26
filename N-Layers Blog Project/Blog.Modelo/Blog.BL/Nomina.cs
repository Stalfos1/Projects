using Blog.DAL;
using Microsoft.EntityFrameworkCore;


namespace Blog.BL
{
    public class Nomina
    {
		private readonly Blog.DAL.Context _context;

			public Nomina(Context context)
			{
				_context = context;
			}




			public Modelo.ListaUsuario[] ListaUsuarios(int numero)
			{
				var data = from entrada in _context.Entradas
						   from usuarios in _context.Usuarios
						   where entrada.UsuarioId == usuarios.Id && (usuarios.EdadUsuario >= numero)
						   select new Modelo.ListaUsuario
						   {
							   NombreUsuario = usuarios.NombreUsuario,
							   Edad = usuarios.EdadUsuario,
							   NombreEntrada = entrada.NombreEntrada,
							   ContenidoEntrada = entrada.ContenidoEntrada,
						   };
				return data.ToArray();

			}
		
	}
}