namespace ServerskaAplikacija
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
            labelZadataRec = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelBrPokusaja1 = new Label();
            labelBrPokusaja2 = new Label();
            labelBrPogodjenih2 = new Label();
            labelBrPogodjenih1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 90);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Zadata rec:";
            // 
            // labelZadataRec
            // 
            labelZadataRec.AutoSize = true;
            labelZadataRec.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelZadataRec.Location = new Point(278, 77);
            labelZadataRec.Name = "labelZadataRec";
            labelZadataRec.Size = new Size(141, 37);
            labelZadataRec.TabIndex = 1;
            labelZadataRec.Text = "Zadata rec";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 238);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 2;
            label2.Text = "Igrac 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 299);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 3;
            label3.Text = "Igrac 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(200, 203);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 4;
            label4.Text = "Broj pokusaja";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(351, 203);
            label5.Name = "label5";
            label5.Size = new Size(161, 21);
            label5.TabIndex = 5;
            label5.Text = "Broj pogodjenih slova";
            // 
            // labelBrPokusaja1
            // 
            labelBrPokusaja1.AutoSize = true;
            labelBrPokusaja1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBrPokusaja1.Location = new Point(238, 238);
            labelBrPokusaja1.Name = "labelBrPokusaja1";
            labelBrPokusaja1.Size = new Size(19, 21);
            labelBrPokusaja1.TabIndex = 6;
            labelBrPokusaja1.Text = "0";
            // 
            // labelBrPokusaja2
            // 
            labelBrPokusaja2.AutoSize = true;
            labelBrPokusaja2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBrPokusaja2.Location = new Point(238, 299);
            labelBrPokusaja2.Name = "labelBrPokusaja2";
            labelBrPokusaja2.Size = new Size(19, 21);
            labelBrPokusaja2.TabIndex = 7;
            labelBrPokusaja2.Text = "0";
            // 
            // labelBrPogodjenih2
            // 
            labelBrPogodjenih2.AutoSize = true;
            labelBrPogodjenih2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBrPogodjenih2.Location = new Point(411, 299);
            labelBrPogodjenih2.Name = "labelBrPogodjenih2";
            labelBrPogodjenih2.Size = new Size(19, 21);
            labelBrPogodjenih2.TabIndex = 9;
            labelBrPogodjenih2.Text = "0";
            // 
            // labelBrPogodjenih1
            // 
            labelBrPogodjenih1.AutoSize = true;
            labelBrPogodjenih1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBrPogodjenih1.Location = new Point(411, 238);
            labelBrPogodjenih1.Name = "labelBrPogodjenih1";
            labelBrPogodjenih1.Size = new Size(19, 21);
            labelBrPogodjenih1.TabIndex = 8;
            labelBrPogodjenih1.Text = "0";
            // 
            // Forma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBrPogodjenih2);
            Controls.Add(labelBrPogodjenih1);
            Controls.Add(labelBrPokusaja2);
            Controls.Add(labelBrPokusaja1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelZadataRec);
            Controls.Add(label1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Forma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serverska aplikacija";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelZadataRec;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelBrPokusaja1;
        private Label labelBrPokusaja2;
        private Label labelBrPogodjenih2;
        private Label labelBrPogodjenih1;
    }
}
