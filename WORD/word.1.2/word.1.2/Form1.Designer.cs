namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_Cerca = new System.Windows.Forms.TextBox();
            this.lb_trova = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_sostituisci = new System.Windows.Forms.Label();
            this.txt_sostituisci = new System.Windows.Forms.TextBox();
            this.lb_parole = new System.Windows.Forms.Label();
            this.lb_caratteri = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.Importa_file = new System.Windows.Forms.ToolStripButton();
            this.btn_salva = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 377);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txt_Cerca
            // 
            this.txt_Cerca.Location = new System.Drawing.Point(574, 124);
            this.txt_Cerca.Name = "txt_Cerca";
            this.txt_Cerca.Size = new System.Drawing.Size(125, 20);
            this.txt_Cerca.TabIndex = 1;
            // 
            // lb_trova
            // 
            this.lb_trova.AutoSize = true;
            this.lb_trova.Location = new System.Drawing.Point(490, 127);
            this.lb_trova.Name = "lb_trova";
            this.lb_trova.Size = new System.Drawing.Size(44, 13);
            this.lb_trova.TabIndex = 2;
            this.lb_trova.Text = "TROVA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Conferma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTrova_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trova",
            "Trova e sostituisci"});
            this.comboBox1.Location = new System.Drawing.Point(477, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Svuota";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lb_sostituisci
            // 
            this.lb_sostituisci.AutoSize = true;
            this.lb_sostituisci.Location = new System.Drawing.Point(490, 158);
            this.lb_sostituisci.Name = "lb_sostituisci";
            this.lb_sostituisci.Size = new System.Drawing.Size(71, 13);
            this.lb_sostituisci.TabIndex = 6;
            this.lb_sostituisci.Text = "SOSTITUSCI";
            // 
            // txt_sostituisci
            // 
            this.txt_sostituisci.Location = new System.Drawing.Point(574, 155);
            this.txt_sostituisci.Name = "txt_sostituisci";
            this.txt_sostituisci.Size = new System.Drawing.Size(125, 20);
            this.txt_sostituisci.TabIndex = 7;
            // 
            // lb_parole
            // 
            this.lb_parole.AutoSize = true;
            this.lb_parole.Location = new System.Drawing.Point(309, 415);
            this.lb_parole.Name = "lb_parole";
            this.lb_parole.Size = new System.Drawing.Size(0, 13);
            this.lb_parole.TabIndex = 8;
            // 
            // lb_caratteri
            // 
            this.lb_caratteri.AutoSize = true;
            this.lb_caratteri.Location = new System.Drawing.Point(379, 415);
            this.lb_caratteri.Name = "lb_caratteri";
            this.lb_caratteri.Size = new System.Drawing.Size(0, 13);
            this.lb_caratteri.TabIndex = 9;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Importa_file,
            this.btn_salva});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(711, 25);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // Importa_file
            // 
            this.Importa_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Importa_file.Image = ((System.Drawing.Image)(resources.GetObject("Importa_file.Image")));
            this.Importa_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Importa_file.Name = "Importa_file";
            this.Importa_file.Size = new System.Drawing.Size(23, 22);
            this.Importa_file.Text = "Importa";
            this.Importa_file.ToolTipText = "importa";
            this.Importa_file.Click += new System.EventHandler(this.Importa_file_Click);
            // 
            // btn_salva
            // 
            this.btn_salva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salva.Image = ((System.Drawing.Image)(resources.GetObject("btn_salva.Image")));
            this.btn_salva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salva.Name = "btn_salva";
            this.btn_salva.Size = new System.Drawing.Size(23, 22);
            this.btn_salva.Text = "Salva";
            this.btn_salva.ToolTipText = "Salva con nome";
            this.btn_salva.Click += new System.EventHandler(this.salva_con_nome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.lb_caratteri);
            this.Controls.Add(this.lb_parole);
            this.Controls.Add(this.txt_sostituisci);
            this.Controls.Add(this.lb_sostituisci);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_trova);
            this.Controls.Add(this.txt_Cerca);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Blocco Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_Cerca;
        private System.Windows.Forms.Label lb_trova;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_sostituisci;
        private System.Windows.Forms.TextBox txt_sostituisci;
        private System.Windows.Forms.Label lb_parole;
        private System.Windows.Forms.Label lb_caratteri;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton Importa_file;
        private System.Windows.Forms.ToolStripButton btn_salva;
    }
}

