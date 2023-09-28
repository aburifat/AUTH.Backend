using Microsoft.AspNetCore.Identity;

namespace AUTH.Backend.Domains.Models;

public class Role : IdentityRole<long>
{
    public Role() : base()
    {
        ConcurrencyStamp = Guid.NewGuid().ToString();
    }

    public Role(string name) : this()
    {
        Name = name;
        NormalizedName = name.ToUpper();
    }

    public Role(long id, string name) : this(name)
    {
        Id = id;
    }

    public Role(long id, string name, string stamp) : this(id, name)
    {
        ConcurrencyStamp = stamp;
    }


}