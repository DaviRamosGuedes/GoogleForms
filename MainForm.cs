
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private Editor editor;
    private Dicionario dicionario;

    public MainForm()
    {
        InitializeComponent();
        dicionario = new Dicionario("dicionario.txt");
        editor = new Editor(dicionario);
    }

    private void btnAdicionarPalavra_Click(object sender, EventArgs e)
    {
        string palavra = txtPalavra.Text.Trim();
        if (string.IsNullOrEmpty(palavra))
        {
            MessageBox.Show("Por favor, insira uma palavra válida.");
            return;
        }

        if (dicionario.VerificarPalavra(palavra))
        {
            MessageBox.Show("A palavra já está no dicionário.");
        }
        else
        {
            dicionario.AdicionarPalavra(palavra);
            dicionario.SalvarDicionario("dicionario.txt");
            MessageBox.Show("Palavra adicionada com sucesso!");
        }
    }

    private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog.FileName;
                editor.CarregarTexto(caminhoArquivo);
                richTextBox1.Text = editor.Texto;
            }
        }
    }

    private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
            saveFileDialog.Filter = "Arquivos de texto (.txt)|.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog.FileName;
                if (!string.IsNullOrWhiteSpace(caminhoArquivo))
                {
                    // Atualiza o texto no editor com o texto do RichTextBox
                    editor.NovoTexto(richTextBox1.Text);

                    // Salva o texto
                    editor.SalvarTexto(caminhoArquivo);
                    MessageBox.Show("Texto salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Caminho do arquivo inválido.");
                }
            }
        }
    }

    private void validarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        editor.NovoTexto(richTextBox1.Text);
        string textoValidado = editor.ValidarTexto();
        richTextBox1.Text = textoValidado;
    }
}
