namespace Games
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Inapoi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.multiplayer = new System.Windows.Forms.Button();
            this.Win = new System.Windows.Forms.Label();
            this.DansulCulorilor = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C4 = new System.Windows.Forms.Button();
            this.ColorIndicator = new System.Windows.Forms.Label();
            this.ColorLoop = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 222);
            this.button1.TabIndex = 0;
            this.button1.Text = "Numarul ascuns";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jocuri distractive";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(158, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ghiceste numarul ascuns ( 0 - 1000 )";
            this.label2.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(189, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sunt sigur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scrie un numar :";
            this.label3.Visible = false;
            // 
            // Inapoi
            // 
            this.Inapoi.Enabled = false;
            this.Inapoi.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inapoi.Location = new System.Drawing.Point(380, 378);
            this.Inapoi.Name = "Inapoi";
            this.Inapoi.Size = new System.Drawing.Size(127, 32);
            this.Inapoi.TabIndex = 6;
            this.Inapoi.Text = "Inapoi";
            this.Inapoi.UseVisualStyleBackColor = true;
            this.Inapoi.Visible = false;
            this.Inapoi.Click += new System.EventHandler(this.Inapoi_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(202, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 222);
            this.button3.TabIndex = 7;
            this.button3.Text = "X si O";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // multiplayer
            // 
            this.multiplayer.Enabled = false;
            this.multiplayer.Font = new System.Drawing.Font("Rockwell Condensed", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplayer.Location = new System.Drawing.Point(84, 127);
            this.multiplayer.Name = "multiplayer";
            this.multiplayer.Size = new System.Drawing.Size(361, 94);
            this.multiplayer.TabIndex = 8;
            this.multiplayer.Text = "MultiPlayer";
            this.multiplayer.UseVisualStyleBackColor = true;
            this.multiplayer.Visible = false;
            this.multiplayer.Click += new System.EventHandler(this.multiplayer_Click);
            // 
            // Win
            // 
            this.Win.AutoSize = true;
            this.Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Win.Location = new System.Drawing.Point(153, 164);
            this.Win.Name = "Win";
            this.Win.Size = new System.Drawing.Size(205, 25);
            this.Win.TabIndex = 19;
            this.Win.Text = "Castigatorul este: \r\n";
            this.Win.Visible = false;
            // 
            // DansulCulorilor
            // 
            this.DansulCulorilor.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DansulCulorilor.Location = new System.Drawing.Point(356, 127);
            this.DansulCulorilor.Name = "DansulCulorilor";
            this.DansulCulorilor.Size = new System.Drawing.Size(123, 245);
            this.DansulCulorilor.TabIndex = 20;
            this.DansulCulorilor.Text = "Dansul culorilor\r\n";
            this.DansulCulorilor.UseVisualStyleBackColor = true;
            this.DansulCulorilor.Click += new System.EventHandler(this.DansulCulorilor_Click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Red;
            this.C1.Enabled = false;
            this.C1.Location = new System.Drawing.Point(99, 85);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(122, 109);
            this.C1.TabIndex = 21;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Visible = false;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Blue;
            this.C2.Enabled = false;
            this.C2.Location = new System.Drawing.Point(289, 85);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(122, 109);
            this.C2.TabIndex = 22;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Visible = false;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Green;
            this.C3.Enabled = false;
            this.C3.Location = new System.Drawing.Point(99, 263);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(122, 109);
            this.C3.TabIndex = 23;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Visible = false;
            this.C3.Click += new System.EventHandler(this.C3_Click);
            // 
            // C4
            // 
            this.C4.BackColor = System.Drawing.Color.Yellow;
            this.C4.Enabled = false;
            this.C4.Location = new System.Drawing.Point(289, 263);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(122, 109);
            this.C4.TabIndex = 24;
            this.C4.UseVisualStyleBackColor = false;
            this.C4.Visible = false;
            this.C4.Click += new System.EventHandler(this.C4_Click);
            // 
            // ColorIndicator
            // 
            this.ColorIndicator.AutoSize = true;
            this.ColorIndicator.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorIndicator.Location = new System.Drawing.Point(170, 216);
            this.ColorIndicator.Name = "ColorIndicator";
            this.ColorIndicator.Size = new System.Drawing.Size(155, 35);
            this.ColorIndicator.TabIndex = 25;
            this.ColorIndicator.Text = "Indicator";
            this.ColorIndicator.Visible = false;
            // 
            // ColorLoop
            // 
            this.ColorLoop.Interval = 500;
            this.ColorLoop.Tick += new System.EventHandler(this.ColorLoop_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(256, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 231);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(275, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 220);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // B9
            // 
            this.B9.Enabled = false;
            this.B9.Location = new System.Drawing.Point(321, 289);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(90, 83);
            this.B9.TabIndex = 18;
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Visible = false;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B8
            // 
            this.B8.Enabled = false;
            this.B8.Location = new System.Drawing.Point(211, 127);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(90, 83);
            this.B8.TabIndex = 17;
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Visible = false;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B7
            // 
            this.B7.Enabled = false;
            this.B7.Location = new System.Drawing.Point(99, 289);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(90, 83);
            this.B7.TabIndex = 16;
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Visible = false;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B6
            // 
            this.B6.Enabled = false;
            this.B6.Location = new System.Drawing.Point(321, 189);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(90, 83);
            this.B6.TabIndex = 15;
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Visible = false;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B5
            // 
            this.B5.Enabled = false;
            this.B5.Location = new System.Drawing.Point(211, 189);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(90, 83);
            this.B5.TabIndex = 14;
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Visible = false;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B4
            // 
            this.B4.Enabled = false;
            this.B4.Location = new System.Drawing.Point(99, 189);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(90, 83);
            this.B4.TabIndex = 13;
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Visible = false;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B3
            // 
            this.B3.Enabled = false;
            this.B3.Location = new System.Drawing.Point(321, 85);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(90, 83);
            this.B3.TabIndex = 12;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Visible = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B2
            // 
            this.B2.Enabled = false;
            this.B2.Location = new System.Drawing.Point(211, 225);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(90, 83);
            this.B2.TabIndex = 11;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Visible = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B1
            // 
            this.B1.Enabled = false;
            this.B1.Location = new System.Drawing.Point(99, 85);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(90, 83);
            this.B1.TabIndex = 10;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Visible = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 407);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ColorIndicator);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.DansulCulorilor);
            this.Controls.Add(this.Win);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.multiplayer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Inapoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Joculetze distractive";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Inapoi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button multiplayer;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Label Win;
        private System.Windows.Forms.Button DansulCulorilor;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C4;
        private System.Windows.Forms.Label ColorIndicator;
        private System.Windows.Forms.Timer ColorLoop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

