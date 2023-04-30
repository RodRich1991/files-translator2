namespace FilesTranslator
{
    partial class FilesTranslator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_ProjectPath = new System.Windows.Forms.Button();
            this.TxtB_ProjectPath = new System.Windows.Forms.TextBox();
            this.Lbl_ProjectPath = new System.Windows.Forms.Label();
            this.Btn_DictionaryPath = new System.Windows.Forms.Button();
            this.TxtB_DictionaryPath = new System.Windows.Forms.TextBox();
            this.Lbl_Dicionario = new System.Windows.Forms.Label();
            this.Lbl_KeyColumn = new System.Windows.Forms.Label();
            this.Num_ColumnKey = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Lbl_ValueColumn = new System.Windows.Forms.Label();
            this.Lbl_FilePrefix = new System.Windows.Forms.Label();
            this.TxtB_FileSufix = new System.Windows.Forms.TextBox();
            this.TxtB_Regex = new System.Windows.Forms.TextBox();
            this.Lbl_Regex = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ColumnKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtB_Regex);
            this.groupBox1.Controls.Add(this.Lbl_Regex);
            this.groupBox1.Controls.Add(this.TxtB_FileSufix);
            this.groupBox1.Controls.Add(this.Lbl_FilePrefix);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.Lbl_ValueColumn);
            this.groupBox1.Controls.Add(this.Num_ColumnKey);
            this.groupBox1.Controls.Add(this.Lbl_KeyColumn);
            this.groupBox1.Controls.Add(this.Btn_ProjectPath);
            this.groupBox1.Controls.Add(this.TxtB_ProjectPath);
            this.groupBox1.Controls.Add(this.Lbl_ProjectPath);
            this.groupBox1.Controls.Add(this.Btn_DictionaryPath);
            this.groupBox1.Controls.Add(this.TxtB_DictionaryPath);
            this.groupBox1.Controls.Add(this.Lbl_Dicionario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Btn_ProjectPath
            // 
            this.Btn_ProjectPath.BackgroundImage = global::FilesTranslator.Properties.Resources.folder;
            this.Btn_ProjectPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ProjectPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ProjectPath.Location = new System.Drawing.Point(744, 80);
            this.Btn_ProjectPath.Name = "Btn_ProjectPath";
            this.Btn_ProjectPath.Size = new System.Drawing.Size(23, 23);
            this.Btn_ProjectPath.TabIndex = 5;
            this.Btn_ProjectPath.UseVisualStyleBackColor = true;
            // 
            // TxtB_ProjectPath
            // 
            this.TxtB_ProjectPath.Enabled = false;
            this.TxtB_ProjectPath.Location = new System.Drawing.Point(6, 81);
            this.TxtB_ProjectPath.Name = "TxtB_ProjectPath";
            this.TxtB_ProjectPath.Size = new System.Drawing.Size(732, 23);
            this.TxtB_ProjectPath.TabIndex = 4;
            // 
            // Lbl_ProjectPath
            // 
            this.Lbl_ProjectPath.AutoSize = true;
            this.Lbl_ProjectPath.Location = new System.Drawing.Point(6, 63);
            this.Lbl_ProjectPath.Name = "Lbl_ProjectPath";
            this.Lbl_ProjectPath.Size = new System.Drawing.Size(114, 15);
            this.Lbl_ProjectPath.TabIndex = 3;
            this.Lbl_ProjectPath.Text = "Caminho do Projeto";
            // 
            // Btn_DictionaryPath
            // 
            this.Btn_DictionaryPath.BackgroundImage = global::FilesTranslator.Properties.Resources.folder;
            this.Btn_DictionaryPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_DictionaryPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_DictionaryPath.Location = new System.Drawing.Point(744, 36);
            this.Btn_DictionaryPath.Name = "Btn_DictionaryPath";
            this.Btn_DictionaryPath.Size = new System.Drawing.Size(23, 23);
            this.Btn_DictionaryPath.TabIndex = 2;
            this.Btn_DictionaryPath.UseVisualStyleBackColor = true;
            // 
            // TxtB_DictionaryPath
            // 
            this.TxtB_DictionaryPath.Enabled = false;
            this.TxtB_DictionaryPath.Location = new System.Drawing.Point(6, 37);
            this.TxtB_DictionaryPath.Name = "TxtB_DictionaryPath";
            this.TxtB_DictionaryPath.Size = new System.Drawing.Size(732, 23);
            this.TxtB_DictionaryPath.TabIndex = 1;
            // 
            // Lbl_Dicionario
            // 
            this.Lbl_Dicionario.AutoSize = true;
            this.Lbl_Dicionario.Location = new System.Drawing.Point(6, 19);
            this.Lbl_Dicionario.Name = "Lbl_Dicionario";
            this.Lbl_Dicionario.Size = new System.Drawing.Size(130, 15);
            this.Lbl_Dicionario.TabIndex = 0;
            this.Lbl_Dicionario.Text = "Caminho do Dicionario";
            // 
            // Lbl_KeyColumn
            // 
            this.Lbl_KeyColumn.AutoSize = true;
            this.Lbl_KeyColumn.Location = new System.Drawing.Point(6, 107);
            this.Lbl_KeyColumn.Name = "Lbl_KeyColumn";
            this.Lbl_KeyColumn.Size = new System.Drawing.Size(97, 15);
            this.Lbl_KeyColumn.TabIndex = 6;
            this.Lbl_KeyColumn.Text = "Coluna da Chave";
            // 
            // Num_ColumnKey
            // 
            this.Num_ColumnKey.Location = new System.Drawing.Point(6, 125);
            this.Num_ColumnKey.Name = "Num_ColumnKey";
            this.Num_ColumnKey.Size = new System.Drawing.Size(120, 23);
            this.Num_ColumnKey.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 169);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 9;
            // 
            // Lbl_ValueColumn
            // 
            this.Lbl_ValueColumn.AutoSize = true;
            this.Lbl_ValueColumn.Location = new System.Drawing.Point(6, 151);
            this.Lbl_ValueColumn.Name = "Lbl_ValueColumn";
            this.Lbl_ValueColumn.Size = new System.Drawing.Size(112, 15);
            this.Lbl_ValueColumn.TabIndex = 8;
            this.Lbl_ValueColumn.Text = "Coluna da Tradução";
            this.Lbl_ValueColumn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_FilePrefix
            // 
            this.Lbl_FilePrefix.AutoSize = true;
            this.Lbl_FilePrefix.Location = new System.Drawing.Point(6, 195);
            this.Lbl_FilePrefix.Name = "Lbl_FilePrefix";
            this.Lbl_FilePrefix.Size = new System.Drawing.Size(149, 15);
            this.Lbl_FilePrefix.TabIndex = 10;
            this.Lbl_FilePrefix.Text = "Sufixo do Arquivo de Saída";
            // 
            // TxtB_FileSufix
            // 
            this.TxtB_FileSufix.Location = new System.Drawing.Point(6, 213);
            this.TxtB_FileSufix.Name = "TxtB_FileSufix";
            this.TxtB_FileSufix.Size = new System.Drawing.Size(149, 23);
            this.TxtB_FileSufix.TabIndex = 11;
            // 
            // TxtB_Regex
            // 
            this.TxtB_Regex.Location = new System.Drawing.Point(6, 257);
            this.TxtB_Regex.Name = "TxtB_Regex";
            this.TxtB_Regex.Size = new System.Drawing.Size(149, 23);
            this.TxtB_Regex.TabIndex = 13;
            // 
            // Lbl_Regex
            // 
            this.Lbl_Regex.AutoSize = true;
            this.Lbl_Regex.Location = new System.Drawing.Point(6, 239);
            this.Lbl_Regex.Name = "Lbl_Regex";
            this.Lbl_Regex.Size = new System.Drawing.Size(89, 15);
            this.Lbl_Regex.TabIndex = 12;
            this.Lbl_Regex.Text = "Regex de busca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ColumnKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Button Btn_ProjectPath;
        private TextBox TxtB_ProjectPath;
        private Label Lbl_ProjectPath;
        private Button Btn_DictionaryPath;
        private TextBox TxtB_DictionaryPath;
        private Label Lbl_Dicionario;
        private TextBox TxtB_Regex;
        private Label Lbl_Regex;
        private TextBox TxtB_FileSufix;
        private Label Lbl_FilePrefix;
        private NumericUpDown numericUpDown1;
        private Label Lbl_ValueColumn;
        private NumericUpDown Num_ColumnKey;
        private Label Lbl_KeyColumn;
    }
}