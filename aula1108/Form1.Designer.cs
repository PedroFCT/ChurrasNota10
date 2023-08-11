namespace aula1108
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
            CalcularButton = new Button();
            Mens = new TextBox();
            Womans = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Kids = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CarvaoLB = new Label();
            carneLB = new Label();
            farofaLB = new Label();
            cervejaLB = new Label();
            refriLB = new Label();
            label10 = new Label();
            label11 = new Label();
            label5 = new Label();
            saladaLB = new Label();
            label6 = new Label();
            label7 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // CalcularButton
            // 
            CalcularButton.Location = new Point(686, 404);
            CalcularButton.Name = "CalcularButton";
            CalcularButton.Size = new Size(75, 23);
            CalcularButton.TabIndex = 0;
            CalcularButton.Text = "Calcular";
            CalcularButton.UseVisualStyleBackColor = true;
            CalcularButton.Click += CalcularButton_Click;
            // 
            // Mens
            // 
            Mens.Location = new Point(76, 155);
            Mens.Name = "Mens";
            Mens.Size = new Size(100, 23);
            Mens.TabIndex = 1;
            Mens.TextChanged += textBox1_TextChanged;
            // 
            // Womans
            // 
            Womans.Location = new Point(76, 218);
            Womans.Name = "Womans";
            Womans.Size = new Size(100, 23);
            Womans.TabIndex = 2;
            Womans.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 137);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Qtd. Homens";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 200);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Qtd. Mulheres";
            label2.Click += label2_Click;
            // 
            // Kids
            // 
            Kids.Location = new Point(76, 274);
            Kids.Name = "Kids";
            Kids.Size = new Size(100, 23);
            Kids.TabIndex = 5;
            Kids.TextChanged += kids_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 256);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "Qtd. Crianças";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 20);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "Churrasco nota 10";
            // 
            // CarvaoLB
            // 
            CarvaoLB.AutoSize = true;
            CarvaoLB.Location = new Point(492, 218);
            CarvaoLB.Name = "CarvaoLB";
            CarvaoLB.Size = new Size(13, 15);
            CarvaoLB.TabIndex = 8;
            CarvaoLB.Text = "0";
            CarvaoLB.Click += label5_Click;
            // 
            // carneLB
            // 
            carneLB.AutoSize = true;
            carneLB.Location = new Point(492, 291);
            carneLB.Name = "carneLB";
            carneLB.Size = new Size(13, 15);
            carneLB.TabIndex = 9;
            carneLB.Text = "0";
            // 
            // farofaLB
            // 
            farofaLB.AutoSize = true;
            farofaLB.Location = new Point(700, 218);
            farofaLB.Name = "farofaLB";
            farofaLB.Size = new Size(13, 15);
            farofaLB.TabIndex = 10;
            farofaLB.Text = "0";
            farofaLB.Click += label7_Click;
            // 
            // cervejaLB
            // 
            cervejaLB.AutoSize = true;
            cervejaLB.Location = new Point(700, 254);
            cervejaLB.Name = "cervejaLB";
            cervejaLB.Size = new Size(13, 15);
            cervejaLB.TabIndex = 13;
            cervejaLB.Text = "0";
            cervejaLB.Click += cervejaLB_Click;
            // 
            // refriLB
            // 
            refriLB.AutoSize = true;
            refriLB.Location = new Point(700, 293);
            refriLB.Name = "refriLB";
            refriLB.Size = new Size(13, 15);
            refriLB.TabIndex = 12;
            refriLB.Text = "0";
            refriLB.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(635, 293);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 11;
            label10.Text = "Refri: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(525, 107);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 14;
            label11.Text = "RESULTADOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 218);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 15;
            label5.Text = "Carvão: ";
            label5.Click += label5_Click_1;
            // 
            // saladaLB
            // 
            saladaLB.AutoSize = true;
            saladaLB.Location = new Point(492, 254);
            saladaLB.Name = "saladaLB";
            saladaLB.Size = new Size(13, 15);
            saladaLB.TabIndex = 16;
            saladaLB.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 254);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 17;
            label6.Text = "Salada: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 291);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 18;
            label7.Text = "Carne: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(626, 218);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 19;
            label12.Text = "Farofa: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(624, 254);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 20;
            label13.Text = "Cerveja: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(saladaLB);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(cervejaLB);
            Controls.Add(refriLB);
            Controls.Add(label10);
            Controls.Add(farofaLB);
            Controls.Add(carneLB);
            Controls.Add(CarvaoLB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Kids);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Womans);
            Controls.Add(Mens);
            Controls.Add(CalcularButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalcularButton;
        private TextBox Mens;
        private TextBox Womans;
        private Label label1;
        private Label label2;
        private TextBox Kids;
        private Label label3;
        private Label label4;
        private Label CarvaoLB;
        private Label carneLB;
        private Label farofaLB;
        private Label cervejaLB;
        private Label refriLB;
        private Label label10;
        private Label label11;
        private Label label5;
        private Label saladaLB;
        private Label label6;
        private Label label7;
        private Label label12;
        private Label label13;
    }
}