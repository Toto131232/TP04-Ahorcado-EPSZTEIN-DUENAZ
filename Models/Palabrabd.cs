public class Palabrabd
{
public static string PalabraAAdivinar { get; private set; }
public static int IntentosLetras{ get; private set; }
public static List<char> LetrasUtilizadas{ get; private set; } =new List<char>();
public static int CantLetras{ get; private set; }
  public static string PalabraOculta { get; private set; }
public static List<int> PosicionesCorrectas { get; private set; } = new List<int>();
    public static string IniciarPalabra()
    {
     string[] palabras = new string[]
{
    "GATO", "PERRO", "CASA", "ARBOL", "LIBRO", "ESCUELA", "SILLA", "MESA", "VENTANA", "PUERTA",
    "ZAPATO", "LAPIZ", "RELOJ", "CAMISA", "PANTALON", "CHAQUETA", "COCINA", "BAÑO", "TELEFONO", "COMPUTADORA",
    "TECLADO", "RATON", "PANTALLA", "CABLE", "AURICULAR", "CIUDAD", "PAIS", "MAPA", "PLANETA", "LUNA",
    "SOL", "ESTRELLA", "CIELO", "NUBE", "LLUVIA", "VIENTO", "FUEGO", "TIERRA", "ARENA", "MONTANA",
    "RIO", "MAR", "LAGO", "ISLA", "BOSQUE", "SELVA", "FLOR", "ARROZ", "CARNE", "PESCADO",
    "PAN", "LECHE", "HUEVO", "FRUTA", "MANZANA", "PERA", "BANANA", "NARANJA", "UVA", "ZANAHORIA",
    "LECHUGA", "PAPA", "CEBOLLA", "AJI", "AZUCAR", "SAL", "ACEITE", "VINAGRE", "COCHE", "BICICLETA",
    "AVION", "BARCO", "TREN", "CAMION", "MOTO", "TRAFICO", "CALLE", "CARRETERA", "SEMAFORO", "PUENTE",
    "TUNEL", "ESPEJO", "CRISTAL", "BOTE", "VELA", "MOTOR", "RUEDA", "BOLIGRAFO", "CUADERNO", "MOCHILA",
    "JUGUETE", "PELOTA", "MUÑECA", "ROMPECABEZAS", "PINTURA", "INSTRUMENTO", "RECREO", "PROFESOR", "ALUMNO", "TAREA"};
      Random rnd = new Random();
        string palabra = palabras[rnd.Next(palabras.Count())];
        return palabra;
    }
    public static void IniciarJuego()
    {
        IntentosLetras = 0;
        PalabraAAdivinar = IniciarPalabra();
        CantLetras = PalabraAAdivinar.Length;
        PalabraOculta = new string('_', CantLetras);
        LetrasUtilizadas = new List<char>();
}

    public static string VerificarLetra(char letra)
    {
        bool LetraEncontrada = false;
        for (int i = 0; i < CantLetras; i++)
        {
            if (PalabraAAdivinar[i] == letra)
            {
                PalabraOculta = PalabraOculta.Remove(i, 1).Insert(i, letra.ToString());
                LetraEncontrada = true;
            }
        }

        if (LetraEncontrada == false)
        {
            if (LetrasUtilizadas.Contains(letra)==false)
            {
                  LetrasUtilizadas.Add(letra);
                  IntentosLetras++;
            }
        }

        return PalabraOculta;
    }


    
public static bool VerificarPalabra(string palabra)
    {
        bool verificacionPalabra = false;
        if (palabra == PalabraAAdivinar)
        {
            verificacionPalabra = true;
        }
        return verificacionPalabra;
    }
}
