namespace ATV2_CJ3022153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////// EXERCICICO 2 //////////////////// 

            float salario;

            Console.WriteLine("Entre com o seu Salário:");
            
            salario = float.Parse( Console.ReadLine() );

            salario = salario + (25.0f/100.0f) * salario;

            Console.WriteLine("O novo salário é R$ {0}", salario);
        } 
    }
}         
