using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace PJT_mini15
{
    enum STONE { none, black, white };
    public partial class Form1 : Form
    {
        int margin = 40;
        int 눈Size = 30;  // 눈금 크기
        int 돌Size = 20;  // 바둑돌 크기
        int 화점Size = 10; // 화점 크기

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        
        STONE[,] 바둑판 = new STONE[19,19];   
        bool flag = false;  // false = 검은돌, true = 흰돌

        bool imageFlag = false;

        int stoneCnt = 1; // 수순
        Font font = new Font("맑은 고딕", 10);
        private bool sequenceFlag;

        int sequence = 0;         // 복기에 사용되는 순서
        bool reviveFlag = false;  // 복기모드를 알려주는 것

        List<Revive> lstRevive = new List<Revive>(); // 리스트
        private string dirName; // 게임을 저장하기 위한 디렉토리 이름

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Orange;

            pen = new Pen(Color.Black);
            bBrush = new SolidBrush(Color.Black);
            wBrush = new SolidBrush(Color.White);

            this.ClientSize = new Size(2 * margin + 18 * 눈Size,
                2 * margin + 18 * 눈Size + menuStrip1.Height);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBoard();  // 바둑판을 그립니다
            DrawStones();  // 바둑돌을 그립니다 (추가)
        }

        

        private void DrawBoard()
        {
            g = panel1.CreateGraphics();

            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + i * 눈Size, margin),  // 세로선
                    new Point(margin + i * 눈Size, margin + 18 * 눈Size));
                g.DrawLine(pen, new Point(margin, margin + i * 눈Size),  // 가로선
                    new Point(margin + 18 * 눈Size, margin + i * 눈Size));
            }

            // 화점 그리기
            for (int x = 3; x <= 15; x +=6)
                for (int y = 3; y <= 15; y +=6)
                {
                    g.FillEllipse(bBrush,
                        margin + 눈Size * x - 화점Size / 2,
                        margin + 눈Size * y - 화점Size / 2,
                        화점Size, 화점Size);
                }
        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (reviveFlag == true)
            {
                ReviveGame();
                return;
            }

            // e.X는 픽셀 단위, x는 바둑판 좌표
            int x = (e.X - margin + 눈Size / 2) / 눈Size;
            int y = (e.Y - margin + 눈Size / 2) / 눈Size;

            if (바둑판[x, y] != STONE.none) 
                return;

            STONE stoneColor;

            if (flag == false)  // 검은돌 차례
            {
                stoneColor = STONE.black;
                flag = true;
            }
            else
            {
                stoneColor = STONE.white;
                flag = false;
            }

            Revive aStone = new Revive(x, y, stoneColor, stoneCnt++);
            lstRevive.Add(aStone);
            DrawAStone(aStone);

            // 바둑판[x, y]에 돌을 그리기 위한 Rectangle
            /*
            Rectangle r = new Rectangle(margin + 눈Size * x - 돌Size / 2,
                margin + 눈Size * y - 돌Size / 2, 돌Size, 돌Size);

            // 검은돌 차례
            if (flag == false)
            {
                if (imageFlag == false)
                    g.FillEllipse(bBrush, r);
                else
                {
                    Bitmap bmp = new Bitmap("D:\\CookC#\\images\\black.png");
                    g.DrawImage(bmp, r);
                }
                DrawStoneSequence(stoneCnt++, Brushes.White, r);
                lstRevive.Add(new Revive(x, y, STONE.black, stoneCnt));
                flag = true;
                바둑판[x, y] = STONE.black;
            }
            else  // 흰돌 차례
            {
                if (imageFlag == false)
                    g.FillEllipse(wBrush, r);
                else
                {
                    Bitmap bmp = new Bitmap("D:\\CookC#\\images\\white.png");
                    g.DrawImage(bmp, r);
                }
                DrawStoneSequence(stoneCnt++, Brushes.Black, r);
                lstRevive.Add(new Revive(x, y, STONE.white, stoneCnt));
                flag = true;
                바둑판[x, y] = STONE.white;
            }

            CheckOmok(x, y);
            */
        }


        // 복기 리스트에 있는 내용을 하나씩 그려준다
        private void ReviveGame()
        {
            if (sequence < lstRevive.Count)
            {
                DrawAStone(lstRevive[sequence++]);
            }
        }

        private void DrawAStone(Revive item)
        {
            int x = item.X;
            int y = item.Y;
            STONE s = item.Stone;
            int seq = item.Seq;

            Rectangle r = new Rectangle(margin + 눈Size * x - 돌Size / 2,
                margin + 눈Size * y - 돌Size / 2, 돌Size, 돌Size);

            if (s == STONE.black)
            {
                if (imageFlag == false)
                    g.FillEllipse(bBrush, r);
                else 
                {
                    Bitmap bmp = new Bitmap("D:\\CookC#\\images\\black.png");
                    g.DrawImage(bmp, r);
                }
                DrawStoneSequence(seq, Brushes.White, r);
                바둑판[x, y] = STONE.black;
            }
            else
            {
                if (imageFlag == false)
                    g.FillEllipse(wBrush, r);
                else
                {
                    Bitmap bmp = new Bitmap("D:\\CookC#\\images\\white.png");
                    g.DrawImage(bmp, r);
                }
                DrawStoneSequence(seq, Brushes.Black, r);
                바둑판[x, y] = STONE.white;
            }
            CheckOmok(x, y);
        }

        private void DrawStoneSequence(int v, Brush color, Rectangle r)
        {
            if (sequenceFlag == true)
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                g.DrawString(v.ToString(), font, color, r, stringFormat);
            }
        }

        private void 복기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = dirName;
            ofd.Filter = "Omok files(*.omk)|*.omk";
            ofd.ShowDialog();
            string fileName = ofd.FileName;
            sequenceFlag = true;

            InitializeOmok();  // 현재 게임 중이라면 초기화

            try
            {
                StreamReader r = File.OpenText(fileName);
                string line = "";

                // 파일 내용을 한줄씩 읽어서 lstRevive 리스트에 넣는다
                while ((line = r.ReadLine()) != null)
                {
                    string[] items = line.Split(' ');
                    Revive rev = new Revive(
                        int.Parse(items[0]), int.Parse(items[1]),
                        items[2] == "black" ? STONE.black : STONE.white,
                        int.Parse(items[3]));
                    lstRevive.Add(rev);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reviveFlag = true; // 복기 준비
            sequence = 0;  // 복기 수순 초기화
        }

        private void 다시시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeOmok();
        }

        private void 그리기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFlag = false;
        }

        private void 이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFlag = true;
        }

        private void 표시ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sequenceFlag = true;
        }

        private void 표시안함ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sequenceFlag = false;
        }

        // 자료구조에서 바둑돌의 값을 읽어서 다시 그려줍니다
        private void DrawStones()
        {
            foreach (var stone in lstRevive)
            {
                DrawAStone(stone);
            }

            /*
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    if (바둑판[x, y] == STONE.white)
                        if (imageFlag == false)
                         g.FillEllipse(wBrush, margin + x * 눈Size - 돌Size /2,
                             margin + y * 눈Size - 돌Size /2, 돌Size, 돌Size);
                        else
                        {
                            Bitmap bmp = new Bitmap("D:\\CookC#\\images\\white.png");
                            g.DrawImage(bmp, margin + x * 눈Size - 돌Size / 2,
                                margin + y * 눈Size - 돌Size /2, 돌Size, 돌Size );
                        }

                    else if (바둑판[x, y] == STONE.black)
                        if (imageFlag == false)
                            g.FillEllipse(bBrush, margin + x * 눈Size - 돌Size / 2,
                                margin + y * 눈Size - 돌Size / 2, 돌Size, 돌Size);
                        else
                        {
                            Bitmap bmp = new Bitmap("D:\\CookC#\\images\\black.png");
                            g.DrawImage(bmp, margin + x * 눈Size - 돌Size / 2,
                                margin + y * 눈Size - 돌Size / 2, 돌Size, 돌Size);
                        }
            */
        }

        // 오목 체크하는 메소드
        private void CheckOmok(int x, int y)
        {
            int cnt = 1;

            // 오른쪽 방향
            for (int i = x + 1; i <= 18; i++)
                if (바둑판[i, y] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            // 왼쪽방향
            for (int i = x - 1; i >= 0; i--)
                if (바둑판[i, y] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }

            cnt = 1;

            // 아래 방향
            for (int i = y + 1; i <= 18; i++)
                if (바둑판[x, i] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            // 위 방향
            for (int i = y - 1; i >= 0; i--)
                if (바둑판[x, i] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }

            cnt = 1;

            // 대각선 오른쪽 위방향
            for (int i = x + 1, j = y - 1; i <= 18 && j >= 0; i++, j--)
                if (바둑판[i, j] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            // 대각선 왼쪽 아래 방향
            for (int i = x - 1, j = y + 1; i >= 0 && j <= 18; i--, j++)
                if (바둑판[i, j] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }

            cnt = 1;

            // 대각선 왼쪽 위방향
            for (int i = x - 1, j = y - 1; i >= 0 && j >= 0; i--, j--)
                if (바둑판[i, j] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            // 대각선 오른쪽 아래 방향
            for (int i = x + 1, j = y + 1; i <= 18 && j <= 18; i++, j++)
                if (바둑판[i, j] == 바둑판[x, y])
                    cnt++;
                else
                    break;

            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
        }

        private void OmokComplete(int x, int y)
        {
            SaveGame();
            DialogResult res = MessageBox.Show(바둑판[x, y].ToString().ToUpper()
                + " Wins!\n새로운 게임을 시작할까요", "게임종료", 
                MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                NewGame();
            else if (res == DialogResult.No)
                this.Close();
        }

        

        private void NewGame()
        {
            imageFlag = true;
            flag = false;

            for (int x = 0; x < 19; x++) 
                for (int y = 0; y < 19; y++)
                    바둑판[x, y] = STONE.none;

            panel1.Refresh();
            DrawBoard();
        }

        

        private void SaveGame()
        {
            if (reviveFlag == true)
                return;

            string documentPath =
                Path.Combine(Environment.ExpandEnvironmentVariables
                ("%userprofile%"), "Documents").ToString();
            dirName = documentPath + "/Omok/";

            if (!Directory.Exists(dirName))
                Directory.CreateDirectory(dirName);

            string fileName = dirName + DateTime.Now.ToShortDateString()
                + "-" + DateTime.Now.Hour + DateTime.Now.Minute + ".omk";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            foreach (Revive item in lstRevive)
            {
                sw.WriteLine("{0} {1} {2} {3}", item.X, item.Y, item.Stone, item.Seq);
            }

            sw.Close();
            fs.Close();
        }

        private void InitializeOmok()
        {
            flag = false;  // 검은돌부터 시작
            reviveFlag = false;  // 복기 모드 false
            Clear바둑판();
            lstRevive.Clear();
            stoneCnt = 1;
            panel1.Refresh();
            DrawBoard();
        }

        private void Clear바둑판()
        {
            for (int x = 0; x < 19; x++)
                for (int y = 0; y < 19; y++)
                    바둑판[x, y] = STONE.none;
        }


    }
}
