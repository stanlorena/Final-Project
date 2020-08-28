using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AppData
{
    public class HrContext : DbContext
    {
        public HrContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonIdentity> PersonIdentities { get; set; }
        public DbSet<PersonAddress> PersonAddresses { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractFiscality> ContractFiscalities { get; set; }
        public DbSet<ContractInsurance> ContractInsurances { get; set; }
        public DbSet<ContractOrganizatoricalAssignment> ContractOrganizatoricalAssignments { get; set; }
        public DbSet<ContractPeriod> ContractPeriods { get; set; }
        public DbSet<ContractSalary> ContractSalaries { get; set; }
        public DbSet<ContractWorkProgram> ContractWorkPrograms { get; set; }

    }
}
