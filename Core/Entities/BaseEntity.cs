using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class BaseEntity<TId> // Burada verilen tip Id'nin Tipi Olur
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; } // ? null olabilir demek
    public DateTime? DeletedDate { get; set; } // ? null olabilir demek
}
