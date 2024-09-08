using System.Text;
using System.Text.RegularExpressions;
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

namespace PJT_mini11_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button first;
        Button second;
        DispatcherTimer myTimer = new DispatcherTimer();
        int matched = 0;
        int[] rnd = new int[16];

        public MainWindow()
        {
            InitializeComponent();
            BoardSet();
            myTimer.Interval = new TimeSpan(0, 0, 0, 0, 750);
            myTimer.Tick += MyTimer_Tick;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            first.Content = MakeImage("D:\\CookC#\\images\\check.png");
            second.Content = MakeImage("D:\\CookC#\\images\\check.png");
            first = null;
            second = null;
        }

        private void BoardSet()
        {
            for (int i = 0; i < 16; i++)
            {
                Button c = new Button();
                c.Background = Brushes.White;
                c.Margin = new Thickness(10);
                c.Content = MakeImage("D:\\CookC#\\images\\check.png");
                c.Tag = TagSet();   // 이 문장이 중요, 그림의 인덱스
                c.Click += C_Click;
                board.Children.Add(c);
            }
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            string[] icon = { "딸기", "레몬", "모과", "배", "사과", "수박", "파인애플", "포도" };

            btn.Content = MakeImage("D:\\CookC#\\images\\" + icon[(int)btn.Tag] + ".png");

            // 두개의 버튼을 순서대로 눌렀을 때 처리
            if (first == null) // 지금 누른 버튼이 첫번째 버튼
            {
                first = btn;
                return;
            }
            second = btn;

            if ((int)first.Tag == (int)second.Tag) // 매치가 되었을 때
            {
                first = null;
                second = null;
                matched += 2;
                if (matched >= 16)
                {
                    MessageBoxResult res = MessageBox.Show("성공! 다시 하시겠습니까?", "Success", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes)
                    {
                        NewGame();
                    }
                    else
                        Close();
                }
            }
            else // 매치가 안되었을 때는 다시 덮어주어야 한다
            {
                myTimer.Start();
            }
        }

        private void NewGame()
        {
            for (int i = 0; i < 16; i++)
                rnd[i] = 0;
            board.Children.Clear();
            BoardSet();
            matched = 0;
        }

        private int TagSet()
        {
            int i;
            Random r = new Random();
            while (true)
            {
                i = r.Next(16); // 0~15까지
                if (rnd[i] == 0)
                {
                    rnd[i] = 1;
                    break;
                }
            }
            return i % 8; // 태그는 0~7까지, 8개의 그림을 표시
        }

        private Image MakeImage(string v)
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(v, UriKind.Absolute);
            bi.EndInit();

            Image myImage = new Image();
            myImage.Margin = new Thickness(10);
            myImage.Stretch = Stretch.Fill;
            myImage.Source = bi;

            return myImage;
        }
    }
}