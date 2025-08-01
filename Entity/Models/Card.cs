using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Card : GenericModel
    {
        //NormalDamage
        public decimal Damage { get; set; }
        //FireDamage
        public decimal FireDamage { get; set; }
        //ElectricDamage
        public decimal ElectricDamage { get; set; }
        //CrtiticalDamage
        public decimal CrtiticalDamage { get; set; }
        //PoisionDamage
        public decimal PoisionDamage { get; set; }
        //MagicDamage
        public decimal MagicDamage { get; set; }
        public string Image { get; set; }
    }
}
