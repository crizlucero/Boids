using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Boids
{
    class Boid
    {
        public int pX;
        public int pY;
        public double angle;
        public Image image = new Image();

        public Boid(int pX, int pY, double angle, int count)
        {
            this.pX = pX;
            this.pY = pY;
            this.DrawBoid(count);
        }

        private void DrawBoid(int count)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri("/Images/Boid.png", UriKind.Relative);
            bi.EndInit();
            string BodyName = "Boid" + count;
            Image boid = new Image
            {
                Width = 15,
                Height = 15,
                Name = BodyName,
                Source = bi,
            };
            this.RotationBoid();
            this.image = boid;
        }

        public void MoveBoid() {
                    this.RotationBoid();
        }

        private void RotationBoid()
        {
            RotateTransform rotate = new RotateTransform();
            rotate.Angle = this.angle;
            rotate.CenterX = this.pX;
            rotate.CenterY = this.pY;
            this.image.RenderTransform = rotate;
        }

    }
}
