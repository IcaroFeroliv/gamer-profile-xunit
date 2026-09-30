namespace GamerProfile.App;

public class PerfilJogadorService
{
    // 1. Retorno string
    public string GerarTagUsuario(string nickname, string codigo)
    {
        return $"{nickname}#{codigo}";
    }

    // 2. Retorno int
    public int CalcularXPTotal(int xpFase1, int xpFase2)
    {
        return xpFase1 + xpFase2 + 100;
    }

    // 3. Retorno bool
    public bool EEligivelParaRanked(int nivelJogador)
    {
        return nivelJogador >= 15;
    }
}