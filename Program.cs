﻿int codigo = int.Parse(Console.ReadLine());
int quantidade = int.Parse(Console.ReadLine());
double preco = 0.00;

if (codigo == 1)
{
    preco = 4.00;
}
else if (codigo == 2)
{
    preco = 4.50;
}
else if (codigo == 3)
{
    preco = 5.00;
}
else if (codigo == 4)
{
    preco = 2.00;
}
else if (codigo == 5)
{
    preco = 1.50;
}

Console.WriteLine("Total: R$: "+ ((quantidade * preco).ToString("F")));
