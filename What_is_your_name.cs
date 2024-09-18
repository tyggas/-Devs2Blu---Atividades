            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}, tudo bem? Qual é a seu ano de nascimento:");
            string Year = Console.ReadLine();
            Console.WriteLine("Qual seu mês de nascimento:");
            string month = Console.ReadLine();
            Console.WriteLine("Qual o seu dia de nascimento:");
            string day = Console.ReadLine();   
            string inputData = $"{day}/{month}/{Year}";


            DateTime.TryParse(inputData, out DateTime dataNascimento);
            Console.WriteLine($"Data de Nascimento: {dataNascimento.ToShortDateString()}");
            int idade = CalcularIdade(dataNascimento);
            Console.WriteLine($"Você tem {idade} anos.");
            
            static int CalcularIdade(DateTime dataNascimento)
            {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;
            return idade;
            }
