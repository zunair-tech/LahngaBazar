using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LehngaBazar.Entities
{
    public class Category : BaseEntity
    {
        public Category category { get; set; }
        public decimal Price { get; set; }
    }
}
