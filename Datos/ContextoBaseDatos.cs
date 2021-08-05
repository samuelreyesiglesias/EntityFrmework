using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Modelo;


namespace Datos
{
    public class ContextoBaseDatos:DbContext
    {
        public ContextoBaseDatos(): base("DefaultConnection")
        {
        }
        public DbSet<Blog> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
