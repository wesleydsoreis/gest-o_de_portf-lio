using System;
using Xunit;

public class ProjetoTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-100)]
    public void RecalcularScoreEAprovacao_DeveRejeitarOrcamentoNaoPositivo(decimal orcamentoInvalido)
    {
        var projeto = new Projeto
        {
            orcamentoAprovado = orcamentoInvalido,
            roi = 50,
            risco = 5,
            alinhamento = 5,
            urgencia = 5
        };

        Assert.Throws<ArgumentOutOfRangeException>(() => projeto.RecalcularScoreEAprovacao());
    }

    [Fact]
    public void RecalcularScoreEAprovacao_DeveCalcularQuandoOrcamentoValido()
    {
        var projeto = new Projeto
        {
            orcamentoAprovado = 10000m,
            roi = 80,
            risco = 8,
            alinhamento = 8,
            urgencia = 8
        };

        projeto.RecalcularScoreEAprovacao();

        Assert.Equal(80, projeto.score);
        Assert.Equal("Apto", projeto.aprovacao);
    }
}
