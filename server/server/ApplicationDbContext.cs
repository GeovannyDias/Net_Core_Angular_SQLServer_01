using Microsoft.EntityFrameworkCore;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server
{
    // La clase principal de EF es DbContext y permite consultar, crear, editar y eliminar registros de una base de datos.
    // La base de datos de esta apirest se creó utilizando la funcionalidad "Migrations" de Entity Framework.
    // DbContext es la clase primaria responsable de interactuar con la base de datos.
    public class ApplicationDbContext: DbContext
    {
        // DbContext → Crea un instacia de la BD y podemos almacenar datos, querys, crear DB con el modelo, etc.

        // Controller
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        // ENTITIES
        // Configurar los DbSet() → Mapear el modelo → DbSet<CreditCard> Table_Name { get; set; }
        // DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }

    }
}
