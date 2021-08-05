using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Modelo
{

    public class Post
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
