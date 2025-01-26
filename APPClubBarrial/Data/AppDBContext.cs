using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using APPClubBarrial.Models;

namespace APPClubBarrial.Data
{
    public class AppDBContext : IdentityDbContext<Usuario>
    {
    }
}
