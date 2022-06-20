using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly ApplicationDbContext _context;

        public SellerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public async Task Insert(Seller obj)
        {
            await _context.AddAsync(obj);
            await _context.SaveChangesAsync();
        }
    }
}
