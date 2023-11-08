using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL
{
    public class Contexto : DbContext
    {
        
            public Contexto(DbContextOptions<Contexto> opcion) : base(opcion)
            {

            }
            public DbSet<Usuarios> usuarios { get; set; }
            public DbSet<Accesos> accesos { get; set; }
            public DbSet<Libros> libros { get; set; }
            public DbSet<Generos> generos { get; set; }
            public DbSet<Colecciones> colecciones { get; set; }
            public DbSet<Editoriales> editoriales { get; set; }
            public DbSet<Prestamos> prestamos { get; set; }
            public DbSet<Estados_Prestamos> estados_Prestamos { get; set; }
            public DbSet<Rel_Autores_Libros> rel_Autores_Libros { get; set; }
            public DbSet<Autores> autores { get; set; }
            public DbSet<Rel_Libros_Prestamos> rel_Libros_Prestamos { get; set; }
    }
}