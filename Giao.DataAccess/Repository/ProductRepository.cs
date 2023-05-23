using GiaoBook.DataAccess.Data;
using GiaoBook.DataAccess.Repository.IRepository;
using GiaoBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GiaoBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    
        public void Update(Category obj)
        {
            _db.Products.Update(obj);
        }
    }
}
