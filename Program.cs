namespace RefatoraçãoDeLetras
{
    internal class Program
    {
        static void DesenhoSuperiorDiamante (int quantidadeLinhas, ref int  espacosEntreAsLetras, ref char letra, ref int  espacosDaMargem)
        {

            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                    Console.Write(" ");

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
                    Console.Write(" ");

                if (letra != 'A')
                    Console.Write(letra); //letra final 

                letra++;
                espacosDaMargem--;
                espacosEntreAsLetras += 2;

                Console.WriteLine();
            }
        }
        static void DesenhoInferiorDiamante (int quantidadeLinhas, ref int espacosEntreAsLetras, ref char letra, ref int espacosDaMargem)
        {
            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                    Console.Write(" ");

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
                    Console.Write(" ");

                if (letra != 'A')
                    Console.Write(letra); //letra final

                letra--;
                espacosDaMargem++;
                espacosEntreAsLetras -= 2;

                Console.WriteLine();
            }
        }
        static void DesenhoMeioDiamante (char letraInformada, ref int espacosEntreAsLetras, ref char letra, ref int espacosDaMargem)
        {
            Console.Write(letraInformada);

            for (int i = 0; i < espacosEntreAsLetras; i++)
                Console.Write(" ");

            Console.Write(letraInformada);

            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras -= 2;
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a letra do meio do diamante?");

            char letraInformada = Convert.ToChar(Console.ReadLine());

            char letra = 'A';

            int espacosDaMargem = letraInformada - letra;

            int quantidadeLinhas = letraInformada - letra;

            int espacosEntreAsLetras = -1;

            //desenhou a parte do superior do diamante

            DesenhoSuperiorDiamante(quantidadeLinhas, ref espacosEntreAsLetras, ref letra, ref espacosDaMargem);

            //desenho da parte do meio
            DesenhoMeioDiamante(letraInformada, ref espacosEntreAsLetras, ref letra, ref espacosDaMargem);

            //desenho da parte inferior do diamante

            DesenhoInferiorDiamante(quantidadeLinhas, ref espacosEntreAsLetras, ref letra, ref espacosDaMargem);

            Console.ReadLine();
        }
    }
}
