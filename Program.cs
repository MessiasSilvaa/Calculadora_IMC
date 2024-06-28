using System;
using System.Globalization;

namespace CALCULADORA_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passo 2: Solicitar entrada do usuário
            Console.WriteLine("Digite seu peso em kg (ex: 69.0):");
            string pesoInput = Console.ReadLine();
            double peso = Convert.ToDouble(pesoInput.Replace(',', '.'), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite sua altura em metros (ex: 1.75):");
            string alturaInput = Console.ReadLine();
            double altura = Convert.ToDouble(alturaInput.Replace(',', '.'), CultureInfo.InvariantCulture);

            // Passo 3: Calcular o IMC
            double imc = peso / (altura * altura);

            // Passo 4: Determinar a categoria do IMC
            string categoria;
            if (imc < 18.5)
            {
                categoria = "Baixo peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                categoria = "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                categoria = "Sobrepeso";
            }
            else
            {
                categoria = "Obesidade";
            }

            // Passo 5: Exibir o resultado
            Console.WriteLine($"Seu IMC é: {imc:F2}");
            Console.WriteLine($"Categoria: {categoria}");
        }
    }
}

