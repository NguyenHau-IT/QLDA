using DAL.Entities;
using System.Collections.Generic;
using System.Linq;

public class Category_DAL
{
    public List<Category> GetAllCategories()
    {
        using (var context = new Cafe_Context())
        {
            return context.Categories.ToList();
        }
    }
}
