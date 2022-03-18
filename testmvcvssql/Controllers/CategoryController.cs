
using testmvcvssql.Services;
using Microsoft.AspNetCore.Mvc;
using testmvcvssql.Models;

namespace testmvcvssql.Controllers;

public class CategoryController : Controller
{
    public readonly CategoryService  _catService;
    public CategoryController(CategoryService catService)
    {
        _catService = catService;
    }
    public IActionResult Index()
    {
        List<Category> _items= _catService.GetAll();
        return View(_items);
    }


}