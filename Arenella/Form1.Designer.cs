namespace Arenella
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titoloLabel = new System.Windows.Forms.Label();
            this.bolletteLabel = new System.Windows.Forms.Label();
            this.pulizieLabel = new System.Windows.Forms.Label();
            this.giardiniere = new System.Windows.Forms.Label();
            this.manutenzioneLabel = new System.Windows.Forms.Label();
            this.bolletteUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pulizieUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.giardiniereUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.manutenzioneUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.incassoNettoUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.calcolaButton = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.Label();
            this.incassoNettoLabel = new System.Windows.Forms.Label();
            this.nottiPrenotateLabel = new System.Windows.Forms.Label();
            this.bookinTotaliLabel = new System.Windows.Forms.Label();
            this.nottiPrenotateUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.bookingTotaliUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.piscinaLabel = new System.Windows.Forms.Label();
            this.piscinaUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.esportaButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.itaButton = new System.Windows.Forms.Button();
            this.engButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bolletteUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulizieUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giardiniereUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutenzioneUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incassoNettoUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nottiPrenotateUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTotaliUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piscinaUpDown9)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 294);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(559, 222);
            this.textBox1.TabIndex = 0;
            // 
            // titoloLabel
            // 
            this.titoloLabel.AutoSize = true;
            this.titoloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.titoloLabel.Location = new System.Drawing.Point(212, 13);
            this.titoloLabel.Name = "titoloLabel";
            this.titoloLabel.Size = new System.Drawing.Size(156, 17);
            this.titoloLabel.TabIndex = 1;
            this.titoloLabel.Text = "Rate Calculator v1.1";
            // 
            // bolletteLabel
            // 
            this.bolletteLabel.AutoSize = true;
            this.bolletteLabel.Location = new System.Drawing.Point(23, 70);
            this.bolletteLabel.Name = "bolletteLabel";
            this.bolletteLabel.Size = new System.Drawing.Size(42, 13);
            this.bolletteLabel.TabIndex = 2;
            this.bolletteLabel.Text = "Bollette";
            // 
            // pulizieLabel
            // 
            this.pulizieLabel.AutoSize = true;
            this.pulizieLabel.Location = new System.Drawing.Point(23, 98);
            this.pulizieLabel.Name = "pulizieLabel";
            this.pulizieLabel.Size = new System.Drawing.Size(37, 13);
            this.pulizieLabel.TabIndex = 3;
            this.pulizieLabel.Text = "Pulizie";
            // 
            // giardiniere
            // 
            this.giardiniere.AutoSize = true;
            this.giardiniere.Location = new System.Drawing.Point(23, 128);
            this.giardiniere.Name = "giardiniere";
            this.giardiniere.Size = new System.Drawing.Size(57, 13);
            this.giardiniere.TabIndex = 4;
            this.giardiniere.Text = "Giardiniere";
            // 
            // manutenzioneLabel
            // 
            this.manutenzioneLabel.AutoSize = true;
            this.manutenzioneLabel.Location = new System.Drawing.Point(23, 159);
            this.manutenzioneLabel.Name = "manutenzioneLabel";
            this.manutenzioneLabel.Size = new System.Drawing.Size(74, 13);
            this.manutenzioneLabel.TabIndex = 5;
            this.manutenzioneLabel.Text = "Manutenzione";
            // 
            // bolletteUpDown1
            // 
            this.bolletteUpDown1.Location = new System.Drawing.Point(111, 68);
            this.bolletteUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bolletteUpDown1.Name = "bolletteUpDown1";
            this.bolletteUpDown1.Size = new System.Drawing.Size(83, 20);
            this.bolletteUpDown1.TabIndex = 6;
            this.bolletteUpDown1.ThousandsSeparator = true;
            this.bolletteUpDown1.ValueChanged += new System.EventHandler(this.bolletteUpDown1_ValueChanged);
            // 
            // pulizieUpDown2
            // 
            this.pulizieUpDown2.Location = new System.Drawing.Point(111, 96);
            this.pulizieUpDown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.pulizieUpDown2.Name = "pulizieUpDown2";
            this.pulizieUpDown2.Size = new System.Drawing.Size(83, 20);
            this.pulizieUpDown2.TabIndex = 7;
            this.pulizieUpDown2.ThousandsSeparator = true;
            this.pulizieUpDown2.ValueChanged += new System.EventHandler(this.pulizieUpDown2_ValueChanged);
            // 
            // giardiniereUpDown3
            // 
            this.giardiniereUpDown3.Location = new System.Drawing.Point(111, 126);
            this.giardiniereUpDown3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.giardiniereUpDown3.Name = "giardiniereUpDown3";
            this.giardiniereUpDown3.Size = new System.Drawing.Size(83, 20);
            this.giardiniereUpDown3.TabIndex = 8;
            this.giardiniereUpDown3.ThousandsSeparator = true;
            this.giardiniereUpDown3.ValueChanged += new System.EventHandler(this.giardiniereUpDown3_ValueChanged);
            // 
            // manutenzioneUpDown4
            // 
            this.manutenzioneUpDown4.Location = new System.Drawing.Point(111, 157);
            this.manutenzioneUpDown4.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.manutenzioneUpDown4.Name = "manutenzioneUpDown4";
            this.manutenzioneUpDown4.Size = new System.Drawing.Size(83, 20);
            this.manutenzioneUpDown4.TabIndex = 9;
            this.manutenzioneUpDown4.ThousandsSeparator = true;
            this.manutenzioneUpDown4.ValueChanged += new System.EventHandler(this.manutenzioneUpDown4_ValueChanged);
            // 
            // incassoNettoUpDown5
            // 
            this.incassoNettoUpDown5.Location = new System.Drawing.Point(445, 68);
            this.incassoNettoUpDown5.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.incassoNettoUpDown5.Name = "incassoNettoUpDown5";
            this.incassoNettoUpDown5.Size = new System.Drawing.Size(83, 20);
            this.incassoNettoUpDown5.TabIndex = 11;
            this.incassoNettoUpDown5.ThousandsSeparator = true;
            // 
            // calcolaButton
            // 
            this.calcolaButton.Enabled = false;
            this.calcolaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcolaButton.Location = new System.Drawing.Point(446, 242);
            this.calcolaButton.Name = "calcolaButton";
            this.calcolaButton.Size = new System.Drawing.Size(82, 35);
            this.calcolaButton.TabIndex = 15;
            this.calcolaButton.Text = "Calcola";
            this.calcolaButton.UseVisualStyleBackColor = true;
            this.calcolaButton.Click += new System.EventHandler(this.calcolaButton_Click);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(16, 278);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(42, 13);
            this.reportLabel.TabIndex = 10;
            this.reportLabel.Text = "Report:";
            // 
            // incassoNettoLabel
            // 
            this.incassoNettoLabel.AutoSize = true;
            this.incassoNettoLabel.Location = new System.Drawing.Point(314, 70);
            this.incassoNettoLabel.Name = "incassoNettoLabel";
            this.incassoNettoLabel.Size = new System.Drawing.Size(71, 13);
            this.incassoNettoLabel.TabIndex = 12;
            this.incassoNettoLabel.Text = "Incasso netto";
            // 
            // nottiPrenotateLabel
            // 
            this.nottiPrenotateLabel.AutoSize = true;
            this.nottiPrenotateLabel.Location = new System.Drawing.Point(314, 128);
            this.nottiPrenotateLabel.Name = "nottiPrenotateLabel";
            this.nottiPrenotateLabel.Size = new System.Drawing.Size(98, 13);
            this.nottiPrenotateLabel.TabIndex = 14;
            this.nottiPrenotateLabel.Text = "Notti prenotate (tot)";
            // 
            // bookinTotaliLabel
            // 
            this.bookinTotaliLabel.AutoSize = true;
            this.bookinTotaliLabel.Location = new System.Drawing.Point(314, 98);
            this.bookinTotaliLabel.Name = "bookinTotaliLabel";
            this.bookinTotaliLabel.Size = new System.Drawing.Size(104, 13);
            this.bookinTotaliLabel.TabIndex = 15;
            this.bookinTotaliLabel.Text = "Booking ricevuti (tot)";
            // 
            // nottiPrenotateUpDown6
            // 
            this.nottiPrenotateUpDown6.Location = new System.Drawing.Point(446, 126);
            this.nottiPrenotateUpDown6.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nottiPrenotateUpDown6.Name = "nottiPrenotateUpDown6";
            this.nottiPrenotateUpDown6.Size = new System.Drawing.Size(83, 20);
            this.nottiPrenotateUpDown6.TabIndex = 13;
            this.nottiPrenotateUpDown6.ThousandsSeparator = true;
            this.nottiPrenotateUpDown6.ValueChanged += new System.EventHandler(this.nottiPrenotateUpDown6_ValueChanged);
            // 
            // bookingTotaliUpDown7
            // 
            this.bookingTotaliUpDown7.Location = new System.Drawing.Point(445, 96);
            this.bookingTotaliUpDown7.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.bookingTotaliUpDown7.Name = "bookingTotaliUpDown7";
            this.bookingTotaliUpDown7.Size = new System.Drawing.Size(83, 20);
            this.bookingTotaliUpDown7.TabIndex = 12;
            this.bookingTotaliUpDown7.ThousandsSeparator = true;
            this.bookingTotaliUpDown7.ValueChanged += new System.EventHandler(this.bookingTotaliUpDown7_ValueChanged);
            // 
            // piscinaLabel
            // 
            this.piscinaLabel.AutoSize = true;
            this.piscinaLabel.Location = new System.Drawing.Point(23, 189);
            this.piscinaLabel.Name = "piscinaLabel";
            this.piscinaLabel.Size = new System.Drawing.Size(41, 13);
            this.piscinaLabel.TabIndex = 20;
            this.piscinaLabel.Text = "Piscina";
            // 
            // piscinaUpDown9
            // 
            this.piscinaUpDown9.Location = new System.Drawing.Point(111, 189);
            this.piscinaUpDown9.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.piscinaUpDown9.Name = "piscinaUpDown9";
            this.piscinaUpDown9.Size = new System.Drawing.Size(83, 20);
            this.piscinaUpDown9.TabIndex = 10;
            this.piscinaUpDown9.ThousandsSeparator = true;
            this.piscinaUpDown9.ValueChanged += new System.EventHandler(this.piscinaUpDown9_ValueChanged);
            // 
            // esportaButton
            // 
            this.esportaButton.Enabled = false;
            this.esportaButton.Location = new System.Drawing.Point(445, 213);
            this.esportaButton.Name = "esportaButton";
            this.esportaButton.Size = new System.Drawing.Size(83, 23);
            this.esportaButton.TabIndex = 22;
            this.esportaButton.Text = "Esporta (.txt)";
            this.esportaButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(26, 249);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pictureLabel
            // 
            this.pictureLabel.Image = ((System.Drawing.Image)(resources.GetObject("pictureLabel.Image")));
            this.pictureLabel.Location = new System.Drawing.Point(220, 189);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(165, 93);
            this.pictureLabel.TabIndex = 24;
            // 
            // itaButton
            // 
            this.itaButton.Enabled = false;
            this.itaButton.Location = new System.Drawing.Point(458, 13);
            this.itaButton.Name = "itaButton";
            this.itaButton.Size = new System.Drawing.Size(37, 23);
            this.itaButton.TabIndex = 25;
            this.itaButton.Text = "Ita";
            this.itaButton.UseVisualStyleBackColor = true;
            this.itaButton.Click += new System.EventHandler(this.itaButton_Click);
            // 
            // engButton
            // 
            this.engButton.Location = new System.Drawing.Point(492, 13);
            this.engButton.Name = "engButton";
            this.engButton.Size = new System.Drawing.Size(37, 23);
            this.engButton.TabIndex = 26;
            this.engButton.Text = "Eng";
            this.engButton.UseVisualStyleBackColor = true;
            this.engButton.Click += new System.EventHandler(this.engButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 528);
            this.Controls.Add(this.engButton);
            this.Controls.Add(this.itaButton);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.esportaButton);
            this.Controls.Add(this.piscinaUpDown9);
            this.Controls.Add(this.piscinaLabel);
            this.Controls.Add(this.bookingTotaliUpDown7);
            this.Controls.Add(this.nottiPrenotateUpDown6);
            this.Controls.Add(this.bookinTotaliLabel);
            this.Controls.Add(this.nottiPrenotateLabel);
            this.Controls.Add(this.incassoNettoUpDown5);
            this.Controls.Add(this.incassoNettoLabel);
            this.Controls.Add(this.manutenzioneUpDown4);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.giardiniereUpDown3);
            this.Controls.Add(this.calcolaButton);
            this.Controls.Add(this.pulizieUpDown2);
            this.Controls.Add(this.bolletteUpDown1);
            this.Controls.Add(this.manutenzioneLabel);
            this.Controls.Add(this.giardiniere);
            this.Controls.Add(this.pulizieLabel);
            this.Controls.Add(this.bolletteLabel);
            this.Controls.Add(this.titoloLabel);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "House Arenella Rate Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.bolletteUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulizieUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giardiniereUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutenzioneUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incassoNettoUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nottiPrenotateUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTotaliUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piscinaUpDown9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titoloLabel;
        private System.Windows.Forms.Label bolletteLabel;
        private System.Windows.Forms.Label pulizieLabel;
        private System.Windows.Forms.Label giardiniere;
        private System.Windows.Forms.Label manutenzioneLabel;
        private System.Windows.Forms.NumericUpDown bolletteUpDown1;
        private System.Windows.Forms.NumericUpDown pulizieUpDown2;
        private System.Windows.Forms.NumericUpDown giardiniereUpDown3;
        private System.Windows.Forms.NumericUpDown manutenzioneUpDown4;
        private System.Windows.Forms.NumericUpDown incassoNettoUpDown5;
        private System.Windows.Forms.NumericUpDown nottiPrenotateUpDown6;
        private System.Windows.Forms.NumericUpDown bookingTotaliUpDown7;
        private System.Windows.Forms.NumericUpDown piscinaUpDown9;
        private System.Windows.Forms.Button calcolaButton;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Label incassoNettoLabel;
        private System.Windows.Forms.Label nottiPrenotateLabel;
        private System.Windows.Forms.Label bookinTotaliLabel;
        private System.Windows.Forms.Label piscinaLabel;
        private System.Windows.Forms.Button esportaButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Button itaButton;
        private System.Windows.Forms.Button engButton;
    }
}

