using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class GenericModel : BaseModel
    {
        public string? Name { get; set; } 
        public string? Code { get; set; }
    }
}
