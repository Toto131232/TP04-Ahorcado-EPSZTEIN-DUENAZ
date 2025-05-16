public class Palabrabd
{
public static string PalabraAAdivinar{get; private set;}=IniciarPalabra();
public static int IntentosLetras=0;
public static List<char> LetrasUtilizadas=new List<char>();
public static int CantLetras=PalabraAAdivinar.Length;

public static string IniciarPalabra()
{
  string[]  palabra = new string[100] // esta mal esto devuelve todas las palabras y  abajo falta solo contador y cuando llegue a 
    {"GATO", "PERRO", "CASA", "ARBOL", "LIBRO", "ESCUELA", "SILLA", "MESA", "VENTANA", "PUERTA",
    "ZAPATO", "LAPIZ", "RELOJ", "CAMISA", "PANTALON", "CHAQUETA", "COCINA", "BAÑO", "TELEFONO", "COMPUTADORA",
    "TECLADO", "RATON", "PANTALLA", "CABLE", "AURICULAR", "CIUDAD", "PAIS", "MAPA", "PLANETA", "LUNA",
    "SOL", "ESTRELLA", "CIELO", "NUBE", "LLUVIA", "VIENTO", "FUEGO", "PEPE", "TIERRA", "ARENA",
    "MONTANA", "RIO", "MAR", "LAGO", "ISLA", "BOSQUE", "SELVA", "FLOR", "ARROZ", "CARNE",
    "PESCADO", "PAN", "LECHE", "HhgUEVO", "FRUTA", "MANZANA", "PERA", "BANANA", "NARANJA", "UVA",
    "ZANAHORIA", "DUDU", "LECHUGA", "PAPA", "CEBOLLA", "AJI", "AZUCAR", "SAL", "ACEITE", "VINAGRE",
    "COCHE", "BICICLETA", "AVION", "BARCO", "TREN", "CAMION", "MOTO", "TRAFICO", "CALLE", "CARRETERA",
    "SEMÁFORO", "PUENTE", "TUNEL", "ESPEJO", "LUNA", "CRISTAL", "BOTE", "VELA", "MOTOR", "RUEDA",
    "BOLIGRAFO", "CUADERNO", "MOCHILA", "ESPEJO", "JUGUETE", "PELOTA", "MUÑECA", "ROMPECABEZAS", "PINTURA", "INSTRUMENTO"};
    int num;
    Random r=new Random();
    num=r.Next(0,palabra.Count()-1);
    string palabras=palabra[num];
    return palabras;
}

public static List<int> VerificarLetra(char letra)
{
    List<int>PosicionesCorrectas=new List<int>();
    LetrasUtilizadas.Add(letra);
    for(int i=0;i<=PalabraAAdivinar.Length;i++)
    {
        if(letra.ToString()==PalabraAAdivinar)
        {
            PosicionesCorrectas.Add(i);
        }
        else
        {
            IntentosLetras++;
        }
    }
    return PosicionesCorrectas;
}
public static bool VerificarPalabra(string palabra)
{
    bool verificacionPalabra=false;
        if(palabra==PalabraAAdivinar)
    {
        verificacionPalabra=true;
        if (verificacionPalabra== true )
        {
            Console.WriteLine("GANASTE");
        }
    }
    return verificacionPalabra;
}
}
