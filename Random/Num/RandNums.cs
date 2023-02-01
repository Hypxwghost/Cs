class RandNums
{
    static void Main()
    {
        Random rnd = new Random();

        Console.Clear();
        Separador();
        Console.WriteLine("[1] - Sorteador de numeros \n[2] - Sorteador de bool");
        Separador();
        char escolha = Convert.ToChar(Console.ReadLine());

        while (true)
        {
            try
            {
                if (escolha == '1')
                {
                    Separador();
                    Console.WriteLine("Limite maximo de numeros: ");
                    int range = Convert.ToInt32(Console.ReadLine());
                    Separador();

                    Console.WriteLine(rnd.Next(1, range));
                }
                else if (escolha == '2')
                {
                    Console.WriteLine(rnd.Next(2) == 1);
                }
                else
                {
                    Console.WriteLine("Opção Inválida!\n Pressione qualquer tecla para continuar...");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("Continuar? [S/N]");
                char continua = Convert.ToChar(Console.ReadLine());

                if (continua != 'S' | continua != 's' | continua == ' ')
                {
                    break;
                }

            }
            catch (Exception ex) when (ex is OverflowException || ex is FormatException)
            {
                Console.WriteLine("Valor Inválido!");
            }
        }
    }

    static void Separador()
    {
        Console.WriteLine(new string('-', 50));
    }
}