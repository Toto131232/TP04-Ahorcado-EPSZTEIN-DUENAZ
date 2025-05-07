public class Palabrabd
{
public List<string> PalabraAAdivinar {get; private set;}=IniciarPalabra();

public static List<string> IniciarPalabra()
{
    List<string> palabra=new List<string>();
    palabra.Add("GATO");
    palabra.Add("PERRO");
    palabra.Add("CASA");
    palabra.Add("ARBOL");
    palabra.Add("CIELO");
    palabra.Add("RIO");
    palabra.Add("FLOR");
    palabra.Add("LUNA");
    palabra.Add("SOL");
    palabra.Add("MAR");
    palabra.Add("MONTAÑA");
    palabra.Add("NUBE");
    palabra.Add("ESTRELLA");
    palabra.Add("FUEGO");
    palabra.Add("TIERRA");
    palabra.Add("VIENTO");

    return palabra;
}

public bool VerificarLetra(char letra)
{
    bool LetraCorrecta=false;

    foreach(string palabra in PalabraAAdivinar)
    {
        
    }
    return LetraCorrecta;
}

}