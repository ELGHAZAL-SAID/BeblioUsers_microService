using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beblio.Domain.Entities;

public class Users
{
    public int ID { get; set; }
    public string Email { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string School { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Neighborhood { get; set; }
    public bool JobIntech { get; set; }

    public ICollection<UsersRoles> UserRoles { get; set; }
}
