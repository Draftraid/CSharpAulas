using CSharpAulas.Uteis;
int op = 1, num1,  num2;
do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("""
        0) SAIR
        1) SOMAR
        2) SUBTRAIR
        3) MULTIPICAR
        4) DIVIDIR
        5) FATORAR
        """);
    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 0:
            Console.WriteLine("O programa será finalizado");
            break;
        case 1:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da soma dos números {num1} e {num2} é: {Calculadora.Soma(num1, num2)}");
            break;
        case 2:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da subtração dos números {num1} e {num2} é: {Calculadora.Subtracao(num1, num2)}");
            break;
        case 3:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da multiplicação dos números {num1} e {num2} é: {Calculadora.Multiplicacao(num1, num2)}");
            break;
        case 4:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da divisão dos números {num1} e {num2} é: {Calculadora.Divisao(num1, num2)}");
            break;
        case 5:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da fatoração dos números {num1} é: {Calculadora.Fatorial(num1)}");
            break;  



    }

} while (op != 0);

void LerDoisNumerosInteiros()
{
    Console.WriteLine("Escreva o primeiro número:");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o segundo número:");
    num2 = int.Parse(Console.ReadLine());
}
