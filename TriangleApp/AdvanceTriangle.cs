namespace TriangleApp
{
    public partial class AdvanceTriangle : Form
    {
        private List<Triangle> triangles = new List<Triangle>();

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
            AddTriangle();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);

            int x = panel1.Width / 2;
            int y = panel1.Height / 2;

            label8.Text = $"Panel Width: {panel1.Width}";
            label9.Text = $"Panel Height: {panel1.Height}";
            label10.Text = $"Panel Center: x: {x} y: {y}";

            foreach (var triangle in triangles)
            {
                for (int i = 1; i <= layer; i++)
                {
                    var offset = i * 20;
                    if (triangle.Points.Count() > i)
                    {
                        triangle.Points[i].Y = triangle.Points[i].Y - offset;
                    }

                    g.DrawPolygon(Pens.White, triangle.Points);
                }
            }


        }

        private void AddTriangle()
        {
            arm1X = (int)arm1Xvalue.Value;
            arm1Y = (int)arm1Yvalue.Value;
            arm2X = (int)arm2Xvalue.Value;
            arm2Y = (int)arm2Yvalue.Value;
            arm3X = (int)arm3Xvalue.Value;
            arm3Y = (int)arm3Yvalue.Value;
            layer = (int)layerCount.Value;

            Point[] trianglePoints = new Point[]
            {
                new Point(arm1X, arm1Y),
                new Point(arm2X, arm2Y),
                new Point (arm3X, arm3Y)
            };
            triangles.Add(new Triangle(trianglePoints));

            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            triangles.Clear();
            panel1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BasicTriangle().Show();
        }
    }


}
