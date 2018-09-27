using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
   public class Types
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Total { get; set; }

        public int CategoryId { get; set; }

        public virtual Categories Category { get; set; }

        public int DriversCategory { get; set; }

        public int PassagersCategory { get; set; }
    }
}
