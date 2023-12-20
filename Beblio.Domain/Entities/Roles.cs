using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beblio.Domain.Entities;

public class Roles
{
    public int ID { get; set; }
    public string RoleName { get; set; }

    public ICollection<UsersRoles> UserRoles { get; set; }
}
