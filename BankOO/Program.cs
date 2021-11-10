using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteJoao = new Gerente()
            {
                Nome = "João",
                CPF = "378.159.442-11",
                Salario = 5500,
                NumeroDeAgencias = 4,
            };

            Vendedor vendedorLuis = new Vendedor()
            {
                Nome = "Luís",
                CPF = "142.570.068-45",
                Salario = 3000,
                NumeroClientesAtendidos = 3,
            };

            Vendedor vendedorJubileu = new Vendedor()
            {
                Nome = "Jubileu",
                CPF = "075.112.258-77",
                Salario = 2000,
                NumeroClientesAtendidos = 6,
            };

            Vendedor vendedorJubiscreudo = new Vendedor()
            {
                Nome = "Jubiscreudo",
                CPF = "033.007.077-04",
                Salario = 1000,
                NumeroClientesAtendidos = 5,
            };

            vendedorJubileu.Bonificacao = vendedorJubileu.Salario;
            vendedorLuis.Bonificacao = vendedorLuis.Salario;
            vendedorJubiscreudo.Bonificacao = vendedorJubiscreudo.Salario;
            gerenteJoao.Bonificacao = gerenteJoao.Salario;

            ContaCorrente contaDoAntonio = new ContaCorrente("Antonio Alexandre Barbosa da Silva", 45, 2500, vendedorJubileu);
            contaDoAntonio.Conta = 333;
            ContaCorrente contaDoJose = new ContaCorrente("José", 04, 3000, vendedorJubiscreudo);
            contaDoJose.Conta = 123;
            ContaCorrente contaDoJorge = new ContaCorrente("Jorge", 63, 1500, vendedorLuis);
            contaDoJorge.Conta = 332;

            Console.WriteLine("\nBonificação Luís: " + vendedorLuis.Bonificacao +
            "\nBonificação Jubiscreudo: " + vendedorJubiscreudo.Bonificacao + 
            "\nBonificação Jubileu: " + vendedorJubileu.Bonificacao +
            "\nBonificação João: " + gerenteJoao.Bonificacao +
            "\nRemuneração total Luís: " + vendedorLuis.RemuneracaoTotal(vendedorLuis.Salario, vendedorLuis.Bonificacao) +
            "\nRemuneração total Jubileu: " + vendedorJubileu.RemuneracaoTotal(vendedorJubileu.Salario, vendedorJubileu.Bonificacao) + 
            "\nRemuneração total Jubiscreudo: " + vendedorJubiscreudo.RemuneracaoTotal(vendedorJubiscreudo.Salario, vendedorJubiscreudo.Bonificacao) +
            "\nRemuneração total João: " + gerenteJoao.RemuneracaoTotal(gerenteJoao.Salario, gerenteJoao.Bonificacao) +
            "\nDias de férias Luís: " + vendedorLuis.CalcularFerias() +
            "\nDias de férias Jubileu: " + vendedorJubileu.CalcularFerias() +
            "\nDias de férias Jubiscreudo: " + vendedorJubiscreudo.CalcularFerias() +
            "\nDias de férias João: " + gerenteJoao.CalcularFerias());

            Console.WriteLine("\nConta 1: " + contaDoAntonio.Titular +
            "\nConta 2: " + contaDoJorge.Titular + 
            "\nConta 3: " + contaDoJose.Titular);

            Console.WriteLine("\nO número de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);

        }
    }
}