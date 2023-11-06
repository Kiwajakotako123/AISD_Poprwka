namespace Projekt_AISD_S
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbxWynikTablicy = new TextBox();
            btnSB = new Button();
            lblCzasWyk = new Button();
            btnSS = new Button();
            btnSI = new Button();
            btnSM = new Button();
            btnSQ = new Button();
            btnGenerate = new Button();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            Losuj = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // tbxWynikTablicy
            // 
            tbxWynikTablicy.Location = new Point(12, 219);
            tbxWynikTablicy.Name = "tbxWynikTablicy";
            tbxWynikTablicy.Size = new Size(267, 23);
            tbxWynikTablicy.TabIndex = 1;
            tbxWynikTablicy.TextChanged += tbxWynikTablicy_TextChanged;
            // 
            // btnSB
            // 
            btnSB.Location = new Point(59, 325);
            btnSB.Name = "btnSB";
            btnSB.Size = new Size(48, 23);
            btnSB.TabIndex = 2;
            btnSB.Text = "SB";
            btnSB.UseVisualStyleBackColor = true;
            btnSB.Click += btnSB_Click;
            // 
            // lblCzasWyk
            // 
            lblCzasWyk.Location = new Point(417, 219);
            lblCzasWyk.Name = "lblCzasWyk";
            lblCzasWyk.Size = new Size(176, 23);
            lblCzasWyk.TabIndex = 3;
            lblCzasWyk.Text = "Czas";
            lblCzasWyk.UseVisualStyleBackColor = true;
            lblCzasWyk.Click += lblCzasWyk_Click;
            // 
            // btnSS
            // 
            btnSS.Location = new Point(168, 325);
            btnSS.Name = "btnSS";
            btnSS.Size = new Size(47, 23);
            btnSS.TabIndex = 4;
            btnSS.Text = "SS";
            btnSS.UseVisualStyleBackColor = true;
            btnSS.Click += btnSS_Click;
            // 
            // btnSI
            // 
            btnSI.Location = new Point(285, 325);
            btnSI.Name = "btnSI";
            btnSI.Size = new Size(52, 23);
            btnSI.TabIndex = 5;
            btnSI.Text = "SI";
            btnSI.UseVisualStyleBackColor = true;
            btnSI.Click += btnSI_Click;
            // 
            // btnSM
            // 
            btnSM.Location = new Point(408, 325);
            btnSM.Name = "btnSM";
            btnSM.Size = new Size(51, 23);
            btnSM.TabIndex = 6;
            btnSM.Text = "SM";
            btnSM.UseVisualStyleBackColor = true;
            btnSM.Click += btnSM_Click;
            // 
            // btnSQ
            // 
            btnSQ.Location = new Point(524, 325);
            btnSQ.Name = "btnSQ";
            btnSQ.Size = new Size(47, 23);
            btnSQ.TabIndex = 7;
            btnSQ.Text = "SQ";
            btnSQ.UseVisualStyleBackColor = true;
            btnSQ.Click += btnSQ_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(476, 139);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(117, 23);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generuj Tablice";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(348, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(473, 52);
            numericUpDown1.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Losuj
            // 
            Losuj.Location = new Point(476, 92);
            Losuj.Name = "Losuj";
            Losuj.Size = new Size(117, 23);
            Losuj.TabIndex = 11;
            Losuj.Text = "Losuj ilośc znaków";
            Losuj.UseVisualStyleBackColor = true;
            Losuj.Click += Losuj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 414);
            Controls.Add(Losuj);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(btnGenerate);
            Controls.Add(btnSQ);
            Controls.Add(btnSM);
            Controls.Add(btnSI);
            Controls.Add(btnSS);
            Controls.Add(lblCzasWyk);
            Controls.Add(btnSB);
            Controls.Add(tbxWynikTablicy);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox tbxWynikTablicy;
        private Button btnSB;
        private Button lblCzasWyk;
        private Button btnSS;
        private Button btnSI;
        private Button btnSM;
        private Button btnSQ;
        private Button btnGenerate;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Button Losuj;
    }
}