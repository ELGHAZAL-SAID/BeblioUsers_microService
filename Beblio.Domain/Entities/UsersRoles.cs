using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beblio.Domain.Entities;

public class UsersRoles
{
    public int UserID { get; set; }
    public int RoleID { get; set; }

    public Users User { get; set; }
    public Roles Role { get; set; }
}
