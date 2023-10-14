# Triangle App

### Context: 
- This is a test windows forms app which contains azure authentication, advance trinangle creation, 
basic triangle creation with offset setup. 

### Features

- Azure Active directory login for any microsoft user
- Create Triangles with Defining X and Y axis for three of its vertices.
- Draw trinangles by height and base
- Add layers by setting up offset
- Offset setup

#### Authentication

![Authentication](./triangletest/auth.png)

**Prompt for user login using microsft login screen.**

![Authentication](./triangletest/auth1.png)

#### Triangle Setup (Advance)

By setting up (x1, y1), (x2, y2) and (x3, y3), we can plot triangle here, 
drawing range of triangle is `-1000 < m < 1000`. Offset is fixed 10 in y axis.

![AdvanceTriangle](./triangletest/advtri.png)

#### Basic Triagnle

![BasicTriangle](./triangletest/basic.png)

## Technical 

I have created `Triangle` class to hold the value of points. 

```csharp
  public class Triangle
    {
        public Point[] Points { get; set; }

        public Triangle(Point[] points)
        {
            Points = points;
        }
    }
```

Then, Initialized `List` of `Triangle` and adding new values into that trinagles list

`private List<Triangle> triangles = new List<Triangle>();`


```csharp
         Point[] trianglePoints = new Point[]
            {
                new Point(arm1X, arm1Y),
                new Point(arm2X, arm2Y),
                new Point (arm3X, arm3Y)
            };
            triangles.Add(new Triangle(trianglePoints));
```

Here is the drawing of polygon to create triangles with layer

```csharp
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
```



