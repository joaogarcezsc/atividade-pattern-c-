using System;
using System.Collections.Generic;
using PadraoPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bloqueio de Conta");
        List<Conta> list = new List<Conta>()
        {
            new Conta() { Numero = 1, Score = 100, Saldo = 1000.0, UFAgencia = "SE" },
            new Conta() { Numero = 2, Score = 200, Saldo = 2000.0, UFAgencia = "SP" },
            new Conta() { Numero = 3, Score = 300, Saldo = 3000.0, UFAgencia = "RJ" } 
        };

        TransacaoBancaria transacao = new TransacaoBancaria();
        transacao.NumeroConta = 2;
        transacao.Tipo = "Saque";
        transacao.Valor = 500.0;
        transacao.AgenciaTransacao = "BA";

        bool bloquea = false;

        Conta dadosConta = list.FirstOrDefault(x=>x.Numero==transacao.NumeroConta);


        bool bloquear = verificarBloqueio(dadosConta, transacao);

        Console.WriteLine($"Status da Conta Bloqueio: {bloquear}");
    }

    private static bool verificarBloqueio(Conta conta, TransacaoBancaria transacao)
    {

        bool bloquear = false;
        IBloquearConta bloquearConta;

        bloquearConta = new Regra1Bloqueio();
        bloquear = bloquear || bloquearConta.analiseBloqueio(conta, transacao);

        bloquearConta = new Regra2Bloqueio();
        bloquear = bloquear || bloquearConta.analiseBloqueio(conta, transacao);

        bloquearConta = new Regra3Bloqueio();
        bloquear = bloquear || bloquearConta.analiseBloqueio(conta, transacao);

        return bloquear;
    }
}
