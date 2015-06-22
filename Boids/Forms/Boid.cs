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
        private int pX;
        private int pY;
        private double angle;

        public Boid(int pX, int pY, double angle)
        {
            this.pX = pX;
            this.pY = pY;
            this.angle = angle;
        }

        public Image DrawBoid(int count)
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
           
            return boid;
        }

        public void MoveBoid(ref Canvas BoidWorld) {
          
        }

    }
}
