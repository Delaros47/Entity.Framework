using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Framework
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var addedEntity = context.Entry(product);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var updatedEntity = context.Entry(product);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var deletedEntity = context.Entry(product);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
