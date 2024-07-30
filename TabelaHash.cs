using System;
using System.Collections.Generic;

public class TabelaHash
{
    private const int TamanhoInicial = 1000;
    private List<string>[] tabela;

    public TabelaHash(int tamanho = TamanhoInicial)
    {
        tabela = new List<string>[tamanho];
        for (int i = 0; i < tabela.Length; i++)
        {
            tabela[i] = new List<string>();
        }
    }

    private int CalcularIndice(string chave)
    {
        return Math.Abs(chave.GetHashCode()) % tabela.Length;
    }

    public void Adicionar(string palavra)
    {
        int indice = CalcularIndice(palavra);
        if (!tabela[indice].Contains(palavra))
        {
            tabela[indice].Add(palavra);
        }
    }

    public bool Contem(string palavra)
    {
        int indice = CalcularIndice(palavra);
        return tabela[indice].Contains(palavra);
    }

    public IEnumerable<string> ObterTodasAsPalavras()
    {
        foreach (var lista in tabela)
        {
            foreach (var palavra in lista)
            {
                yield return palavra;
            }
        }
    }
}
