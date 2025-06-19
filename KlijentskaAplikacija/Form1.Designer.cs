namespace KlijentskaAplikacija
{
    partial class Forma
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
            label1 = new Label();
            textBoxSlovo1 = new TextBox();
            textBoxSlovo2 = new TextBox();
            textBoxSlovo3 = new TextBox();
            textBoxSlovo4 = new TextBox();
            textBoxSlovo5 = new TextBox();
            label2 = new Label();
            textBoxSlovoPokusaj = new TextBox();
            buttonPokusaj = new Button();
            label3 = new Label();
            label4 = new Label();
            labelPrethodniPokusaji = new Label();
            labelPreostaliPokusaji = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 67);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 0;
            label1.Text = "Rec:";
            // 
            // textBoxSlovo1
            // 
            textBoxSlovo1.BorderStyle = BorderStyle.FixedSingle;
            textBoxSlovo1.CharacterCasing = CharacterCasing.Upper;
            textBoxSlovo1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSlovo1.Location = new Point(72, 106);
            textBoxSlovo1.Name = "textBoxSlovo1";
            textBoxSlovo1.ReadOnly = true;
            textBoxSlovo1.Size = new Size(44, 35);
            textBoxSlovo1.TabIndex = 1;
            // 
            // textBoxSlovo2
            // 
            textBoxSlovo2.BorderStyle = BorderStyle.FixedSingle;
            textBoxSlovo2.CharacterCasing = CharacterCasing.Upper;
            textBoxSlovo2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSlovo2.Location = new Point(140, 106);
            textBoxSlovo2.Name = "textBoxSlovo2";
            textBoxSlovo2.ReadOnly = true;
            textBoxSlovo2.Size = new Size(44, 35);
            textBoxSlovo2.TabIndex = 2;
            // 
            // textBoxSlovo3
            // 
            textBoxSlovo3.BorderStyle = BorderStyle.FixedSingle;
            textBoxSlovo3.CharacterCasing = CharacterCasing.Upper;
            textBoxSlovo3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSlovo3.Location = new Point(209, 106);
            textBoxSlovo3.Name = "textBoxSlovo3";
            textBoxSlovo3.ReadOnly = true;
            textBoxSlovo3.Size = new Size(44, 35);
            textBoxSlovo3.TabIndex = 3;
            // 
            // textBoxSlovo4
            // 
            textBoxSlovo4.BorderStyle = BorderStyle.FixedSingle;
            textBoxSlovo4.CharacterCasing = CharacterCasing.Upper;
            textBoxSlovo4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSlovo4.Location = new Point(274, 106);
            textBoxSlovo4.Name = "textBoxSlovo4";
            textBoxSlovo4.ReadOnly = true;
            textBoxSlovo4.Size = new Size(44, 35);
            textBoxSlovo4.TabIndex = 4;
            // 
            // textBoxSlovo5
            // 
            textBoxSlovo5.BorderStyle = BorderStyle.FixedSingle;
            textBoxSlovo5.CharacterCasing = CharacterCasing.Upper;
            textBoxSlovo5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSlovo5.Location = new Point(342, 106);
            textBoxSlovo5.Name = "textBoxSlovo5";
            textBoxSlovo5.ReadOnly = true;
            textBoxSlovo5.Size = new Size(44, 35);
            textBoxSlovo5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 217);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 6;
            label2.Text = "Slovo:";
            // 
            // textBoxSlovoPokusaj
            // 
            textBoxSlovoPokusaj.CharacterCasing = CharacterCasing.Upper;
            textBoxSlovoPokusaj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSlovoPokusaj.Location = new Point(145, 214);
            textBoxSlovoPokusaj.MaxLength = 1;
            textBoxSlovoPokusaj.Name = "textBoxSlovoPokusaj";
            textBoxSlovoPokusaj.Size = new Size(32, 29);
            textBoxSlovoPokusaj.TabIndex = 7;
            // 
            // buttonPokusaj
            // 
            buttonPokusaj.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPokusaj.Location = new Point(72, 266);
            buttonPokusaj.Name = "buttonPokusaj";
            buttonPokusaj.Size = new Size(105, 24);
            buttonPokusaj.TabIndex = 8;
            buttonPokusaj.Text = "Pokusaj";
            buttonPokusaj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(342, 217);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 9;
            label3.Text = "Preostali pokusaji:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(342, 254);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 10;
            label4.Text = "Prethodni pokusaji:";
            // 
            // labelPrethodniPokusaji
            // 
            labelPrethodniPokusaji.AutoSize = true;
            labelPrethodniPokusaji.Location = new Point(491, 260);
            labelPrethodniPokusaji.Name = "labelPrethodniPokusaji";
            labelPrethodniPokusaji.Size = new Size(38, 15);
            labelPrethodniPokusaji.TabIndex = 11;
            labelPrethodniPokusaji.Text = "label5";
            // 
            // labelPreostaliPokusaji
            // 
            labelPreostaliPokusaji.AutoSize = true;
            labelPreostaliPokusaji.Location = new Point(491, 223);
            labelPreostaliPokusaji.Name = "labelPreostaliPokusaji";
            labelPreostaliPokusaji.Size = new Size(38, 15);
            labelPreostaliPokusaji.TabIndex = 12;
            labelPreostaliPokusaji.Text = "label5";
            // 
            // Forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPreostaliPokusaji);
            Controls.Add(labelPrethodniPokusaji);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonPokusaj);
            Controls.Add(textBoxSlovoPokusaj);
            Controls.Add(label2);
            Controls.Add(textBoxSlovo5);
            Controls.Add(textBoxSlovo4);
            Controls.Add(textBoxSlovo3);
            Controls.Add(textBoxSlovo2);
            Controls.Add(textBoxSlovo1);
            Controls.Add(label1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Forma";
            Text = "Klijentska aplikacija";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSlovo1;
        private TextBox textBoxSlovo2;
        private TextBox textBoxSlovo3;
        private TextBox textBoxSlovo4;
        private TextBox textBoxSlovo5;
        private Label label2;
        private TextBox textBoxSlovoPokusaj;
        private Button buttonPokusaj;
        private Label label3;
        private Label label4;
        private Label labelPrethodniPokusaji;
        private Label labelPreostaliPokusaji;
    }
}
