namespace pizza_accesibilidad
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
			this.logo = new System.Windows.Forms.PictureBox();
			this.companyLabel = new System.Windows.Forms.Label();
			this.customerLabel = new System.Windows.Forms.Label();
			this.customerName = new System.Windows.Forms.TextBox();
			this.sizeOptions = new System.Windows.Forms.GroupBox();
			this.lagePizza = new System.Windows.Forms.RadioButton();
			this.smallPizza = new System.Windows.Forms.RadioButton();
			this.toppingsLabel = new System.Windows.Forms.Label();
			this.ingredientes = new System.Windows.Forms.CheckedListBox();
			this.order = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileCommands = new System.Windows.Forms.ToolStripMenuItem();
			this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.sizeOptions.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// logo
			// 
			this.logo.AccessibleDescription = "Porción de pizza";
			this.logo.AccessibleName = "Logotipo de la compañia";
			this.logo.Image = global::pizza_accesibilidad.Properties.Resources.pizza_de_pepperoni_comida_pan_y_pasta_pintado_por_blanca2004_9878312;
			this.logo.Location = new System.Drawing.Point(65, 52);
			this.logo.Margin = new System.Windows.Forms.Padding(4);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(145, 107);
			this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logo.TabIndex = 0;
			this.logo.TabStop = false;
			// 
			// companyLabel
			// 
			this.companyLabel.AccessibleDescription = "Nombre de la compañía";
			this.companyLabel.AccessibleName = "Nombre de la compañía";
			this.companyLabel.AutoSize = true;
			this.companyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.companyLabel.ForeColor = System.Drawing.Color.Yellow;
			this.companyLabel.Location = new System.Drawing.Point(283, 89);
			this.companyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.companyLabel.Name = "companyLabel";
			this.companyLabel.Size = new System.Drawing.Size(166, 29);
			this.companyLabel.TabIndex = 1;
			this.companyLabel.Text = "PIZZA BUENA";
			// 
			// customerLabel
			// 
			this.customerLabel.AccessibleDescription = "Etiqueta de nombre de cliente";
			this.customerLabel.AccessibleName = "Etiqueta de nombre de cliente";
			this.customerLabel.AutoSize = true;
			this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerLabel.Location = new System.Drawing.Point(88, 222);
			this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(60, 16);
			this.customerLabel.TabIndex = 2;
			this.customerLabel.Text = "&Nombre:";
			// 
			// customerName
			// 
			this.customerName.AccessibleDescription = "Nombre del cliente";
			this.customerName.AccessibleName = "Nombre del cliente ";
			this.customerName.Location = new System.Drawing.Point(159, 218);
			this.customerName.Margin = new System.Windows.Forms.Padding(4);
			this.customerName.Name = "customerName";
			this.customerName.Size = new System.Drawing.Size(132, 22);
			this.customerName.TabIndex = 3;
			// 
			// sizeOptions
			// 
			this.sizeOptions.AccessibleDescription = "Opciones de tamaño de pizza";
			this.sizeOptions.AccessibleName = "Opciones de tamaño de pizza";
			this.sizeOptions.Controls.Add(this.lagePizza);
			this.sizeOptions.Controls.Add(this.smallPizza);
			this.sizeOptions.Location = new System.Drawing.Point(91, 289);
			this.sizeOptions.Name = "sizeOptions";
			this.sizeOptions.Size = new System.Drawing.Size(200, 100);
			this.sizeOptions.TabIndex = 4;
			this.sizeOptions.TabStop = false;
			this.sizeOptions.Text = "Tamaño de la pizza";
			// 
			// lagePizza
			// 
			this.lagePizza.AccessibleDescription = "Pizza grande";
			this.lagePizza.AccessibleName = "Pizza grande";
			this.lagePizza.AutoSize = true;
			this.lagePizza.Location = new System.Drawing.Point(7, 49);
			this.lagePizza.Name = "lagePizza";
			this.lagePizza.Size = new System.Drawing.Size(112, 20);
			this.lagePizza.TabIndex = 1;
			this.lagePizza.TabStop = true;
			this.lagePizza.Text = "&Grande 10.00€";
			this.lagePizza.UseVisualStyleBackColor = true;
			// 
			// smallPizza
			// 
			this.smallPizza.AccessibleDescription = "Pizza pequeña";
			this.smallPizza.AccessibleName = "Pizza pequeña";
			this.smallPizza.AutoSize = true;
			this.smallPizza.Checked = true;
			this.smallPizza.Location = new System.Drawing.Point(7, 22);
			this.smallPizza.Name = "smallPizza";
			this.smallPizza.Size = new System.Drawing.Size(115, 20);
			this.smallPizza.TabIndex = 0;
			this.smallPizza.TabStop = true;
			this.smallPizza.Text = "&Pequeña 6.00€";
			this.smallPizza.UseVisualStyleBackColor = true;
			// 
			// toppingsLabel
			// 
			this.toppingsLabel.AccessibleDescription = "Etiqueta de ingredientes";
			this.toppingsLabel.AccessibleName = "Etiqueta de ingredientes";
			this.toppingsLabel.AutoSize = true;
			this.toppingsLabel.Location = new System.Drawing.Point(403, 222);
			this.toppingsLabel.Name = "toppingsLabel";
			this.toppingsLabel.Size = new System.Drawing.Size(183, 16);
			this.toppingsLabel.TabIndex = 5;
			this.toppingsLabel.Text = "&Ingredientes (0.75€ cada uno)";
			// 
			// ingredientes
			// 
			this.ingredientes.AccessibleDescription = "Ingredientes disponibles";
			this.ingredientes.AccessibleName = "Ingredientes disponibles";
			this.ingredientes.FormattingEnabled = true;
			this.ingredientes.Items.AddRange(new object[] {
            "Noelia Hernández Rodríguez",
            "Antonio José Guerrero Carrillo"});
			this.ingredientes.Location = new System.Drawing.Point(406, 289);
			this.ingredientes.Name = "ingredientes";
			this.ingredientes.Size = new System.Drawing.Size(209, 89);
			this.ingredientes.TabIndex = 6;
			// 
			// order
			// 
			this.order.AccessibleDescription = "Total del pedido";
			this.order.AccessibleName = "Total del pedido";
			this.order.Location = new System.Drawing.Point(226, 457);
			this.order.Name = "order";
			this.order.Size = new System.Drawing.Size(75, 23);
			this.order.TabIndex = 7;
			this.order.Text = "&Ordenar";
			this.order.UseVisualStyleBackColor = true;
			// 
			// cancel
			// 
			this.cancel.AccessibleDescription = "Cancelar el pedido";
			this.cancel.AccessibleName = "Cancelar el pedido";
			this.cancel.Location = new System.Drawing.Point(374, 457);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 8;
			this.cancel.Text = "&Cancelar";
			this.cancel.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCommands,
            this.exitApp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(696, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileCommands
			// 
			this.fileCommands.Name = "fileCommands";
			this.fileCommands.Size = new System.Drawing.Size(60, 20);
			this.fileCommands.Text = "&Archivo";
			// 
			// exitApp
			// 
			this.exitApp.Name = "exitApp";
			this.exitApp.Size = new System.Drawing.Size(41, 20);
			this.exitApp.Text = "&Salir";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// Form1
			// 
			this.AccessibleDescription = "Formulario de pedido";
			this.AccessibleName = "Formulario de pedido";
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 554);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.order);
			this.Controls.Add(this.ingredientes);
			this.Controls.Add(this.toppingsLabel);
			this.Controls.Add(this.sizeOptions);
			this.Controls.Add(this.customerName);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.companyLabel);
			this.Controls.Add(this.logo);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Formulario de pedidos de pizza - Patricia_Burgos";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.sizeOptions.ResumeLayout(false);
			this.sizeOptions.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logo;
		private System.Windows.Forms.Label companyLabel;
		private System.Windows.Forms.Label customerLabel;
		private System.Windows.Forms.TextBox customerName;
		private System.Windows.Forms.GroupBox sizeOptions;
		private System.Windows.Forms.RadioButton lagePizza;
		private System.Windows.Forms.RadioButton smallPizza;
		private System.Windows.Forms.Label toppingsLabel;
		private System.Windows.Forms.CheckedListBox ingredientes;
		private System.Windows.Forms.Button order;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileCommands;
		private System.Windows.Forms.ToolStripMenuItem exitApp;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}

