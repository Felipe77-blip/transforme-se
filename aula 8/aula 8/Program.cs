namespace aula_8
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("digite um número para sua tabuada:");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <=10;i++)
            {
                Console.WriteLine($"1 x {i}= {1*i}");
            } */
            /*
            //Var
            int[] numeros;
            int resultado_soma;

            //Instanciação
            numeros = new int[2];

            //Inicio
            numeros[0] = 4;
            numeros[1] = 5;

            resultado_soma=numeros[0]+ numeros[1];

            Console.WriteLine(resultado_soma);
            */
            /*
            //var
            int[] A;
            int resultado_sub;

            //Instanciação
            A = new int[2];
            //Inicio
            A[0]=int.Parse(Console.ReadLine());
            A[1]=int.Parse(Console.ReadLine());
            resultado_sub = A[0]-A[1];
            Console.WriteLine(resultado_sub);
            */
            /*
            //var
            int[] notas;
            int Resultado_notas;


            //Instanciação
            notas= new int[3];

            //inicio
            notas [0] = int.Parse(Console.ReadLine());
            notas[1] = int.Parse(Console.ReadLine());
            notas[2]=int.Parse(Console.ReadLine());
            Resultado_notas = (notas[0]+ notas[1])/2;
            Console.WriteLine(Resultado_notas);
            */

            int[] notas;
            notas= new int[5];
            notas[0] = 1;
            notas[1] = 2;
            notas[2] = 3;
            notas[3] = 4;
            notas[4] = 5;

            Console.WriteLine(notas.Length);

            int P;
            for(P = 0; P < 5; P++)
            {
                Console.WriteLine(notas[P]);
                
            }


        }

    }  
}


    
