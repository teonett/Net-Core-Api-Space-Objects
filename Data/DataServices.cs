using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreSpaceApi.Data.Interfaces;

namespace NetCoreSpaceApi.Data
{
    public class DataServices : IDataServices
    {
        private readonly ApplicationContext context;

        public DataServices(ApplicationContext _context)
        {
            this.context = _context;
        }

        public async Task StartDB()
        {
            await context.Database.MigrateAsync();
        }
    }
}
