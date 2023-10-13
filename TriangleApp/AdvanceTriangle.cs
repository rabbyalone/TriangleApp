namespace TriangleApp
{
    public partial class AdvanceTriangle : Form
    {
        int arm1X = 0;
        int arm1Y = 0;
        int arm2X = 0;
        int arm2Y = 0;
        int arm3X = 0;
        int arm3Y = 0;
        int layer = 1;
        public AdvanceTriangle()
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

            for (int i = 1; i <= layer; i++)
            {
                int offset = i * 10;
                Point p1 = new Point(x + arm1X, y + arm1Y - offset);
                Point p2 = new Point(x + arm2X, y + arm2Y - offset);
                Point p3 = new Point(x + arm3X, y + arm3Y - offset);

                g.DrawLine(Pens.Red, p1, p2);
                g.DrawLine(Pens.Black, p2, p3);
                g.DrawLine(Pens.Black, p3, p1);
            }

        }

        private void UpdateTriangle()
        {
            arm1X = (int)arm1Xvalue.Value;
            arm1Y = (int)arm1Yvalue.Value;
            arm2X = (int)arm2Xvalue.Value;
            arm2Y = (int)arm2Yvalue.Value;
            arm3X = (int)arm3Xvalue.Value;
            arm3Y = (int)arm3Yvalue.Value;
            layer = (int)layerCount.Value;

            panel1.Invalidate();
        }
    }
}
