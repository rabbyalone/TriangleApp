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
            int x = panel1.Width / 2; // 151
            int y = panel1.Height / 2;// 200

            Point p1 = new Point(x, y - arm1); // x = 151, y = 100
            Point p2 = new Point(x - arm2 / 2, y + arm3);
            Point p3 = new Point(x + arm2 / 2, y + arm3);

            g.Clear(Color.White);

            for (int i = 1; i <= layer; i++)
            {
                int yOffset = i * 10;
                Point p1Layer = new Point(p1.X, p1.Y - yOffset);
                Point p2Layer = new Point(p2.X, p2.Y - yOffset);
                Point p3Layer = new Point(p3.X, p3.Y - yOffset);

                g.DrawLine(Pens.Red, p1Layer, p2Layer);
                g.DrawLine(Pens.Black, p2Layer, p3Layer);
                g.DrawLine(Pens.Blue, p3Layer, p1Layer);
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