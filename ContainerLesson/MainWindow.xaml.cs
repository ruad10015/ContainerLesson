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
using System.Windows.Threading;

namespace ContainerLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Canvas
        /// StackPanel
        /// DockPanel
        /// WrapPanel
        /// UniformGrid
        /// Grid
        /// </summary>
        /// 

        private DispatcherTimer _timer;
        private int _myAngle = -90;
        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += _timer_Tick;
           // _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            var tr = new RotateTransform();
            _myAngle+=6;
            tr.Angle=_myAngle;
            //myLabel.RenderTransform = tr;
        }
    }
}
