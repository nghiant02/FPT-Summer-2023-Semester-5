using Repository.Models;

public class ProductsServices
{
    private readonly ElectricStoreDBContext _context;

    public ProductsServices(ElectricStoreDBContext context)
    {
        _context = context;
    }

    public List<Products> GetProducts()
    {
        try
        {
            var listProduct = _context.Products
                .Select(x => new Products
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    Price = x.Price,
                    DateCreate = x.DateCreate,
                    CategoryId = x.CategoryId,
                    ProductCode = x.ProductCode
                })
                .ToList();

            return listProduct;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Products GetProductByCode(string productCode)
    {
        try
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductCode == productCode);

            return product;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void AddProduct(Products product)
    {
        try
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void UpdateProduct(Products product)
    {
        try
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteProduct(Products product)
    {
        try
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Category> GetCategories()
    {
        try
        {
            var categories = _context.Category.ToList();
            return categories;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
