namespace CopyFilesToLocation
{
    partial class Form1
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
            this.GgetData = new System.Windows.Forms.Button();
            this.result_dataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.copy_button = new System.Windows.Forms.Button();
            this.vendor_richTextBox = new System.Windows.Forms.RichTextBox();
            this.copyFrom_textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyFrom_button = new System.Windows.Forms.Button();
            this.copyTo_button = new System.Windows.Forms.Button();
            this.copyTo_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulEu_radioButton = new System.Windows.Forms.RadioButton();
            this.ulNa_radioButton = new System.Windows.Forms.RadioButton();
            this.ulAar_radioButton = new System.Windows.Forms.RadioButton();
            this.zipFolders_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GgetData
            // 
            this.GgetData.Location = new System.Drawing.Point(1010, 47);
            this.GgetData.Name = "GgetData";
            this.GgetData.Size = new System.Drawing.Size(103, 23);
            this.GgetData.TabIndex = 0;
            this.GgetData.Text = "Pobierz dane";
            this.GgetData.UseVisualStyleBackColor = true;
            this.GgetData.Click += new System.EventHandler(this.GgetData_Click);
            // 
            // result_dataGridView
            // 
            this.result_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dataGridView.Location = new System.Drawing.Point(26, 447);
            this.result_dataGridView.Name = "result_dataGridView";
            this.result_dataGridView.Size = new System.Drawing.Size(963, 240);
            this.result_dataGridView.TabIndex = 1;
            // 
            // copy_button
            // 
            this.copy_button.Location = new System.Drawing.Point(1010, 97);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(103, 23);
            this.copy_button.TabIndex = 2;
            this.copy_button.Text = "Kopiuj";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // vendor_richTextBox
            // 
            this.vendor_richTextBox.Location = new System.Drawing.Point(26, 127);
            this.vendor_richTextBox.Name = "vendor_richTextBox";
            this.vendor_richTextBox.Size = new System.Drawing.Size(963, 305);
            this.vendor_richTextBox.TabIndex = 4;
            this.vendor_richTextBox.Text = "";
            // 
            // copyFrom_textBox
            // 
            this.copyFrom_textBox.Location = new System.Drawing.Point(278, 42);
            this.copyFrom_textBox.Name = "copyFrom_textBox";
            this.copyFrom_textBox.Size = new System.Drawing.Size(434, 20);
            this.copyFrom_textBox.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // copyFrom_button
            // 
            this.copyFrom_button.Location = new System.Drawing.Point(718, 39);
            this.copyFrom_button.Name = "copyFrom_button";
            this.copyFrom_button.Size = new System.Drawing.Size(75, 23);
            this.copyFrom_button.TabIndex = 7;
            this.copyFrom_button.Text = "Pobierz z";
            this.copyFrom_button.UseVisualStyleBackColor = true;
            this.copyFrom_button.Click += new System.EventHandler(this.copyFrom_button_Click);
            // 
            // copyTo_button
            // 
            this.copyTo_button.Location = new System.Drawing.Point(718, 65);
            this.copyTo_button.Name = "copyTo_button";
            this.copyTo_button.Size = new System.Drawing.Size(75, 23);
            this.copyTo_button.TabIndex = 9;
            this.copyTo_button.Text = "Kopiuj do";
            this.copyTo_button.UseVisualStyleBackColor = true;
            this.copyTo_button.Click += new System.EventHandler(this.copyTo_button_Click);
            // 
            // copyTo_TextBox
            // 
            this.copyTo_TextBox.Location = new System.Drawing.Point(278, 68);
            this.copyTo_TextBox.Name = "copyTo_TextBox";
            this.copyTo_TextBox.Size = new System.Drawing.Size(434, 20);
            this.copyTo_TextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pobierz z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kopiuj do";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bazaToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // bazaToolStripMenuItem
            // 
            this.bazaToolStripMenuItem.Name = "bazaToolStripMenuItem";
            this.bazaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.bazaToolStripMenuItem.Text = "Baza";
            this.bazaToolStripMenuItem.Click += new System.EventHandler(this.bazaToolStripMenuItem_Click);
            // 
            // ulEu_radioButton
            // 
            this.ulEu_radioButton.AutoSize = true;
            this.ulEu_radioButton.Location = new System.Drawing.Point(37, 39);
            this.ulEu_radioButton.Name = "ulEu_radioButton";
            this.ulEu_radioButton.Size = new System.Drawing.Size(57, 17);
            this.ulEu_radioButton.TabIndex = 13;
            this.ulEu_radioButton.TabStop = true;
            this.ulEu_radioButton.Text = "UL EU";
            this.ulEu_radioButton.UseVisualStyleBackColor = true;
            // 
            // ulNa_radioButton
            // 
            this.ulNa_radioButton.AutoSize = true;
            this.ulNa_radioButton.Location = new System.Drawing.Point(37, 62);
            this.ulNa_radioButton.Name = "ulNa_radioButton";
            this.ulNa_radioButton.Size = new System.Drawing.Size(57, 17);
            this.ulNa_radioButton.TabIndex = 14;
            this.ulNa_radioButton.TabStop = true;
            this.ulNa_radioButton.Text = "UL NA";
            this.ulNa_radioButton.UseVisualStyleBackColor = true;
            // 
            // ulAar_radioButton
            // 
            this.ulAar_radioButton.AutoSize = true;
            this.ulAar_radioButton.Location = new System.Drawing.Point(37, 85);
            this.ulAar_radioButton.Name = "ulAar_radioButton";
            this.ulAar_radioButton.Size = new System.Drawing.Size(64, 17);
            this.ulAar_radioButton.TabIndex = 15;
            this.ulAar_radioButton.TabStop = true;
            this.ulAar_radioButton.Text = "UL AAR";
            this.ulAar_radioButton.UseVisualStyleBackColor = true;
            // 
            // zipFolders_button
            // 
            this.zipFolders_button.Location = new System.Drawing.Point(1010, 137);
            this.zipFolders_button.Name = "zipFolders_button";
            this.zipFolders_button.Size = new System.Drawing.Size(103, 25);
            this.zipFolders_button.TabIndex = 16;
            this.zipFolders_button.Text = "Spakuj foldery";
            this.zipFolders_button.UseVisualStyleBackColor = true;
            this.zipFolders_button.Click += new System.EventHandler(this.zipFolders_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 699);
            this.Controls.Add(this.zipFolders_button);
            this.Controls.Add(this.ulAar_radioButton);
            this.Controls.Add(this.ulNa_radioButton);
            this.Controls.Add(this.ulEu_radioButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyTo_button);
            this.Controls.Add(this.copyTo_TextBox);
            this.Controls.Add(this.copyFrom_button);
            this.Controls.Add(this.copyFrom_textBox);
            this.Controls.Add(this.vendor_richTextBox);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.result_dataGridView);
            this.Controls.Add(this.GgetData);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GgetData;
        private System.Windows.Forms.DataGridView result_dataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.RichTextBox vendor_richTextBox;
        private System.Windows.Forms.TextBox copyFrom_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button copyFrom_button;
        private System.Windows.Forms.Button copyTo_button;
        private System.Windows.Forms.TextBox copyTo_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaToolStripMenuItem;
        private System.Windows.Forms.RadioButton ulEu_radioButton;
        private System.Windows.Forms.RadioButton ulNa_radioButton;
        private System.Windows.Forms.RadioButton ulAar_radioButton;
        private System.Windows.Forms.Button zipFolders_button;
    }
}

