namespace Cotizaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proyecto3DataSet = new Cotizaciones.Proyecto3DataSet();
            this.consultaCotizacionesGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaCotizacionesGeneralTableAdapter = new Cotizaciones.Proyecto3DataSetTableAdapters.ConsultaCotizacionesGeneralTableAdapter();
            this.tableAdapterManager = new Cotizaciones.Proyecto3DataSetTableAdapters.TableAdapterManager();
            this.tblCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCotizacionTableAdapter = new Cotizaciones.Proyecto3DataSetTableAdapters.tblCotizacionTableAdapter();
            this.tblProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductosTableAdapter = new Cotizaciones.Proyecto3DataSetTableAdapters.tblProductosTableAdapter();
            this.tblUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsuarioTableAdapter = new Cotizaciones.Proyecto3DataSetTableAdapters.tblUsuarioTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCotizacionesGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 385);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(128, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(219, 39);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 39);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cotizaciones.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // proyecto3DataSet
            // 
            this.proyecto3DataSet.DataSetName = "Proyecto3DataSet";
            this.proyecto3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaCotizacionesGeneralBindingSource
            // 
            this.consultaCotizacionesGeneralBindingSource.DataMember = "ConsultaCotizacionesGeneral";
            this.consultaCotizacionesGeneralBindingSource.DataSource = this.proyecto3DataSet;
            // 
            // consultaCotizacionesGeneralTableAdapter
            // 
            this.consultaCotizacionesGeneralTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCotizacionTableAdapter = this.tblCotizacionTableAdapter;
            this.tableAdapterManager.tblProductosTableAdapter = this.tblProductosTableAdapter;
            this.tableAdapterManager.tblUsuarioTableAdapter = this.tblUsuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cotizaciones.Proyecto3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCotizacionBindingSource
            // 
            this.tblCotizacionBindingSource.DataMember = "tblCotizacion";
            this.tblCotizacionBindingSource.DataSource = this.proyecto3DataSet;
            // 
            // tblCotizacionTableAdapter
            // 
            this.tblCotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductosBindingSource
            // 
            this.tblProductosBindingSource.DataMember = "tblProductos";
            this.tblProductosBindingSource.DataSource = this.proyecto3DataSet;
            // 
            // tblProductosTableAdapter
            // 
            this.tblProductosTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsuarioBindingSource
            // 
            this.tblUsuarioBindingSource.DataMember = "tblUsuario";
            this.tblUsuarioBindingSource.DataSource = this.proyecto3DataSet;
            // 
            // tblUsuarioTableAdapter
            // 
            this.tblUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 387);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCotizacionesGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Proyecto3DataSet proyecto3DataSet;
        private System.Windows.Forms.BindingSource consultaCotizacionesGeneralBindingSource;
        private Proyecto3DataSetTableAdapters.ConsultaCotizacionesGeneralTableAdapter consultaCotizacionesGeneralTableAdapter;
        private Proyecto3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Proyecto3DataSetTableAdapters.tblCotizacionTableAdapter tblCotizacionTableAdapter;
        private System.Windows.Forms.BindingSource tblCotizacionBindingSource;
        private Proyecto3DataSetTableAdapters.tblProductosTableAdapter tblProductosTableAdapter;
        private System.Windows.Forms.BindingSource tblProductosBindingSource;
        private Proyecto3DataSetTableAdapters.tblUsuarioTableAdapter tblUsuarioTableAdapter;
        private System.Windows.Forms.BindingSource tblUsuarioBindingSource;
    }
}

