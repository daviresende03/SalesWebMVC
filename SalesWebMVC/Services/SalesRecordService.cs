using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SalesRecordService
    {
        private readonly ApplicationDbContext _context;

        public SalesRecordService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value.Date);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value.Date);
            }

            return await result
                    .Include(x => x.Seller) //JOIN
                    .Include(x => x.Seller.Department) //JOIN
                    .OrderByDescending(x => x.Date)
                    .ToListAsync();
        }

        public async Task<List<IGrouping<Department,SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value.Date);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value.Date);
            }

            return await result
                    .Include(x => x.Seller) //JOIN
                    .Include(x => x.Seller.Department) //JOIN
                    .OrderByDescending(x => x.Date)
                    .GroupBy(x => x.Seller.Department)
                    .ToListAsync();
        }
    }
}
