namespace aula_9_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] A = new int[8];
            int[] B = new int[8];
            //var
            for (int i = 0; i < 8; i++) 
            {
                Console.WriteLine($"digite {i + 1}");
                A[i] = int .Parse( Console.ReadLine() );
                
            }
            for (int i = 0; i < 8; i++)
            {
                B[i] = A[i] * 3;
                Console.WriteLine(B[i]);
                
            }
        */
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[5];
            //var




            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("digite o valor A");
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 5; i<5; i++)
            {
                B[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 5;i<5; i++)
            {
                C[i] = A[i]-B[i];
                Console.WriteLine(C[i]);
            }


        } 
                    
        }
    }

