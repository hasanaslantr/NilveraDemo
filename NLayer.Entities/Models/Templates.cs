using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Entities.Models
{ 
    public class Templates
    {
        public List<Templates> Content;

        public int ID { get; set; }
        public string UUID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreationDate { get; set; }
    }

}
