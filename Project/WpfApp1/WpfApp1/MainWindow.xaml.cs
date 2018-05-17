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

namespace WpfApp1
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
            Shape p1;
            Shape p2;
            if (Player1Ellipse.IsChecked == true)
                p1 = new Ellipse();
            else
                p1 = new Rectangle();

            if (Player2Ellipse.IsChecked == true)
                p2 = new Ellipse();
            else
                p2 = new Rectangle();

            p1.Height = double.Parse(Player1Height.Text);
            p1.Width = double.Parse(Player1Width.Text);

            p2.Height = double.Parse(Player2Height.Text);
            p2.Width = double.Parse(Player2Width.Text);

            Decorator.PlayerA playerA = new Decorator.PlayerA();
            playerA.player = p1;
            Decorator.DecoratorMagenta decoratorMagenta = new Decorator.DecoratorMagenta();
            decoratorMagenta.SetComponent(playerA);
            decoratorMagenta.Operation();

            Decorator.PlayerB playerB = new Decorator.PlayerB();
            playerB.player = p2;
            Decorator.DecoratorYellow decoratorYellow = new Decorator.DecoratorYellow();
            decoratorYellow.SetComponent(playerB);
            decoratorYellow.Operation();

            Adapter.Adapter adapter = new Adapter.Adapter(new Adapter.SquareAdapter());
            var p1a = adapter.Request(p1);

            adapter = new Adapter.Adapter(new Adapter.EllipseAdapter());
            var p2a = adapter.Request(p2);

            Button btn = (Button)e.Source;
            Window newBoard;
            if (btn.Content.ToString().ToUpper()=="CZERWONA")
                newBoard = Boards.FactoryBoards.getInstance().createWindow("RED", p1, p2);
            else if (btn.Content.ToString().ToUpper() == "ZIELONA")
                newBoard = Boards.FactoryBoards.getInstance().createWindow("GREEN", p1a, p2a);
            else
                newBoard = Boards.FactoryBoards.getInstance().createWindow("BLUE", p1a, p2a);

            newBoard.Show();


            ////Ellipse p1 = new Ellipse();
            //Rectangle p1 = new Rectangle();
            //p1.Height = 50;
            //p1.Width = 20;
            //Ellipse p2 = new Ellipse();
            //p2.Height = 20;
            //p2.Width = 10;

            //Decorator.PlayerA playerA = new Decorator.PlayerA();
            //playerA.player = p1;
            //Decorator.DecoratorMagenta decoratorMagenta = new Decorator.DecoratorMagenta();
            //decoratorMagenta.SetComponent(playerA);
            //decoratorMagenta.Operation();

            //Decorator.PlayerB playerB = new Decorator.PlayerB();
            //playerB.player = p2;
            //Decorator.DecoratorYellow decoratorYellow = new Decorator.DecoratorYellow();
            //decoratorYellow.SetComponent(playerB);
            //decoratorYellow.Operation();

            //Adapter.Adapter adapter = new Adapter.Adapter(new Adapter.SquareAdapter());
            //var p1a = adapter.Request(p1);

            //adapter = new Adapter.Adapter(new Adapter.EllipseAdapter());
            //var p2a = adapter.Request(p2);

            //var newBoard = Boards.FactoryBoards.getInstance().createWindow("RED", p1a, p2a);

            //newBoard.Show();
        }
    }
}
