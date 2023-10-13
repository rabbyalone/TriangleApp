namespace TriangleApp
{
    public partial class Form1 : Form
    {
        private int arm1 = 0;
        private int arm2 = 0;
        private int arm3 = 0;
        private int layer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTriangle();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = panel1.Width / 2;
            int y = panel1.Height / 2;

            g.Clear(Color.White);

            for (int i = 1; i <= layer; i++)
            {
                Random random = new Random();
                Pen pen = new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));

                int yOffset = i * 10;
                Point p1 = new Point(x, y - arm1 - yOffset);
                Point p2 = new Point(x - arm2 / 2, y + arm3 - yOffset);
                Point p3 = new Point(x + arm2 / 2, y + arm3 - yOffset);

                g.DrawLines(pen, new Point[] { p1, p2, p3, p1 });
            }
        }

        private void UpdateTriangle()
        {
            arm1 = (int)numericUpDown1.Value;
            arm2 = (int)numericUpDown2.Value;
            arm3 = (int)numericUpDown3.Value;
            layer = (int)numericUpDown4.Value;

            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdvanceTriangle advanceTriangle = new AdvanceTriangle();
            advanceTriangle.Show();
        }
    }
}