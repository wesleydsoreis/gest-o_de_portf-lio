using System;

public class Projeto
{
    // Básicos
    public int id;
    public string nome;
    public string gerente;
    public string sponsor;

    // Custos e prazos
    public decimal orcamentoAprovado;
    public decimal custoReal;
    public DateTime? prazoInicial;
    public DateTime? novoPrazo;
    public int progresso; // 0..100

    // Critérios (ROI 0..100; demais 0..10)
    public int roi;
    public int risco;
    public int alinhamento;
    public int urgencia;

    // Derivados
    public int score;        // 0..100
    public string aprovacao; // "Apto"/"Não Apto"
    public string status;    // "Em Análise"/"Em Execução"/"Encerrado"

    public Projeto()
    {
        this.nome = "";
        this.gerente = "";
        this.sponsor = "";
        this.status = "Em Análise";
        this.progresso = 0;
    }

    public void RecalcularScoreEAprovacao()
    {
        int roi10 = this.roi / 10; // normaliza ROI para base 0..10
        this.score = (this.alinhamento * 2) + (roi10 * 3) + (this.urgencia * 3) + (this.risco * 2);
        this.aprovacao = (this.score >= 70) ? "Apto" : "Não Apto";
    }

    public string DesvioCustoTexto()
    {
        if (orcamentoAprovado <= 0 || custoReal <= 0) return "";
        decimal desvio = (custoReal - orcamentoAprovado) / orcamentoAprovado * 100m;
        string sinal = desvio >= 0 ? "+" : "";
        return sinal + Math.Round(desvio, 1) + "%";
    }

    public string DesvioPrazoTexto()
    {
        if (!prazoInicial.HasValue || !novoPrazo.HasValue) return "";
        int dias = (novoPrazo.Value - prazoInicial.Value).Days;
        if (dias == 0) return "0 dia";
        string sinal = dias > 0 ? "+" : "";
        return sinal + Math.Abs(dias) + (Math.Abs(dias) == 1 ? " dia" : " dias");
    }
}
