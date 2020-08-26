namespace Jogo
{
  internal class Board
  {
    public string UmUm;
    public string UmDois;
    public string UmTres;

    public string DoisUm;
    public string DoisDois;
    public string DoisTres;

    public string TresUm;
    public string TresDois;
    public string TresTres;

    public Board()
    {
      string NullSymbol = "_"; // Símbolo do espaço nulo

      UmUm = NullSymbol;
      UmDois = NullSymbol;
      UmTres = NullSymbol;
      DoisUm = NullSymbol;
      DoisDois = NullSymbol;
      DoisTres = NullSymbol;
      TresUm = NullSymbol;
      TresDois = NullSymbol;
      TresTres = NullSymbol;
    }
  }
}