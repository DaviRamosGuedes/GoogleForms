using System;
using System.IO;

public class Dicionario
{
    private TabelaHash tabelaHash;

    public Dicionario(string caminhoArquivo)
    {
        tabelaHash = new TabelaHash();
        CarregarDicionario(caminhoArquivo);
    }

    private void CarregarDicionario(string caminhoArquivo)
    {
        if (File.Exists(caminhoArquivo))
        {
            var linhas = File.ReadAllLines(caminhoArquivo);
            foreach (var linha in linhas)
            {
                tabelaHash.Adicionar(linha.Trim());
            }
        }
    }

    public bool VerificarPalavra(string palavra)
    {
        return tabelaHash.Contem(palavra);
    }

    public void AdicionarPalavra(string palavra)
    {
        tabelaHash.Adicionar(palavra);
    }

    public void SalvarDicionario(string caminhoArquivo)
    {
        File.WriteAllLines(caminhoArquivo, tabelaHash.ObterTodasAsPalavras());
    }
}
