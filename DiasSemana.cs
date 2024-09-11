internal class Program
{
    private static void Main(string[] args)
    {
        //inserção de dados no programa
        int diaSemana = Convert.ToInt32(Console.ReadLine());

        switch (diaSemana)
        {
            case 0: Console.WriteLine("domingo");
                break;

            case 1: Console.WriteLine("segunda");
                break;

            case 2: Console.WriteLine("terça");
                break;

            case 3: Console.WriteLine("quarta");
                break;
                
            case 4: Console.WriteLine("quinta");
                break;
                
            case 5: Console.WriteLine("sexta");
                break;
            
            case 6: Console.WriteLine("sabado");
                break;

            default: Console.WriteLine("dia invalido");
                break;
            }
        }
    }

