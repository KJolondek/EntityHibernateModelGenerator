namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Entity = new System.Windows.Forms.TabPage();
            this.NHibernate = new System.Windows.Forms.TabPage();
            this.textArea2 = new System.Windows.Forms.RichTextBox();
            this.Model = new System.Windows.Forms.TabPage();
            this.textArea3 = new System.Windows.Forms.RichTextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Tabs.SuspendLayout();
            this.Entity.SuspendLayout();
            this.NHibernate.SuspendLayout();
            this.Model.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(13, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 590);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgridv_RowStateChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(393, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 616);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGenerateEntities_Click);
            // 
            // textArea
            // 
            this.textArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea.Location = new System.Drawing.Point(6, 6);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(696, 545);
            this.textArea.TabIndex = 3;
            this.textArea.Text = "";
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.Entity);
            this.Tabs.Controls.Add(this.NHibernate);
            this.Tabs.Controls.Add(this.Model);
            this.Tabs.Location = new System.Drawing.Point(460, 9);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(716, 587);
            this.Tabs.TabIndex = 4;
            // 
            // Entity
            // 
            this.Entity.Controls.Add(this.textArea);
            this.Entity.Location = new System.Drawing.Point(4, 22);
            this.Entity.Name = "Entity";
            this.Entity.Padding = new System.Windows.Forms.Padding(3);
            this.Entity.Size = new System.Drawing.Size(708, 561);
            this.Entity.TabIndex = 0;
            this.Entity.Text = "Entity";
            this.Entity.UseVisualStyleBackColor = true;
            // 
            // NHibernate
            // 
            this.NHibernate.Controls.Add(this.textArea2);
            this.NHibernate.Location = new System.Drawing.Point(4, 22);
            this.NHibernate.Name = "NHibernate";
            this.NHibernate.Padding = new System.Windows.Forms.Padding(3);
            this.NHibernate.Size = new System.Drawing.Size(708, 561);
            this.NHibernate.TabIndex = 1;
            this.NHibernate.Text = "NHibernate";
            this.NHibernate.UseVisualStyleBackColor = true;
            // 
            // textArea2
            // 
            this.textArea2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea2.Location = new System.Drawing.Point(6, 6);
            this.textArea2.Name = "textArea2";
            this.textArea2.Size = new System.Drawing.Size(696, 545);
            this.textArea2.TabIndex = 4;
            this.textArea2.Text = "";
            // 
            // Model
            // 
            this.Model.Controls.Add(this.textArea3);
            this.Model.Location = new System.Drawing.Point(4, 22);
            this.Model.Name = "Model";
            this.Model.Padding = new System.Windows.Forms.Padding(3);
            this.Model.Size = new System.Drawing.Size(708, 561);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model";
            this.Model.UseVisualStyleBackColor = true;
            // 
            // textArea3
            // 
            this.textArea3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea3.Location = new System.Drawing.Point(6, 6);
            this.textArea3.Name = "textArea3";
            this.textArea3.Size = new System.Drawing.Size(696, 549);
            this.textArea3.TabIndex = 5;
            this.textArea3.Text = "";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(460, 602);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(712, 23);
            this.btnCopyToClipboard.TabIndex = 5;
            this.btnCopyToClipboard.Text = "Copy to Clipboard This Tab Content";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Class Name";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(82, 9);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(305, 20);
            this.className.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 640);
            this.Controls.Add(this.className);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ENhM Code Generator         ..: By: Keny Jolondek :..";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.Entity.ResumeLayout(false);
            this.NHibernate.ResumeLayout(false);
            this.Model.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Entity;
        private System.Windows.Forms.TabPage NHibernate;
        private System.Windows.Forms.RichTextBox textArea2;
        private System.Windows.Forms.TabPage Model;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.RichTextBox textArea3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox className;
    }
}

