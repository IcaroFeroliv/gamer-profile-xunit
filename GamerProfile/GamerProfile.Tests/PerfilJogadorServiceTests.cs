using Xunit;
using GamerProfile.App;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    // Teste 1 (string)
    [Fact]
    public void GerarTagUsuario_DeveGerarFormatacaoCorreta()
    {
        // Arrange
        var service = new PerfilJogadorService();
        
        // Act
        var resultado = service.GerarTagUsuario("Aragorn", "1042");
        
        // Assert
        Assert.Equal("Aragorn#1042", resultado);
    }

    // Teste 2 (int)
    [Fact]
    public void CalcularXPTotal_DeveRealizarSomaEAplicarBonus()
    {
        // Arrange
        var service = new PerfilJogadorService();
        
        // Act
        var resultado = service.CalcularXPTotal(200, 300);
        
        // Assert
        Assert.Equal(600, resultado);
    }

    // Teste 3 (bool) - Parte 1: Elegível
    [Fact]
    public void EEligivelParaRanked_NiveisAPartirDe15DevemRetornarTrue()
    {
        // Arrange
        var service = new PerfilJogadorService();
        
        // Act
        var resultado = service.EEligivelParaRanked(15);
        
        // Assert
        Assert.True(resultado);
    }

    // Teste 3 (bool) - Parte 2: Inelegível
    [Fact]
    public void EEligivelParaRanked_NiveisAbaixoDe15DevemRetornarFalse()
    {
        // Arrange
        var service = new PerfilJogadorService();
        
        // Act
        var resultado = service.EEligivelParaRanked(14);
        
        // Assert
        Assert.False(resultado);
    }
}