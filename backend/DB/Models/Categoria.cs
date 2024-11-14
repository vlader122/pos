using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DB.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        [JsonIgnore]
        public virtual ICollection<Producto> ?Productos { get; set; }
    }
}
