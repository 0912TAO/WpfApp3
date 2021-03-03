using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsRemove { get; set; }
    }
}
