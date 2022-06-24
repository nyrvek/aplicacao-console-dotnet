string operacao,continuar="s",fim;
double num1 ,num2;
do
    {
        Console.Clear();

        Console.WriteLine("      Olá, sou sua calculadora");

        Console.WriteLine("----------------------------------");

        Console.WriteLine("Para começar digite um valor: ");
             num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um segundo valor: ");
            num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Agora selecione uma operação: ");
            operacao = Console.ReadLine();

        if (operacao == "+" || operacao=="soma") 
            {
                Console.WriteLine(num1+num2);
            }
        else if (operacao=="-" || operacao=="subtracao" )
            {
                Console.WriteLine(num1-num2);
            }
        else if (operacao=="/" || operacao=="divisao" )
            {
                Console.WriteLine(num1/num2);
            }
        else if (operacao=="*" || operacao=="multiplicacao" )
            {
                Console.WriteLine(num1*num2);
            } 
       
        Console.WriteLine("Deseja continuar? Sim=S Não= N");
        fim = Console.ReadLine();     
    }
while (fim==continuar);
 