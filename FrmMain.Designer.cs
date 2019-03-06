namespace DokumanSiniflandirma
{
    partial class FrmMain
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewBasariOrani = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonKlasorSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTestOrani = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNGram = new System.Windows.Forms.ComboBox();
            this.buttonAnalizEt = new System.Windows.Forms.Button();
            this.dataGridViewAnaliz = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasariOrani)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnaliz)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewBasariOrani, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewAnaliz, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(2098, 1716);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dataGridViewBasariOrani
            // 
            this.dataGridViewBasariOrani.AllowUserToAddRows = false;
            this.dataGridViewBasariOrani.AllowUserToDeleteRows = false;
            this.dataGridViewBasariOrani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBasariOrani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBasariOrani.Location = new System.Drawing.Point(3, 1174);
            this.dataGridViewBasariOrani.Name = "dataGridViewBasariOrani";
            this.dataGridViewBasariOrani.ReadOnly = true;
            this.dataGridViewBasariOrani.RowTemplate.Height = 40;
            this.dataGridViewBasariOrani.Size = new System.Drawing.Size(2092, 539);
            this.dataGridViewBasariOrani.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.buttonKlasorSec);
            this.flowLayoutPanel.Controls.Add(this.label1);
            this.flowLayoutPanel.Controls.Add(this.comboBoxTestOrani);
            this.flowLayoutPanel.Controls.Add(this.label2);
            this.flowLayoutPanel.Controls.Add(this.comboBoxNGram);
            this.flowLayoutPanel.Controls.Add(this.buttonAnalizEt);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(2092, 75);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // buttonKlasorSec
            // 
            this.buttonKlasorSec.Location = new System.Drawing.Point(3, 3);
            this.buttonKlasorSec.Name = "buttonKlasorSec";
            this.buttonKlasorSec.Size = new System.Drawing.Size(218, 59);
            this.buttonKlasorSec.TabIndex = 7;
            this.buttonKlasorSec.Text = "KlasorSec";
            this.buttonKlasorSec.UseVisualStyleBackColor = true;
            this.buttonKlasorSec.Click += new System.EventHandler(this.buttonKlasorSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Data Oranı : ";
            // 
            // comboBoxTestOrani
            // 
            this.comboBoxTestOrani.FormattingEnabled = true;
            this.comboBoxTestOrani.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
            this.comboBoxTestOrani.Location = new System.Drawing.Point(469, 3);
            this.comboBoxTestOrani.Name = "comboBoxTestOrani";
            this.comboBoxTestOrani.Size = new System.Drawing.Size(238, 39);
            this.comboBoxTestOrani.TabIndex = 2;
            this.comboBoxTestOrani.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "N-Gram Değeri:";
            // 
            // comboBoxNGram
            // 
            this.comboBoxNGram.FormattingEnabled = true;
            this.comboBoxNGram.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNGram.Location = new System.Drawing.Point(932, 3);
            this.comboBoxNGram.Name = "comboBoxNGram";
            this.comboBoxNGram.Size = new System.Drawing.Size(238, 39);
            this.comboBoxNGram.TabIndex = 6;
            this.comboBoxNGram.Text = "5";
            // 
            // buttonAnalizEt
            // 
            this.buttonAnalizEt.Location = new System.Drawing.Point(1176, 3);
            this.buttonAnalizEt.Name = "buttonAnalizEt";
            this.buttonAnalizEt.Size = new System.Drawing.Size(235, 59);
            this.buttonAnalizEt.TabIndex = 4;
            this.buttonAnalizEt.Text = "AnalizEt";
            this.buttonAnalizEt.UseVisualStyleBackColor = true;
            this.buttonAnalizEt.Click += new System.EventHandler(this.buttonAnalizEt_Click);
            // 
            // dataGridViewAnaliz
            // 
            this.dataGridViewAnaliz.AllowUserToAddRows = false;
            this.dataGridViewAnaliz.AllowUserToDeleteRows = false;
            this.dataGridViewAnaliz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnaliz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAnaliz.Location = new System.Drawing.Point(3, 84);
            this.dataGridViewAnaliz.Name = "dataGridViewAnaliz";
            this.dataGridViewAnaliz.ReadOnly = true;
            this.dataGridViewAnaliz.RowTemplate.Height = 40;
            this.dataGridViewAnaliz.Size = new System.Drawing.Size(2092, 1084);
            this.dataGridViewAnaliz.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2098, 1716);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasariOrani)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnaliz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTestOrani;
        private System.Windows.Forms.Button buttonAnalizEt;
        private System.Windows.Forms.DataGridView dataGridViewAnaliz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNGram;
        private System.Windows.Forms.DataGridView dataGridViewBasariOrani;
        private System.Windows.Forms.Button buttonKlasorSec;
    }
}

