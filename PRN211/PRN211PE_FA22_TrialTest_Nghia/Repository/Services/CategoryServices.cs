using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class CategoryServices
    {
        private readonly ElectricStoreDBContext _context;

        public CategoryServices(ElectricStoreDBContext context)
        {
            _context = context;
        }
        public List<Category> GetCategories()
        {
            try
            {
                var listCategory = _context.Category
                    .Select(x => new Category
                    {
                        Id = x.Id,
                        CategoryName = x.CategoryName,
                        CategoryCode = x.CategoryCode,
                    })
                    .ToList();

                return listCategory;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
