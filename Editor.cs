using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Editor
{
    private string texto;
    private Dicionario dicionario;

    public Editor(Dicionario dicionario)
    {
        this.dicionario = dicionario;
        this.texto = string.Empty;
    }

    public void CarregarTexto(string caminhoArquivo)
    {
        texto = File.ReadAllText(caminhoArquivo);
    }

    public void SalvarTexto(string caminhoArquivo)
    {
        try
        {
            File.WriteAllText(caminhoArquivo, texto);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao salvar o arquivo: {ex.Message}");
        }
    }

    public void NovoTexto(string novoTexto)
    {
        texto = novoTexto;
    }

    public string Texto
    {
        get { return texto; }
    }

    public string ValidarTexto()
{
    string[] palavras = texto.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    HashSet<string> palavrasInvalidas = new HashSet<string>();

    foreach (var palavra in palavras)
    {
        string palavraLimpada = LimparPontuacao(palavra).ToLower(); // Convertendo para minúsculas
        if (!dicionario.VerificarPalavra(palavraLimpada))
        {
            palavrasInvalidas.Add(palavra);  // Adiciona a palavra original com a formatação
        }
    }

    return MarcarPalavrasInvalidas(palavrasInvalidas);
}


    private string LimparPontuacao(string palavra)
{
    char[] pontuacoes = { '.', ',', ';', '!', '?', ':', '-', '(', ')', '[', ']', '{', '}', '\"', '\'' };
    return palavra.Trim(pontuacoes);
}

   private string MarcarPalavrasInvalidas(HashSet<string> palavrasInvalidas)
{
    List<string> palavrasTexto = texto.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();

    for (int i = 0; i < palavrasTexto.Count; i++)
    {
        string palavraLimpada = LimparPontuacao(palavrasTexto[i]).ToLower(); // Convertendo para minúsculas para comparação
        if (palavrasInvalidas.Any(p => LimparPontuacao(p).ToLower() == palavraLimpada))  // Comparando em minúsculas
        {
            palavrasTexto[i] = $"/{palavrasTexto[i]}/";
        }
    }

    return string.Join(" ", palavrasTexto);
}

}
