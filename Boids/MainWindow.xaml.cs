using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Boids
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AddBoids();           
        }

        private void AddBoids()
        {
            for (int i = 0; i < 10; i++)
            {
                Boid boid = new Boid(10, 20, 50,i);
                this.BoidWorld.Children.Add(boid.image);
                Canvas.SetTop(this.BoidWorld.Children[i],20*i);
                Canvas.SetLeft(this.BoidWorld.Children[i], 20 * i);
                
            }
        }

        public void MoveBoids()
        {
            for (int i = 0; i < 20; i++)
            {
                foreach (var boid in BoidWorld.Children)
                {
                    if (boid is Boid)
                    {
                        ((Boid)boid).MoveBoid();
                    }
                }
            }
        }

        private void Empezar_Click(object sender, RoutedEventArgs e)
        {
            this.MoveBoids();
        }
    }
}
