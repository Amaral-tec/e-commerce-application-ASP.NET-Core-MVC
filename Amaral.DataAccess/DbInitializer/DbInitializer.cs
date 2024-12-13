using Amaral.DataAccess.Data;
using Amaral.Models;
using Amaral.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Amaral.DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public DbInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception) { }

            if (!_roleManager.RoleExistsAsync(StaticData.ROLE_CUSTOMER).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(StaticData.ROLE_CUSTOMER)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(StaticData.ROLE_COMPANY)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(StaticData.ROLE_ADMIN)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(StaticData.ROLE_EMPLOYEE)).GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "suporte@amaraltech.app",
                    Email = "suporte@amaraltech.app",
                    PhoneNumber = "5584996321321",
                    Name = "Leandro Amaral",
                    StreetAddress = "Engenheiro João Hélio Alves Rocha, 820, Planalto",
                    City = "Natal",
                    State = "RN",
                    PostalCode = "59073070"
                }, "Support1082@").GetAwaiter().GetResult();

                ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "suporte@amaraltech.app");
                _userManager.AddToRoleAsync(user, StaticData.ROLE_ADMIN).GetAwaiter().GetResult();

            }

            return;
        }
    }
}
