namespace TriangleApp
{
    partial class AdvanceTriangle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            arm1Xvalue = new NumericUpDown();
            arm1Yvalue = new NumericUpDown();
            arm2Xvalue = new NumericUpDown();
            arm2Yvalue = new NumericUpDown();
            arm3Xvalue = new NumericUpDown();
            arm3Yvalue = new NumericUpDown();
            button1 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            layerCount = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)arm1Xvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arm1Yvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arm2Xvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arm2Yvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arm3Xvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arm3Yvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layerCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Arm1X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(255, 27);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Arm1Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Arm2X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(255, 139);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Arm3Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 141);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Arm3X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(255, 83);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Arm2Y";
            // 
            // arm1Xvalue
            // 
            arm1Xvalue.Location = new Point(66, 21);
            arm1Xvalue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            arm1Xvalue.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            arm1Xvalue.Name = "arm1Xvalue";
            arm1Xvalue.Size = new Size(171, 23);
            arm1Xvalue.TabIndex = 6;
            // 
            // arm1Yvalue
            // 
            arm1Yvalue.Location = new Point(306, 23);
            arm1Yvalue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            arm1Yvalue.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            arm1Yvalue.Name = "arm1Yvalue";
            arm1Yvalue.Size = new Size(171, 23);
            arm1Yvalue.TabIndex = 7;
            // 
            // arm2Xvalue
            // 
            arm2Xvalue.Location = new Point(67, 81);
            arm2Xvalue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            arm2Xvalue.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            arm2Xvalue.Name = "arm2Xvalue";
            arm2Xvalue.Size = new Size(171, 23);
            arm2Xvalue.TabIndex = 8;
            // 
            // arm2Yvalue
            // 
            arm2Yvalue.Location = new Point(306, 81);
            arm2Yvalue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            arm2Yvalue.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            arm2Yvalue.Name = "arm2Yvalue";
            arm2Yvalue.Size = new Size(171, 23);
            arm2Yvalue.TabIndex = 9;
            // 
            // arm3Xvalue
            // 
            arm3Xvalue.Location = new Point(67, 133);
            arm3Xvalue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            arm3Xvalue.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            arm3Xvalue.Name = "arm3Xvalue";
            arm3Xvalue.Size = new Size(171, 23);
            arm3Xvalue.TabIndex = 10;
            // 
            // arm3Yvalue
            // 
            arm3Yvalue.Location = new Point(306, 133);
            arm3Yvalue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            arm3Yvalue.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            arm3Yvalue.Name = "arm3Yvalue";
            arm3Yvalue.Size = new Size(171, 23);
            arm3Yvalue.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(66, 219);
            button1.Name = "button1";
            button1.Size = new Size(171, 23);
            button1.TabIndex = 12;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(520, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 418);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(15, 185);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 14;
            label7.Text = "Layer";
            // 
            // layerCount
            // 
            layerCount.Location = new Point(66, 177);
            layerCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            layerCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            layerCount.Name = "layerCount";
            layerCount.Size = new Size(171, 23);
            layerCount.TabIndex = 15;
            layerCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(255, 219);
            button2.Name = "button2";
            button2.Size = new Size(171, 23);
            button2.TabIndex = 16;
            button2.Text = "Clear All";
            button2.UseVisualStyleBackColor = false;
            // 
            // AdvanceTriangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 442);
            Controls.Add(button2);
            Controls.Add(layerCount);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(arm3Yvalue);
            Controls.Add(arm3Xvalue);
            Controls.Add(arm2Yvalue);
            Controls.Add(arm2Xvalue);
            Controls.Add(arm1Yvalue);
            Controls.Add(arm1Xvalue);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Crimson;
            Name = "AdvanceTriangle";
            Text = "AdvanceTriangle";
            ((System.ComponentModel.ISupportInitialize)arm1Xvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)arm1Yvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)arm2Xvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)arm2Yvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)arm3Xvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)arm3Yvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)layerCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown arm1Xvalue;
        private NumericUpDown arm1Yvalue;
        private NumericUpDown arm2Xvalue;
        private NumericUpDown arm2Yvalue;
        private NumericUpDown arm3Xvalue;
        private NumericUpDown arm3Yvalue;
        private Button button1;
        private Panel panel1;
        private Label label7;
        private NumericUpDown layerCount;
        private Button button2;
    }
}