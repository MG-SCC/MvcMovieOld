using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SpringFurniture.Models;

public class FurnitureTypeViewModel
{
    public List<Furniture>? Furniture { get; set; }
    public SelectList? Type { get; set; }
    public string? FurnitureType { get; set; }
    public string? SearchString { get; set; }
}