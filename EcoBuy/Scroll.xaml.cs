using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ScrollScrollViewTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button newButton = new Button { Content = "New Button" };
            panel.Children.Add(newButton);
            WaitFor(TimeSpan.Zero, DispatcherPriority.ApplicationIdle);

            double scrollViewerTopRightPointX = scrollViewer.PointToScreen(new Point()).X + scrollViewer.ActualWidth;

            // Scroll target item into view
            while (scrollViewerTopRightPointX < newButton.PointToScreen(new Point()).X + newButton.ActualWidth)
            {
                scrollViewer.LineRight();
                WaitFor(TimeSpan.Zero, DispatcherPriority.ApplicationIdle);
            }
        }
        private void WaitFor(TimeSpan time, DispatcherPriority priority)
        {
            DispatcherTimer timer = new DispatcherTimer(priority);
            timer.Tick += new EventHandler(OnDispatched);
            timer.Interval = time;
            DispatcherFrame dispatcherFrame = new DispatcherFrame(false);
            timer.Tag = dispatcherFrame;
            timer.Start();
            Dispatcher.PushFrame(dispatcherFrame);
        }
        private void OnDispatched(object sender, EventArgs args)
        {
            DispatcherTimer timer = (DispatcherTimer)sender;
            timer.Tick -= new EventHandler(OnDispatched);
            timer.Stop();
            DispatcherFrame frame = (DispatcherFrame)timer.Tag;
            frame.Continue = false;
        }
    }
}