using DAL.Entities;
using System.Collections.Generic;

public class Category_BUS
{
    private readonly Category_DAL category_DAL = new Category_DAL();

    public List<Category> GetAllCategories()
    {
        return category_DAL.GetAllCategories();
    }
}
