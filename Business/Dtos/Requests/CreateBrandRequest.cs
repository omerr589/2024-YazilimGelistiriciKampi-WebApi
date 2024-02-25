using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Dtos -> Data Transfer Objects
namespace Business.Dtos.Requests;

// Burası kullanıcı yeni bir Brand yaratırken, kullanıcıdan alacağımız bilgileri içerir
public class CreateBrandRequest
{
    public string Name { get; set; }
}
