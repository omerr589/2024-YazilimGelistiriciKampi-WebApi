using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Dtos -> Data Transfer Objects
namespace Business.Dtos.Responses;

// Burası ise kullanıcıya göstereceğimiz bilgileri gösterir
public class CreatedBrandResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}
