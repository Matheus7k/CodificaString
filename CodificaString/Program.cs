using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        string texto;
        char codigo;

        Console.Write("Digite uma frase para ser codificada: ");
        texto = Console.ReadLine();

        Console.Write("Digite um caractere para a codificação: ");
        codigo = char.Parse(Console.ReadLine());

        Console.Write("Texto codificado: ");
        foreach (char c in codificaTexto(texto.ToLower(), codigo))
        {
            Console.Write(c);
        }

        List<char> codificaTexto(string texto, char codigo)
        {
            List<char> textoCodificado = new();

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != 'a' && texto[i] != 'e' && texto[i] != 'i' && texto[i] != 'o' && texto[i] != 'u' && char.IsLetter(texto[i]))
                {
                    textoCodificado.Add(codigo);
                    textoCodificado.Add(texto[i]);
                }
                else
                {
                    textoCodificado.Add(texto[i]);
                }
            }
            return textoCodificado;
        }

    }
}