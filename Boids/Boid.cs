using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Boids
{
    class Boid
    {
        private int pX;
        private int pY;
        private double angle { get; set; }

        public Boid(int pX, int pY, double angle)
        {
            this.pX = pX;
            this.pY = pY;
            this.angle = angle;
        }

        public Image DrawBoid()
        {
            string BodyName = "/Images/Boid.png";
            Image BodyImage = new Image
            {
                Width = 20,
                Height = 20,
                Name = ""
            };
            return null;
        }
    }
}
