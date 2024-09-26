using System;
using System.Collections.Generic;

namespace Tienda_Productos.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? NombreProducto { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
