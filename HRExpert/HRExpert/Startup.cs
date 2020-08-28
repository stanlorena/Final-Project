using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppData;
using AppServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HRExpert
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSingleton(Configuration);
            services.AddScoped<ICrud, PersonService>();
            services.AddScoped<IPersonIdentity, PersonIdentityService>();
            services.AddScoped<IPersonAddress, PersonAddressService>();
            services.AddScoped<IContract, ContractService>();
            services.AddScoped<IContractFiscality, ContractFiscalityService>();
            services.AddScoped<IContractInsurance, ContractInsuranceService>();
            services.AddScoped<IContractOrgAssignment, ContractOrganizatoricalAssignmentService>();
            services.AddScoped<IContractPeriod, ContractPeriodService>();
            services.AddScoped<IContractSalary, ContractSalaryService>();
            services.AddScoped<IContractWorkProgram, ContractWorkProgramService>();
            services.AddScoped<IStatistics, StatisticsService>();
            services.AddDbContext<HrContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HrConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
