
using System;
using Xunit;

public class ProjetoValidationTests
{
    [Fact]
    public void RecalcularScore_DeveAceitarValoresValidos()
    {
        var projeto = new Projeto
        {
            roi = 100,
            risco = 10,
            alinhamento = 10,
            urgencia = 10
        };

        projeto.RecalcularScoreEAprovacao();

        Assert.Equal(100, projeto.score);
        Assert.Equal("Apto", projeto.aprovacao);
    }

    [Theory]
    [InlineData(-1, 5, 5, 5)]
    [InlineData(101, 5, 5, 5)]
    [InlineData(50, -1, 5, 5)]
    [InlineData(50, 11, 5, 5)]
    [InlineData(50, 5, -1, 5)]
    [InlineData(50, 5, 11, 5)]
    [InlineData(50, 5, 5, -1)]
    [InlineData(50, 5, 5, 11)]
    public void RecalcularScore_DeveRejeitarValoresInvalidos(
        int roi, int risco, int alinhamento, int urgencia)
    {
        var projeto = new Projeto
        {
            roi = roi,
            risco = risco,
            alinhamento = alinhamento,
            urgencia = urgencia
        };

        Assert.Throws<ArgumentOutOfRangeException>(
            () => projeto.RecalcularScoreEAprovacao());
    }
}
