namespace TriangleApp
{
    public partial class BasicTriangle : Form
    {
        private int baseLength = 0;
        private int height = 0;
        private int layer = 0;
        private int xOffset = 0;
        private int yOffset = 0;
        private List<Triangle> triangles = new List<Triangle>();
        public BasicTriangle()
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

            g.Clear(Color.White);
            foreach (var item in triangles)
            {
                for (int i = 1; i <= layer; i++)
                {
                    Random random = new Random();
                    Pen pen = new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));

                    g.DrawPolygon(pen, item.Points);
                }
            }
        }

        private void UpdateTriangle()
        {
            baseLength = (int)numericUpDown2.Value;
            height = (int)numericUpDown3.Value;
            layer = (int)numericUpDown4.Value;

            xOffset = (int)xOffsetNumericVal.Value;
            yOffset = (int)yOffsetNumericVal.Value;

            int x = 10 + xOffset;
            int y = 10 + yOffset;

            Point[] points =
            {
                    new Point(x, y),
                    new Point(x + baseLength, y),
                    new Point(x + baseLength / 2, y - height)
            };

            triangles.Add(new Triangle(points));

            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdvanceTriangle advanceTriangle = new AdvanceTriangle();
            advanceTriangle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            triangles.Clear();
            panel1.Invalidate();
        }
    }
}