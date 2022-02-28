
namespace CBRadio
{
    partial class FoAblak
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
            this.sofornevKeresoSzovegmezo = new System.Windows.Forms.TextBox();
            this.sofornevKeresoCimke = new System.Windows.Forms.Label();
            this.adatrogzitesGroupBox = new System.Windows.Forms.GroupBox();
            this.keresesGroupBox = new System.Windows.Forms.GroupBox();
            this.keresesGomb = new System.Windows.Forms.Button();
            this.eredmenylistaListView = new System.Windows.Forms.ListView();
            this.adasIdejeCimke = new System.Windows.Forms.Label();
            this.adasidoSzovegmezo = new System.Windows.Forms.TextBox();
            this.soforNevUrlapCimke = new System.Windows.Forms.Label();
            this.sofornevComboBox = new System.Windows.Forms.ComboBox();
            this.adasszamCimke = new System.Windows.Forms.Label();
            this.adasszamLeptethetomezo = new System.Windows.Forms.NumericUpDown();
            this.mentesGomb = new System.Windows.Forms.Button();
            this.mentesFajlbaGomb = new System.Windows.Forms.Button();
            this.adatrogzitesGroupBox.SuspendLayout();
            this.keresesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adasszamLeptethetomezo)).BeginInit();
            this.SuspendLayout();
            // 
            // sofornevKeresoSzovegmezo
            // 
            this.sofornevKeresoSzovegmezo.Location = new System.Drawing.Point(151, 41);
            this.sofornevKeresoSzovegmezo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sofornevKeresoSzovegmezo.Name = "sofornevKeresoSzovegmezo";
            this.sofornevKeresoSzovegmezo.Size = new System.Drawing.Size(140, 22);
            this.sofornevKeresoSzovegmezo.TabIndex = 0;
            // 
            // sofornevKeresoCimke
            // 
            this.sofornevKeresoCimke.AutoSize = true;
            this.sofornevKeresoCimke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sofornevKeresoCimke.Location = new System.Drawing.Point(34, 44);
            this.sofornevKeresoCimke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sofornevKeresoCimke.Name = "sofornevKeresoCimke";
            this.sofornevKeresoCimke.Size = new System.Drawing.Size(70, 16);
            this.sofornevKeresoCimke.TabIndex = 1;
            this.sofornevKeresoCimke.Text = "Sofőrnév";
            // 
            // adatrogzitesGroupBox
            // 
            this.adatrogzitesGroupBox.Controls.Add(this.mentesFajlbaGomb);
            this.adatrogzitesGroupBox.Controls.Add(this.mentesGomb);
            this.adatrogzitesGroupBox.Controls.Add(this.adasszamLeptethetomezo);
            this.adatrogzitesGroupBox.Controls.Add(this.adasszamCimke);
            this.adatrogzitesGroupBox.Controls.Add(this.sofornevComboBox);
            this.adatrogzitesGroupBox.Controls.Add(this.soforNevUrlapCimke);
            this.adatrogzitesGroupBox.Controls.Add(this.adasidoSzovegmezo);
            this.adatrogzitesGroupBox.Controls.Add(this.adasIdejeCimke);
            this.adatrogzitesGroupBox.Location = new System.Drawing.Point(13, 13);
            this.adatrogzitesGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adatrogzitesGroupBox.Name = "adatrogzitesGroupBox";
            this.adatrogzitesGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adatrogzitesGroupBox.Size = new System.Drawing.Size(399, 377);
            this.adatrogzitesGroupBox.TabIndex = 2;
            this.adatrogzitesGroupBox.TabStop = false;
            this.adatrogzitesGroupBox.Text = "Adatrögzítés";
            // 
            // keresesGroupBox
            // 
            this.keresesGroupBox.Controls.Add(this.eredmenylistaListView);
            this.keresesGroupBox.Controls.Add(this.keresesGomb);
            this.keresesGroupBox.Controls.Add(this.sofornevKeresoCimke);
            this.keresesGroupBox.Controls.Add(this.sofornevKeresoSzovegmezo);
            this.keresesGroupBox.Location = new System.Drawing.Point(420, 13);
            this.keresesGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keresesGroupBox.Name = "keresesGroupBox";
            this.keresesGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keresesGroupBox.Size = new System.Drawing.Size(329, 377);
            this.keresesGroupBox.TabIndex = 3;
            this.keresesGroupBox.TabStop = false;
            this.keresesGroupBox.Text = "Keresés";
            // 
            // keresesGomb
            // 
            this.keresesGomb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.keresesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keresesGomb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.keresesGomb.Location = new System.Drawing.Point(124, 85);
            this.keresesGomb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keresesGomb.Name = "keresesGomb";
            this.keresesGomb.Size = new System.Drawing.Size(100, 34);
            this.keresesGomb.TabIndex = 2;
            this.keresesGomb.Text = "Keresés";
            this.keresesGomb.UseVisualStyleBackColor = false;
            // 
            // eredmenylistaListView
            // 
            this.eredmenylistaListView.HideSelection = false;
            this.eredmenylistaListView.Location = new System.Drawing.Point(37, 140);
            this.eredmenylistaListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eredmenylistaListView.Name = "eredmenylistaListView";
            this.eredmenylistaListView.Size = new System.Drawing.Size(254, 219);
            this.eredmenylistaListView.TabIndex = 3;
            this.eredmenylistaListView.UseCompatibleStateImageBehavior = false;
            // 
            // adasIdejeCimke
            // 
            this.adasIdejeCimke.AutoSize = true;
            this.adasIdejeCimke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adasIdejeCimke.Location = new System.Drawing.Point(36, 125);
            this.adasIdejeCimke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adasIdejeCimke.Name = "adasIdejeCimke";
            this.adasIdejeCimke.Size = new System.Drawing.Size(137, 16);
            this.adasIdejeCimke.TabIndex = 0;
            this.adasIdejeCimke.Text = "Adás ideje (óó:pp)";
            // 
            // adasidoSzovegmezo
            // 
            this.adasidoSzovegmezo.Location = new System.Drawing.Point(191, 122);
            this.adasidoSzovegmezo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adasidoSzovegmezo.MaxLength = 5;
            this.adasidoSzovegmezo.Name = "adasidoSzovegmezo";
            this.adasidoSzovegmezo.Size = new System.Drawing.Size(100, 22);
            this.adasidoSzovegmezo.TabIndex = 2;
            this.adasidoSzovegmezo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adasidoSzovegmezo.WordWrap = false;
            // 
            // soforNevUrlapCimke
            // 
            this.soforNevUrlapCimke.AutoSize = true;
            this.soforNevUrlapCimke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soforNevUrlapCimke.Location = new System.Drawing.Point(36, 57);
            this.soforNevUrlapCimke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soforNevUrlapCimke.Name = "soforNevUrlapCimke";
            this.soforNevUrlapCimke.Size = new System.Drawing.Size(83, 16);
            this.soforNevUrlapCimke.TabIndex = 0;
            this.soforNevUrlapCimke.Text = "Sofőr neve";
            // 
            // sofornevComboBox
            // 
            this.sofornevComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sofornevComboBox.FormattingEnabled = true;
            this.sofornevComboBox.Location = new System.Drawing.Point(191, 54);
            this.sofornevComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sofornevComboBox.MaxLength = 50;
            this.sofornevComboBox.Name = "sofornevComboBox";
            this.sofornevComboBox.Size = new System.Drawing.Size(160, 24);
            this.sofornevComboBox.TabIndex = 1;
            // 
            // adasszamCimke
            // 
            this.adasszamCimke.AutoSize = true;
            this.adasszamCimke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adasszamCimke.Location = new System.Drawing.Point(36, 196);
            this.adasszamCimke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adasszamCimke.Name = "adasszamCimke";
            this.adasszamCimke.Size = new System.Drawing.Size(110, 16);
            this.adasszamCimke.TabIndex = 0;
            this.adasszamCimke.Text = "Adások száma";
            // 
            // adasszamLeptethetomezo
            // 
            this.adasszamLeptethetomezo.Location = new System.Drawing.Point(191, 194);
            this.adasszamLeptethetomezo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adasszamLeptethetomezo.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.adasszamLeptethetomezo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.adasszamLeptethetomezo.Name = "adasszamLeptethetomezo";
            this.adasszamLeptethetomezo.Size = new System.Drawing.Size(100, 22);
            this.adasszamLeptethetomezo.TabIndex = 3;
            this.adasszamLeptethetomezo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.adasszamLeptethetomezo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mentesGomb
            // 
            this.mentesGomb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mentesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesGomb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mentesGomb.Location = new System.Drawing.Point(57, 282);
            this.mentesGomb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mentesGomb.Name = "mentesGomb";
            this.mentesGomb.Size = new System.Drawing.Size(100, 34);
            this.mentesGomb.TabIndex = 4;
            this.mentesGomb.Text = "Mentés";
            this.mentesGomb.UseVisualStyleBackColor = false;
            // 
            // mentesFajlbaGomb
            // 
            this.mentesFajlbaGomb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mentesFajlbaGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesFajlbaGomb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mentesFajlbaGomb.Location = new System.Drawing.Point(224, 282);
            this.mentesFajlbaGomb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mentesFajlbaGomb.Name = "mentesFajlbaGomb";
            this.mentesFajlbaGomb.Size = new System.Drawing.Size(120, 34);
            this.mentesFajlbaGomb.TabIndex = 5;
            this.mentesFajlbaGomb.Text = "Mentés fájlba";
            this.mentesFajlbaGomb.UseVisualStyleBackColor = false;
            // 
            // FoAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 404);
            this.Controls.Add(this.adatrogzitesGroupBox);
            this.Controls.Add(this.keresesGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FoAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CB rádió adatforgalom";
            this.Load += new System.EventHandler(this.FoAblak_Load);
            this.adatrogzitesGroupBox.ResumeLayout(false);
            this.adatrogzitesGroupBox.PerformLayout();
            this.keresesGroupBox.ResumeLayout(false);
            this.keresesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adasszamLeptethetomezo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sofornevKeresoSzovegmezo;
        private System.Windows.Forms.Label sofornevKeresoCimke;
        private System.Windows.Forms.GroupBox adatrogzitesGroupBox;
        private System.Windows.Forms.ComboBox sofornevComboBox;
        private System.Windows.Forms.Label soforNevUrlapCimke;
        private System.Windows.Forms.TextBox adasidoSzovegmezo;
        private System.Windows.Forms.Label adasIdejeCimke;
        private System.Windows.Forms.GroupBox keresesGroupBox;
        private System.Windows.Forms.ListView eredmenylistaListView;
        private System.Windows.Forms.Button keresesGomb;
        private System.Windows.Forms.Button mentesFajlbaGomb;
        private System.Windows.Forms.Button mentesGomb;
        private System.Windows.Forms.NumericUpDown adasszamLeptethetomezo;
        private System.Windows.Forms.Label adasszamCimke;
    }
}

