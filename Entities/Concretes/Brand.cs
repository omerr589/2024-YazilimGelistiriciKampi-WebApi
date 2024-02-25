using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Brand : BaseEntity<int> // int verildiği için Id değişkeninin tipi int oldu
{
    public string Name { get; set; }
}
