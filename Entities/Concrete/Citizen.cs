using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Citizen : IApplicant
{
    //public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long IdentityNumber { get; set; }
    public int DateOfBirthYear { get; set; }
}
