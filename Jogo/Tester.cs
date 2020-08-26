using System;

namespace Jogo
{
  internal class Tester
  {
    internal static void RunAllTests()
    {
      IsTextBeenWritedInConsole();
      IsFirstPlayerBeenCreated();
      IsBoardBeenCreated();
    }

    private static void IsBoardBeenCreated()
    {
      try
      {
        // Criar o tabuleiro
        Board board = new Board();

        // Escrever tabuleiro no console
        Console.WriteLine("1 _ | _ | _");
        Console.WriteLine("2 _ | _ | _");
        Console.WriteLine("3 _ | _ | _");
        Console.WriteLine("  A   B   C");
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }



    /// <summary>
    /// Testa se o jogo está iniciando
    /// </summary>
    private static void IsTextBeenWritedInConsole()
    {
      try
      {
        Console.WriteLine("Jogo iniciado");
      }
      catch (Exception ex)
      {
        throw ex; // Lança erro no console
      }
    }
    /// <summary>
    /// Testa se um jogador está sendo criado
    /// </summary>
    private static void IsFirstPlayerBeenCreated()
    {
      try
      {
        Console.WriteLine("Nome do primeiro jogador: ");
        string nome = Console.ReadLine();
        Player player1 = new Player(nome);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}