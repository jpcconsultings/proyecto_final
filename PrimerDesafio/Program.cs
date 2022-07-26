public class Usuario{
    private int Id;
    private string Nombre;
    private string Apellido;
    private string NombreUsuario;
    private string Contrasenia;
    private string Mail;
}

public class Producto
{
    private int Id;
    private string Descripcion;
    private long Costo;
    private long PrecioVenta;
    private long Stock;
    private int IdUsuario;

}

public class ProductoVendido
{
    private int Id;
    private int IdProducto;
    private int Stock;
    private int IdVenta;

}

public class Venta
{
    private int Id;
    private string Comentarios;

}