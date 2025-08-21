
Console.WriteLine("Hello, World");
    Carros carro = new();
    carro.id =1;
    carro.placa= "ABC 123";
    carro.CaballosFuerza = 600;
    
    carro.precio = 1000;
    carro.Encendido = true;
    carro.FechaFabricacion = DateTime.Now;
    carro.Marca = new Marcas(){id = 1, Marca = "bmw"};
    /*marca.modelo = new modelos(){id =1, modelo "M3"}*/;

public class Carros
{   
    public int id;
    public string? placa;
    public int CaballosFuerza;
    public float precio;
    public bool Encendido;
    public DateTime FechaFabricacion;
    public Marcas? Marca;



}

public class Marcas{
    public int id;
    public string? Marca;
    
}

/*public class modelos : marcas{
    public int id;
    public string? modelo;
}*/