namespace MenuContextual
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pequeñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.ContextMenuStrip = this.contextMenuStrip1;
			this.button1.Location = new System.Drawing.Point(39, 49);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 75);
			this.button1.TabIndex = 0;
			this.button1.Text = "CLIC DERECHO";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamañoToolStripMenuItem,
            this.colorToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
			// 
			// tamañoToolStripMenuItem
			// 
			this.tamañoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grandeToolStripMenuItem,
            this.pequeñoToolStripMenuItem});
			this.tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
			this.tamañoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.tamañoToolStripMenuItem.Text = "Tamaño";
			// 
			// grandeToolStripMenuItem
			// 
			this.grandeToolStripMenuItem.Name = "grandeToolStripMenuItem";
			this.grandeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.grandeToolStripMenuItem.Text = "Grande";
			this.grandeToolStripMenuItem.Click += new System.EventHandler(this.grandeToolStripMenuItem_Click);
			// 
			// pequeñoToolStripMenuItem
			// 
			this.pequeñoToolStripMenuItem.Name = "pequeñoToolStripMenuItem";
			this.pequeñoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pequeñoToolStripMenuItem.Text = "Pequeño";
			this.pequeñoToolStripMenuItem.Click += new System.EventHandler(this.pequeñoToolStripMenuItem_Click);
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fondoToolStripMenuItem,
            this.textoToolStripMenuItem});
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.colorToolStripMenuItem.Text = "Color";
			// 
			// fondoToolStripMenuItem
			// 
			this.fondoToolStripMenuItem.Name = "fondoToolStripMenuItem";
			this.fondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fondoToolStripMenuItem.Text = "Fondo";
			this.fondoToolStripMenuItem.Click += new System.EventHandler(this.fondoToolStripMenuItem_Click);
			// 
			// textoToolStripMenuItem
			// 
			this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
			this.textoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.textoToolStripMenuItem.Text = "Texto";
			this.textoToolStripMenuItem.Click += new System.EventHandler(this.textoToolStripMenuItem_Click);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(181, 48);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 379);
			this.ContextMenuStrip = this.contextMenuStrip2;
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Menu Contextual";
			this.contextMenuStrip1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tamañoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem grandeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pequeñoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fondoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
	}
}

