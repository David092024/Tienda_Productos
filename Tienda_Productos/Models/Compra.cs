using System;
using System.Collections.Generic;

namespace Tienda_Productos.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaCompra { get; set; }

    public decimal? Total { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
