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
using System.Windows.Shapes;

namespace WpfApp1.Boards
{
    /// <summary>
    /// Interaction logic for Red.xaml
    /// </summary>
    public partial class Red : Window
    {
        private Shape playerA;
        private Shape playerB;

        private Chain.Handler hTop;
        private Chain.Handler hLeft;
        private Chain.Handler hRight;
        private Chain.Handler hBottom;
        private Chain.Handler hCollision;

        public Red(Shape p1, Shape p2)
        {
            InitializeComponent();

            playerA = p1;
            playerB = p2;

            gridBoard.Children.Add(playerA);
            gridBoard.Children.Add(playerB);

            playerA.Margin = new Thickness(-this.Width / 2, -this.Height / 2, 0, 0);
            playerA.Margin = new Thickness(this.Width / 2, this.Height / 2, 0, 0);

            hTop = new Chain.TopHandler();
            hLeft = new Chain.LeftHandler();
            hRight = new Chain.RightHandler();
            hBottom = new Chain.BottomHandler();
            hCollision = new Chain.CollisionHandler();

            hTop.SetSuccessor(hLeft);
            hLeft.SetSuccessor(hRight);
            hRight.SetSuccessor(hBottom);
            hBottom.SetSuccessor(hCollision);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.Equals(Key.W))
            {
                playerA.Margin = new Thickness(playerA.Margin.Left, playerA.Margin.Top - 1, 0, 0);
            }
            if (e.Key.Equals(Key.S))
            {
                playerA.Margin = new Thickness(playerA.Margin.Left, playerA.Margin.Top + 1, 0, 0);
            }
            if (e.Key.Equals(Key.A))
            {
                playerA.Margin = new Thickness(playerA.Margin.Left - 1, playerA.Margin.Top, 0, 0);
            }
            if (e.Key.Equals(Key.D))
            {

                playerA.Margin = new Thickness(playerA.Margin.Left + 1, playerA.Margin.Top, 0, 0);
            }


            if (e.Key.Equals(Key.Up))
            {
                playerB.Margin = new Thickness(playerB.Margin.Left, playerB.Margin.Top - 1, 0, 0);
            }
            if (e.Key.Equals(Key.Down))
            {
                playerB.Margin = new Thickness(playerB.Margin.Left, playerB.Margin.Top + 1, 0, 0);
            }
            if (e.Key.Equals(Key.Left))
            {
                playerB.Margin = new Thickness(playerB.Margin.Left - 1, playerB.Margin.Top, 0, 0);
            }
            if (e.Key.Equals(Key.Right))
            {
                playerB.Margin = new Thickness(playerB.Margin.Left + 1, playerB.Margin.Top, 0, 0);
            }



            hTop.HandleRequest(playerA.Margin, playerB.Margin);

            this.Title = playerA.Margin.Top + " " + playerA.Margin.Left + " " + playerB.Margin.Top + " " + playerB.Margin.Left;
        }
    }
}
