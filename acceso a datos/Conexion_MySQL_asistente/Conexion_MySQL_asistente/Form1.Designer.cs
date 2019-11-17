namespace Conexion_MySQL_asistente
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
			System.Windows.Forms.Label id_contactosLabel;
			System.Windows.Forms.Label nombreLabel;
			System.Windows.Forms.Label apellidosLabel;
			System.Windows.Forms.Label telefonoLabel;
			System.Windows.Forms.Label direccionLabel;
			System.Windows.Forms.Label cpLabel;
			System.Windows.Forms.Label poblacionLabel;
			this.agendaDataSet = new Conexion_MySQL_asistente.agendaDataSet();
			this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contactosTableAdapter = new Conexion_MySQL_asistente.agendaDataSetTableAdapters.contactosTableAdapter();
			this.tableAdapterManager = new Conexion_MySQL_asistente.agendaDataSetTableAdapters.TableAdapterManager();
			this.contactosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.contactosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.contactosDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_contactosTextBox = new System.Windows.Forms.TextBox();
			this.nombreTextBox = new System.Windows.Forms.TextBox();
			this.apellidosTextBox = new System.Windows.Forms.TextBox();
			this.telefonoTextBox = new System.Windows.Forms.TextBox();
			this.direccionTextBox = new System.Windows.Forms.TextBox();
			this.cpTextBox = new System.Windows.Forms.TextBox();
			this.poblacionTextBox = new System.Windows.Forms.TextBox();
			id_contactosLabel = new System.Windows.Forms.Label();
			nombreLabel = new System.Windows.Forms.Label();
			apellidosLabel = new System.Windows.Forms.Label();
			telefonoLabel = new System.Windows.Forms.Label();
			direccionLabel = new System.Windows.Forms.Label();
			cpLabel = new System.Windows.Forms.Label();
			poblacionLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contactosBindingNavigator)).BeginInit();
			this.contactosBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contactosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// agendaDataSet
			// 
			this.agendaDataSet.DataSetName = "agendaDataSet";
			this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// contactosBindingSource
			// 
			this.contactosBindingSource.DataMember = "contactos";
			this.contactosBindingSource.DataSource = this.agendaDataSet;
			// 
			// contactosTableAdapter
			// 
			this.contactosTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.contactosTableAdapter = this.contactosTableAdapter;
			this.tableAdapterManager.UpdateOrder = Conexion_MySQL_asistente.agendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// contactosBindingNavigator
			// 
			this.contactosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.contactosBindingNavigator.BindingSource = this.contactosBindingSource;
			this.contactosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.contactosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.contactosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contactosBindingNavigatorSaveItem});
			this.contactosBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.contactosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.contactosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.contactosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.contactosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.contactosBindingNavigator.Name = "contactosBindingNavigator";
			this.contactosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.contactosBindingNavigator.Size = new System.Drawing.Size(808, 25);
			this.contactosBindingNavigator.TabIndex = 0;
			this.contactosBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Posición";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveLastItem.Text = "Mover último";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorDeleteItem.Text = "Eliminar";
			// 
			// contactosBindingNavigatorSaveItem
			// 
			this.contactosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.contactosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactosBindingNavigatorSaveItem.Image")));
			this.contactosBindingNavigatorSaveItem.Name = "contactosBindingNavigatorSaveItem";
			this.contactosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.contactosBindingNavigatorSaveItem.Text = "Guardar datos";
			this.contactosBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactosBindingNavigatorSaveItem_Click);
			// 
			// contactosDataGridView
			// 
			this.contactosDataGridView.AutoGenerateColumns = false;
			this.contactosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.contactosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.contactosDataGridView.DataSource = this.contactosBindingSource;
			this.contactosDataGridView.Location = new System.Drawing.Point(12, 40);
			this.contactosDataGridView.Name = "contactosDataGridView";
			this.contactosDataGridView.Size = new System.Drawing.Size(764, 140);
			this.contactosDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id_contactos";
			this.dataGridViewTextBoxColumn1.HeaderText = "id_contactos";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
			this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
			this.dataGridViewTextBoxColumn3.HeaderText = "apellidos";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
			this.dataGridViewTextBoxColumn4.HeaderText = "telefono";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "direccion";
			this.dataGridViewTextBoxColumn5.HeaderText = "direccion";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "cp";
			this.dataGridViewTextBoxColumn6.HeaderText = "cp";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "poblacion";
			this.dataGridViewTextBoxColumn7.HeaderText = "poblacion";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// id_contactosLabel
			// 
			id_contactosLabel.AutoSize = true;
			id_contactosLabel.Location = new System.Drawing.Point(61, 235);
			id_contactosLabel.Name = "id_contactosLabel";
			id_contactosLabel.Size = new System.Drawing.Size(68, 13);
			id_contactosLabel.TabIndex = 2;
			id_contactosLabel.Text = "id contactos:";
			// 
			// id_contactosTextBox
			// 
			this.id_contactosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "id_contactos", true));
			this.id_contactosTextBox.Location = new System.Drawing.Point(135, 232);
			this.id_contactosTextBox.Name = "id_contactosTextBox";
			this.id_contactosTextBox.Size = new System.Drawing.Size(100, 20);
			this.id_contactosTextBox.TabIndex = 3;
			// 
			// nombreLabel
			// 
			nombreLabel.AutoSize = true;
			nombreLabel.Location = new System.Drawing.Point(61, 261);
			nombreLabel.Name = "nombreLabel";
			nombreLabel.Size = new System.Drawing.Size(45, 13);
			nombreLabel.TabIndex = 4;
			nombreLabel.Text = "nombre:";
			// 
			// nombreTextBox
			// 
			this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "nombre", true));
			this.nombreTextBox.Location = new System.Drawing.Point(135, 258);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
			this.nombreTextBox.TabIndex = 5;
			// 
			// apellidosLabel
			// 
			apellidosLabel.AutoSize = true;
			apellidosLabel.Location = new System.Drawing.Point(61, 287);
			apellidosLabel.Name = "apellidosLabel";
			apellidosLabel.Size = new System.Drawing.Size(51, 13);
			apellidosLabel.TabIndex = 6;
			apellidosLabel.Text = "apellidos:";
			// 
			// apellidosTextBox
			// 
			this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "apellidos", true));
			this.apellidosTextBox.Location = new System.Drawing.Point(135, 284);
			this.apellidosTextBox.Name = "apellidosTextBox";
			this.apellidosTextBox.Size = new System.Drawing.Size(100, 20);
			this.apellidosTextBox.TabIndex = 7;
			// 
			// telefonoLabel
			// 
			telefonoLabel.AutoSize = true;
			telefonoLabel.Location = new System.Drawing.Point(61, 313);
			telefonoLabel.Name = "telefonoLabel";
			telefonoLabel.Size = new System.Drawing.Size(48, 13);
			telefonoLabel.TabIndex = 8;
			telefonoLabel.Text = "telefono:";
			// 
			// telefonoTextBox
			// 
			this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "telefono", true));
			this.telefonoTextBox.Location = new System.Drawing.Point(135, 310);
			this.telefonoTextBox.Name = "telefonoTextBox";
			this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
			this.telefonoTextBox.TabIndex = 9;
			// 
			// direccionLabel
			// 
			direccionLabel.AutoSize = true;
			direccionLabel.Location = new System.Drawing.Point(61, 339);
			direccionLabel.Name = "direccionLabel";
			direccionLabel.Size = new System.Drawing.Size(53, 13);
			direccionLabel.TabIndex = 10;
			direccionLabel.Text = "direccion:";
			// 
			// direccionTextBox
			// 
			this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "direccion", true));
			this.direccionTextBox.Location = new System.Drawing.Point(135, 336);
			this.direccionTextBox.Name = "direccionTextBox";
			this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
			this.direccionTextBox.TabIndex = 11;
			// 
			// cpLabel
			// 
			cpLabel.AutoSize = true;
			cpLabel.Location = new System.Drawing.Point(61, 365);
			cpLabel.Name = "cpLabel";
			cpLabel.Size = new System.Drawing.Size(22, 13);
			cpLabel.TabIndex = 12;
			cpLabel.Text = "cp:";
			// 
			// cpTextBox
			// 
			this.cpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "cp", true));
			this.cpTextBox.Location = new System.Drawing.Point(135, 362);
			this.cpTextBox.Name = "cpTextBox";
			this.cpTextBox.Size = new System.Drawing.Size(100, 20);
			this.cpTextBox.TabIndex = 13;
			// 
			// poblacionLabel
			// 
			poblacionLabel.AutoSize = true;
			poblacionLabel.Location = new System.Drawing.Point(61, 391);
			poblacionLabel.Name = "poblacionLabel";
			poblacionLabel.Size = new System.Drawing.Size(56, 13);
			poblacionLabel.TabIndex = 14;
			poblacionLabel.Text = "poblacion:";
			// 
			// poblacionTextBox
			// 
			this.poblacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "poblacion", true));
			this.poblacionTextBox.Location = new System.Drawing.Point(135, 388);
			this.poblacionTextBox.Name = "poblacionTextBox";
			this.poblacionTextBox.Size = new System.Drawing.Size(100, 20);
			this.poblacionTextBox.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 479);
			this.Controls.Add(id_contactosLabel);
			this.Controls.Add(this.id_contactosTextBox);
			this.Controls.Add(nombreLabel);
			this.Controls.Add(this.nombreTextBox);
			this.Controls.Add(apellidosLabel);
			this.Controls.Add(this.apellidosTextBox);
			this.Controls.Add(telefonoLabel);
			this.Controls.Add(this.telefonoTextBox);
			this.Controls.Add(direccionLabel);
			this.Controls.Add(this.direccionTextBox);
			this.Controls.Add(cpLabel);
			this.Controls.Add(this.cpTextBox);
			this.Controls.Add(poblacionLabel);
			this.Controls.Add(this.poblacionTextBox);
			this.Controls.Add(this.contactosDataGridView);
			this.Controls.Add(this.contactosBindingNavigator);
			this.Name = "Form1";
			this.Text = "MySQL";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contactosBindingNavigator)).EndInit();
			this.contactosBindingNavigator.ResumeLayout(false);
			this.contactosBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.contactosDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private agendaDataSet agendaDataSet;
		private System.Windows.Forms.BindingSource contactosBindingSource;
		private agendaDataSetTableAdapters.contactosTableAdapter contactosTableAdapter;
		private agendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator contactosBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton contactosBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView contactosDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.TextBox id_contactosTextBox;
		private System.Windows.Forms.TextBox nombreTextBox;
		private System.Windows.Forms.TextBox apellidosTextBox;
		private System.Windows.Forms.TextBox telefonoTextBox;
		private System.Windows.Forms.TextBox direccionTextBox;
		private System.Windows.Forms.TextBox cpTextBox;
		private System.Windows.Forms.TextBox poblacionTextBox;
	}
}

