using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();

        

        Console.WriteLine("Entre com os dados dos produto: ");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine());
        Console.Write("Quantidade: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);

        Console.WriteLine();
        Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        Console.WriteLine("Dados atualizados: " + p);

        Console.WriteLine();
        Console.Write("Digite o numero de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProduto(qte);

        Console.WriteLine("Dados atualizados: " + p);

        Console.ReadLine();
    }

}   