namespace Toets1OOP
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMerk = new TextBox();
            txtSerieNummer = new TextBox();
            txtType = new TextBox();
            btnVoegToe = new Button();
            btnStandaard = new Button();
            label5 = new Label();
            lblGegevens = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Voeg nieuwe laptop toe: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Merk: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Type: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 86);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Serienummer: ";
            // 
            // txtMerk
            // 
            txtMerk.Location = new Point(113, 33);
            txtMerk.Name = "txtMerk";
            txtMerk.Size = new Size(144, 23);
            txtMerk.TabIndex = 5;
            // 
            // txtSerieNummer
            // 
            txtSerieNummer.Location = new Point(113, 83);
            txtSerieNummer.Name = "txtSerieNummer";
            txtSerieNummer.Size = new Size(144, 23);
            txtSerieNummer.TabIndex = 7;
            // 
            // txtType
            // 
            txtType.Location = new Point(113, 58);
            txtType.Name = "txtType";
            txtType.Size = new Size(144, 23);
            txtType.TabIndex = 8;
            // 
            // btnVoegToe
            // 
            btnVoegToe.Location = new Point(12, 114);
            btnVoegToe.Name = "btnVoegToe";
            btnVoegToe.Size = new Size(75, 23);
            btnVoegToe.TabIndex = 9;
            btnVoegToe.Text = "Voeg toe";
            btnVoegToe.UseVisualStyleBackColor = true;
            // 
            // btnStandaard
            // 
            btnStandaard.Location = new Point(319, 27);
            btnStandaard.Name = "btnStandaard";
            btnStandaard.Size = new Size(75, 23);
            btnStandaard.TabIndex = 10;
            btnStandaard.Text = "Voeg toe";
            btnStandaard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 9);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 11;
            label5.Text = "Voeg standaard laptop toe";
            // 
            // lblGegevens
            // 
            lblGegevens.AutoSize = true;
            lblGegevens.Location = new Point(12, 156);
            lblGegevens.Name = "lblGegevens";
            lblGegevens.Size = new Size(0, 15);
            lblGegevens.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGegevens);
            Controls.Add(label5);
            Controls.Add(btnStandaard);
            Controls.Add(btnVoegToe);
            Controls.Add(txtType);
            Controls.Add(txtSerieNummer);
            Controls.Add(txtMerk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMerk;
        private TextBox txtSerieNummer;
        private TextBox txtType;
        private Button btnVoegToe;
        private Button btnStandaard;
        private Label label5;
        private Label lblGegevens;
    }
}