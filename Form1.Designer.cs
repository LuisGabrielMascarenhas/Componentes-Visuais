
namespace componentes_visuais
{
    partial class ComponentesVisuais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.mmAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mmSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.mmConteudo = new System.Windows.Forms.ToolStripMenuItem();
            this.mmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mmCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mmColar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripArquivo,
            this.toolStripEditar,
            this.toolStripMenuAjuda,
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            this.menuStrip2.Click += new System.EventHandler(this.menuStrip2_Click);
            // 
            // toolStripArquivo
            // 
            this.toolStripArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmAbrir,
            this.mmSalvar,
            this.mmSalvarComo,
            this.toolStripSeparator1,
            this.mmFechar});
            this.toolStripArquivo.Name = "toolStripArquivo";
            this.toolStripArquivo.Size = new System.Drawing.Size(61, 23);
            this.toolStripArquivo.Text = "&Arquivo";
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmCopiar,
            this.mmColar});
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(49, 23);
            this.toolStripEditar.Text = "&Editar";
            // 
            // toolStripMenuAjuda
            // 
            this.toolStripMenuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmConteudo,
            this.mmSobre});
            this.toolStripMenuAjuda.Name = "toolStripMenuAjuda";
            this.toolStripMenuAjuda.Size = new System.Drawing.Size(50, 23);
            this.toolStripMenuAjuda.Text = "&Ajuda";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Opção 1 ",
            "Opção 2",
            "Opção 3"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // mmAbrir
            // 
            this.mmAbrir.Name = "mmAbrir";
            this.mmAbrir.Size = new System.Drawing.Size(180, 22);
            this.mmAbrir.Text = "&Abrir";
            this.mmAbrir.Click += new System.EventHandler(this.mmAbrir_Click);
            // 
            // mmSalvar
            // 
            this.mmSalvar.Name = "mmSalvar";
            this.mmSalvar.Size = new System.Drawing.Size(180, 22);
            this.mmSalvar.Text = "&Salvar";
            this.mmSalvar.Click += new System.EventHandler(this.mmSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mmSalvarComo
            // 
            this.mmSalvarComo.Name = "mmSalvarComo";
            this.mmSalvarComo.Size = new System.Drawing.Size(180, 22);
            this.mmSalvarComo.Text = "&Salvar Como";
            // 
            // mmFechar
            // 
            this.mmFechar.Name = "mmFechar";
            this.mmFechar.Size = new System.Drawing.Size(180, 22);
            this.mmFechar.Text = "&Fechar";
            // 
            // mmConteudo
            // 
            this.mmConteudo.Name = "mmConteudo";
            this.mmConteudo.Size = new System.Drawing.Size(161, 22);
            this.mmConteudo.Text = "Conteudo Ajuda";
            // 
            // mmSobre
            // 
            this.mmSobre.Name = "mmSobre";
            this.mmSobre.Size = new System.Drawing.Size(161, 22);
            this.mmSobre.Text = "Sobre";
            // 
            // mmCopiar
            // 
            this.mmCopiar.Name = "mmCopiar";
            this.mmCopiar.Size = new System.Drawing.Size(109, 22);
            this.mmCopiar.Text = "Copiar";
            // 
            // mmColar
            // 
            this.mmColar.Name = "mmColar";
            this.mmColar.Size = new System.Drawing.Size(109, 22);
            this.mmColar.Text = "Colar";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 23);
            // 
            // ComponentesVisuais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "ComponentesVisuais";
            this.Text = "ComponentesVIsuais";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripArquivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAjuda;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem mmAbrir;
        private System.Windows.Forms.ToolStripMenuItem mmSalvar;
        private System.Windows.Forms.ToolStripMenuItem mmSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mmFechar;
        private System.Windows.Forms.ToolStripMenuItem mmCopiar;
        private System.Windows.Forms.ToolStripMenuItem mmColar;
        private System.Windows.Forms.ToolStripMenuItem mmConteudo;
        private System.Windows.Forms.ToolStripMenuItem mmSobre;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

