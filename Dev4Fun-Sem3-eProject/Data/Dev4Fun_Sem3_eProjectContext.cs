#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dev4Fun_Sem3_eProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Dev4Fun_Sem3_eProject.Data
{
    public class Dev4Fun_Sem3_eProjectContext : IdentityDbContext<ApplicationUser>
    {
        public Dev4Fun_Sem3_eProjectContext (DbContextOptions<Dev4Fun_Sem3_eProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Dev4Fun_Sem3_eProject.Models.Accounts> Accounts { get; set; }

        public DbSet<Dev4Fun_Sem3_eProject.Models.Applicants> Applicants { get; set; }

        public DbSet<Dev4Fun_Sem3_eProject.Models.ApplicantVacancy> ApplicantVacancy { get; set; }

        public DbSet<Dev4Fun_Sem3_eProject.Models.Departments> Departments { get; set; }

        public DbSet<Dev4Fun_Sem3_eProject.Models.Vacancies> Vacancies { get; set; }
    }
}
