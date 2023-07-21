namespace CodDeBare
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
            p = new PictureBox();
            Negativ = new CheckBox();
            label1 = new Label();
            Text = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)p).BeginInit();
            SuspendLayout();
            // 
            // p
            // 
            p.Location = new Point(78, 35);
            p.Name = "p";
            p.Size = new Size(637, 165);
            p.TabIndex = 0;
            p.TabStop = false;
            p.Paint += p_Paint;
            // 
            // Negativ
            // 
            Negativ.AutoSize = true;
            Negativ.Location = new Point(72, 259);
            Negativ.Name = "Negativ";
            Negativ.Size = new Size(83, 24);
            Negativ.TabIndex = 2;
            Negativ.Text = "Negativ";
            Negativ.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 322);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 3;
            label1.Text = "Valoare";
            // 
            // Text
            // 
            Text.Location = new Point(198, 326);
            Text.Name = "Text";
            Text.Size = new Size(431, 27);
            Text.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(198, 377);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Genereaza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(535, 377);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Salveaza";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Text);
            Controls.Add(label1);
            Controls.Add(Negativ);
            Controls.Add(p);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)p).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox p;
        private CheckBox Negativ;
        private Label label1;
        private TextBox Text;
        private Button button1;
        private Button button2;
    }
}