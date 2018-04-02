using Crud_Entity.Models;
using System.Data.Entity;

namespace Crud_Entity.Context
{
    public class ModelContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ModelContext() : base("name=ModelContext")
        {
        }

        public DbSet<Produto> Produtoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
