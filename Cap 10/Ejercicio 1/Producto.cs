class Producto
{
    
    public int ProductoID { get; set; }

    public string? Descripcion { get; set; }

    public int Existencia { get; set; }

    public double Costo { get; set; }

    public double Precio { get; set; }


    public Producto(int id, string Descripcion, int Existencia, double Costo, double Precio)
    {

        this.ProductoID = id;
        this.Descripcion = Descripcion;
        this.Existencia = Existencia;
        this.Costo = Costo;
        this.Precio = Precio;
        
    }



    

    
}