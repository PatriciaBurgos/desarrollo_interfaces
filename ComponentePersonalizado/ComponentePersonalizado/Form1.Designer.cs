namespace ComponentePersonalizado
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
			this.userControl11 = new ComponenteButton.UserControl1();
			this.SuspendLayout();
			// 
			// userControl11
			// 
			this.userControl11.Location = new System.Drawing.Point(65, 28);
			this.userControl11.Name = "userControl11";
			this.userControl11.Size = new System.Drawing.Size(120, 136);
			this.userControl11.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 199);
			this.Controls.Add(this.userControl11);
			this.Name = "Form1";
			this.Text = "Componente Personalizado";
			this.ResumeLayout(false);

		}

		#endregion

		private ComponenteButton.UserControl1 userControl11;
	}
}

