namespace veri_tabanı_örnek_2_815
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
            this.dgwFilmler = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilmler
            // 
            this.dgwFilmler.AllowUserToAddRows = false;
            this.dgwFilmler.AllowUserToDeleteRows = false;
            this.dgwFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmler.Location = new System.Drawing.Point(10, 204);
            this.dgwFilmler.Name = "dgwFilmler";
            this.dgwFilmler.ReadOnly = true;
            this.dgwFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFilmler.Size = new System.Drawing.Size(729, 234);
            this.dgwFilmler.TabIndex = 0;
            this.dgwFilmler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFilmler_CellEnter);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(97, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(97, 93);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 2;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(97, 119);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(100, 20);
            this.txtSure.TabIndex = 3;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(97, 67);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(100, 20);
            this.txtYonetmen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "film ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "film yıl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "film yönetmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "film süre";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuncelle.Image = global::veri_tabanı_örnek_2_815.Properties.Resources._006_refresh_1;
            this.btnGuncelle.Location = new System.Drawing.Point(273, 39);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 48);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dgwFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmler;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

