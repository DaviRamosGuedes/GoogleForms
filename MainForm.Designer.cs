partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem validarToolStripMenuItem;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.TextBox txtPalavra;
    private System.Windows.Forms.Button btnAdicionarPalavra;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.validarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.txtPalavra = new System.Windows.Forms.TextBox();
        this.btnAdicionarPalavra = new System.Windows.Forms.Button();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();

        // MenuStrip
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.validarToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(800, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";

        // Arquivo ToolStripMenuItem
        this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem});
        this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
        this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        this.arquivoToolStripMenuItem.Text = "Arquivo";

        // Abrir ToolStripMenuItem
        this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
        this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
        this.abrirToolStripMenuItem.Text = "Abrir";
        this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);

        // Salvar ToolStripMenuItem
        this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
        this.salvarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
        this.salvarToolStripMenuItem.Text = "Salvar";
        this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);

        // Validar ToolStripMenuItem
        this.validarToolStripMenuItem.Name = "validarToolStripMenuItem";
        this.validarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
        this.validarToolStripMenuItem.Text = "Validar";
        this.validarToolStripMenuItem.Click += new System.EventHandler(this.validarToolStripMenuItem_Click);

        // RichTextBox
        this.richTextBox1.Location = new System.Drawing.Point(12, 27);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.Size = new System.Drawing.Size(776, 411);
        this.richTextBox1.TabIndex = 1;
        this.richTextBox1.Text = "";

        // txtpalavra
        this.txtPalavra.Location = new System.Drawing.Point(12, 455);
        this.txtPalavra.Name = "txtPalavra";
        this.txtPalavra.Size = new System.Drawing.Size(260, 20);
        this.txtPalavra.TabIndex = 2;

        // btnAdicionarPalavra
        this.btnAdicionarPalavra.Location = new System.Drawing.Point(278, 453);
        this.btnAdicionarPalavra.Name = "btnAdicionarPalavra";
        this.btnAdicionarPalavra.Size = new System.Drawing.Size(260, 23);
        this.btnAdicionarPalavra.TabIndex = 3;
        this.btnAdicionarPalavra.Text = "Adicionar Palavra";
        this.btnAdicionarPalavra.UseVisualStyleBackColor = true;
        this.btnAdicionarPalavra.Click += new System.EventHandler(this.btnAdicionarPalavra_Click);

        // MainForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 488);
        this.Controls.Add(this.btnAdicionarPalavra);
        this.Controls.Add(this.txtPalavra);
        this.Controls.Add(this.richTextBox1);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "MainForm";
        this.Text = "Editor de Texto";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
