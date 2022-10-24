/* 
 * 1 - Crie uma função que determine se uma string de entrada é um palíndromo (pode ser lida em ambos os sentidos com o mesmo significado).
 * Não utilize a função Reverse() da string.Exemplos de palíndromos: "o lobo ama o bolo", 
 */

Console.WriteLine("Entre com a frase ou palavra para validar se é palíndromo: ");

string str = Console.ReadLine().Replace(" ", "").ToLower();
int x = str.Length - 1;

ValidarPalindromo(str, x);

void ValidarPalindromo(string str, int x)
{
    while (x >= 0)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == str[x])
            {
                if (x == 0)
                    Console.Write("É palíndromo");
                x--;
            }
            else
            {
                Console.Write("Não é palíndromo");
                i = str.Length;
                x = -1;
            }
        }
    }
}

