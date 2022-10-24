/*
 * Crie um função que receba um número inteiro significando a quantidade de pares de parênteses a serem utilizados em uma combinação. 
 * Determine quantas combinações são possíveis para aquela quantidade. 
 * Por ex: 3 = ()()(), (())(), ()(()), ((())), (()()) = 5 combinações possíveis.
 */
Console.WriteLine("Entre com o numero para ver a quantidade de combinações possíveis de parenteses: ");
int n = Convert.ToInt32(Console.ReadLine());
//int n = 3;
char[] str = new char[2 * n];

ImprimeParenteses(str, n);

static void _imprimeParenteses(char[] str, int pos, int n, int open, int close)
{


    if (close == n)
    {
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i]);

        Console.WriteLine();
        return;
    }
    else
    {
        if (open > close)
        {
            str[pos] = ')';
            _imprimeParenteses(str, pos + 1, n, open, close + 1);
        }
        if (open < n)
        {
            str[pos] = '(';
            _imprimeParenteses(str, pos + 1, n, open + 1, close);
        }
    }

}

static void ImprimeParenteses(char[] str, int n)
{
    if (n > 0)
        _imprimeParenteses(str, 0, n, 0, 0);
    return;
}
