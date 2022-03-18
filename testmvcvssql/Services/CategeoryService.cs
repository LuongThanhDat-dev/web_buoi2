using testmvcvssql.Database;
using testmvcvssql.Models;

namespace testmvcvssql.Services;
public class CategoryService
{
    public readonly ApplicationDbContext _db;
    public CategoryService (ApplicationDbContext db)
    {
        _db = db;
    }

    public Category Insert(Category cat)
    {   
        var entry = _db.Category.Add(cat);
        _db.Category.Add(cat);
        return entry.Entity;
    }

    internal List<Category> GetAll()
    {
        return _db.Category.ToList();
    }

    public bool Update(int id, Category cat)
    {   
        var entry = _db.Category.Find(id);
        if(entry!=null)
        {
            entry.Name = cat.Name;
            _db.Category.Add(cat);
            return true;
        }
        return false;
    }
    public bool Delete(int id)
    {   
        var entry = _db.Category.Find(id);
        if( entry != null)
        {
            _db.Category.Remove(entry);
            return true;
        }
        return false;
    }

    public List<Category> GetALL()
    {
        return _db.Category.ToList();
    }
}