namespace RegistroAnalisis.UI.Registro
{
    partial class rAnalisis
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
            this.components = new System.ComponentModel.Container();
            this.UsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoAnalisiscomboBox = new System.Windows.Forms.ComboBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarTiposAnalisisButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariocomboBox
            // 
            this.UsuariocomboBox.FormattingEnabled = true;
            this.UsuariocomboBox.Location = new System.Drawing.Point(88, 94);
            this.UsuariocomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsuariocomboBox.Name = "UsuariocomboBox";
            this.UsuariocomboBox.Size = new System.Drawing.Size(136, 21);
            this.UsuariocomboBox.TabIndex = 22;
            // 
            // EliminarButton
            // 
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.Location = new System.Drawing.Point(260, 389);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(56, 50);
            this.EliminarButton.TabIndex = 21;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(248, 13);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(68, 34);
            this.BuscarButton.TabIndex = 16;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.Location = new System.Drawing.Point(146, 389);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(56, 50);
            this.GuardarButton.TabIndex = 20;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.Location = new System.Drawing.Point(38, 389);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(56, 50);
            this.NuevoButton.TabIndex = 19;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(88, 61);
            this.FechadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.FechadateTimePicker.TabIndex = 18;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(88, 22);
            this.IdnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.IdnumericUpDown.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // TipoAnalisiscomboBox
            // 
            this.TipoAnalisiscomboBox.FormattingEnabled = true;
            this.TipoAnalisiscomboBox.Location = new System.Drawing.Point(36, 168);
            this.TipoAnalisiscomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TipoAnalisiscomboBox.Name = "TipoAnalisiscomboBox";
            this.TipoAnalisiscomboBox.Size = new System.Drawing.Size(102, 21);
            this.TipoAnalisiscomboBox.TabIndex = 0;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(292, 169);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(24, 20);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Analisis:";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(189, 169);
            this.ResultadotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(99, 20);
            this.ResultadotextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Resultado:";
            // 
            // detalleDataGridView
            // 
            this.detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDataGridView.Location = new System.Drawing.Point(36, 222);
            this.detalleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.detalleDataGridView.Name = "detalleDataGridView";
            this.detalleDataGridView.RowTemplate.Height = 24;
            this.detalleDataGridView.Size = new System.Drawing.Size(280, 119);
            this.detalleDataGridView.TabIndex = 6;
            // 
            // AgregarTiposAnalisisButton
            // 
            this.AgregarTiposAnalisisButton.Location = new System.Drawing.Point(146, 169);
            this.AgregarTiposAnalisisButton.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarTiposAnalisisButton.Name = "AgregarTiposAnalisisButton";
            this.AgregarTiposAnalisisButton.Size = new System.Drawing.Size(24, 20);
            this.AgregarTiposAnalisisButton.TabIndex = 8;
            this.AgregarTiposAnalisisButton.UseVisualStyleBackColor = true;
            this.AgregarTiposAnalisisButton.Click += new System.EventHandler(this.AgregarTiposAnalisisButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(36, 345);
            this.RemoverButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(24, 20);
            this.RemoverButton.TabIndex = 23;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.detalleDataGridView);
            this.Controls.Add(this.AgregarTiposAnalisisButton);
            this.Controls.Add(this.UsuariocomboBox);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.TipoAnalisiscomboBox);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rAnalisis";
            this.Text = "rAnalisis";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UsuariocomboBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TipoAnalisiscomboBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView detalleDataGridView;
        private System.Windows.Forms.Button AgregarTiposAnalisisButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}