public class Palabrabd
{
public static new string[] PalabraAAdivinar{get; private set;}=IniciarPalabra();

public static string[] IniciarPalabra()
{
  string[] palabra = new string[100]
    {"GATO", "PERRO", "CASA", "ARBOL", "LIBRO", "ESCUELA", "SILLA", "MESA", "VENTANA", "PUERTA",
    "ZAPATO", "LAPIZ", "RELOJ", "CAMISA", "PANTALON", "CHAQUETA", "COCINA", "BAÑO", "TELEFONO", "COMPUTADORA",
    "TECLADO", "RATON", "PANTALLA", "CABLE", "AURICULAR", "CIUDAD", "PAIS", "MAPA", "PLANETA", "LUNA",
    "SOL", "ESTRELLA", "CIELO", "NUBE", "LLUVIA", "VIENTO", "FUEGO", "AGUA", "TIERRA", "ARENA",
    "MONTANA", "RIO", "MAR", "LAGO", "ISLA", "BOSQUE", "SELVA", "FLOR", "ARROZ", "CARNE",
    "PESCADO", "PAN", "LECHE", "HUEVO", "FRUTA", "MANZANA", "PERA", "BANANA", "NARANJA", "UVA",
    "ZANAHORIA", "TOMATE", "LECHUGA", "PAPA", "CEBOLLA", "AJI", "AZUCAR", "SAL", "ACEITE", "VINAGRE",
    "COCHE", "BICICLETA", "AVION", "BARCO", "TREN", "CAMION", "MOTO", "TRAFICO", "CALLE", "CARRETERA",
    "SEMÁFORO", "PUENTE", "TUNEL", "ESPEJO", "LUNA", "CRISTAL", "BOTE", "VELA", "MOTOR", "RUEDA",
    "BOLIGRAFO", "CUADERNO", "MOCHILA", "ESPEJO", "JUGUETE", "PELOTA", "MUÑECA", "ROMPECABEZAS", "PINTURA", "INSTRUMENTO"};
    int num;
    Random r=new Random();
    num=r.Next(0,palabra.Count()-1);
    string palabras=palabra[num];
    return palabra;
}

public static List<int> VerificarLetra(char letra)
{
    List<int>PosicionesCorrectas=new List<int>();
    for(int i=0;i<=PalabraAAdivinar.Length;i++)
    {
        if(letra.ToString()==PalabraAAdivinar[i])
        {
            PosicionesCorrectas.Add(i);
        }
    }
    return PosicionesCorrectas;
}
public static bool VerificarPalabra(string palabra)
{
    bool verificacionPalabra=false;
    foreach(string palabras in PalabraAAdivinar)
    {
        if(palabra==palabras)
    {
        verificacionPalabra=true;
    }
    }
    return verificacionPalabra;
}


}