double peso;
double altura;
double imc;


string diagnostico;


Console.WriteLine("-- Calculadora de IMC --\n");


Console.Write("Digite seu peso em kg...: ");
peso = Convert.ToDouble(Console.ReadLine());


Console.Write("Digite sua altura em m..: ");
altura = Convert.ToDouble(Console.ReadLine());


imc = peso / Math.Pow(altura, 2);
//ou
//imc = peso / (altura * altura);


if (imc < 17)
{
    diagnostico = "Muito abaixo do peso";
}
else if (imc < 18.5)
{
    diagnostico = "Abaixo do peso";
}
else if (imc < 25)
{
    diagnostico = "Peso normal";
}
else if (imc < 30)
{
    diagnostico = "Acima do peso";
}
else if (imc < 35)
{
    diagnostico = "Obesidade I";
}
else if (imc < 40)
{
    diagnostico = "Obesidade II(severa)";
}
else 
{
    diagnostico = "Obesidade III (morbida)";
}

Console.WriteLine($"\nSeu IMC é {imc:N2} kg/m².");
Console.WriteLine($"Diagnóstico: {diagnostico}");