using AccountantPro.Domain.Entities.Bases;
using AccountantPro.Domain.Entities.Sizes;

namespace AccountantPro.Domain.Entities.Products;

public class Product:Auditable
{
    public string Name { get; set; }
    public string Mark { get; set; }
    public Size size { get; set; }
}
