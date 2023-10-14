namespace TriangleApp
{
    partial class BasicTriangle
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
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            button1 = new Button();
            panel1 = new Panel();
            numericUpDown4 = new NumericUpDown();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            yOffsetNumericVal = new NumericUpDown();
            label6 = new Label();
            xOffsetNumericVal = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yOffsetNumericVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xOffsetNumericVal).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(114, 50);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(114, 90);
            numericUpDown3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(73, 283);
            button1.Name = "button1";
            button1.Size = new Size(183, 23);
            button1.TabIndex = 7;
            button1.Text = "Draw Basic Triangle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(350, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 426);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(114, 140);
            numericUpDown4.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 9;
            numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(73, 312);
            button2.Name = "button2";
            button2.Size = new Size(183, 23);
            button2.TabIndex = 10;
            button2.Text = "Draw Advance Triangle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 58);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 12;
            label2.Text = "Right";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 96);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 13;
            label3.Text = "Horizontal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(73, 143);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 14;
            label4.Text = "Layer";
            // 
            // button3
            // 
            button3.Location = new Point(73, 341);
            button3.Name = "button3";
            button3.Size = new Size(183, 23);
            button3.TabIndex = 15;
            button3.Text = "Clear All";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(59, 188);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 17;
            label5.Text = "XOffset";
            // 
            // yOffsetNumericVal
            // 
            yOffsetNumericVal.Location = new Point(114, 184);
            yOffsetNumericVal.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            yOffsetNumericVal.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            yOffsetNumericVal.Name = "yOffsetNumericVal";
            yOffsetNumericVal.Size = new Size(120, 23);
            yOffsetNumericVal.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(57, 228);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 19;
            label6.Text = "YOffset";
            // 
            // xOffsetNumericVal
            // 
            xOffsetNumericVal.Location = new Point(114, 223);
            xOffsetNumericVal.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            xOffsetNumericVal.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            xOffsetNumericVal.Name = "xOffsetNumericVal";
            xOffsetNumericVal.Size = new Size(120, 23);
            xOffsetNumericVal.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(xOffsetNumericVal);
            Controls.Add(label5);
            Controls.Add(yOffsetNumericVal);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(numericUpDown4);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)yOffsetNumericVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)xOffsetNumericVal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button button1;
        private Panel panel1;
        private NumericUpDown numericUpDown4;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label5;
        private NumericUpDown yOffsetNumericVal;
        private Label label6;
        private NumericUpDown xOffsetNumericVal;
    }
}