using System.IO;

public static class Arquivo
{
    public static void Salvar(string caminho, string conteudo)
    {
        File.WriteAllText(caminho, conteudo);
    }

    public static string Carregar(string caminho)
    {
        return File.ReadAllText(caminho);
    }
}
