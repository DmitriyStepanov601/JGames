using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JGames
{
    public partial class FormGame : Form
    {
        public static String Fifteen = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\15.exe";
        public static String Puz = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\Puzzle.exe";
        public static String Mem = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\Memory.exe";
        public static String TicTac = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\TicTacToe.exe";
        public static String Row4 = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\ConnectFour.exe";
        public static String Numbers = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\2048.exe";
        public static String Mine = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\MineSweeper.exe";
        public static String Piton = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\Snake.exe";
        public static String Rev = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\Reversi.exe";
        public static String Shash = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\Checkers.exe";
        public static String Ball = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\Balls.exe";
        public static String Figure = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\Tetris.exe";
        public static String Breaker = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\BrickBreaker.exe";
        public static String PongPong = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\Pong.exe";
        public static String Bird = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\FlappyBird.exe";

        byte[] Game15 = Properties.Resources._151;
        byte[] GamePuzzle = Properties.Resources.Puzzle1;
        byte[] GameMemory = Properties.Resources.Memory1;
        byte[] GameTicTacToe = Properties.Resources.TicTacToe1;
        byte[] Game4Row = Properties.Resources.ConnectFour1;
        byte[] Game2048 = Properties.Resources._20481;
        byte[] GameMiner = Properties.Resources.MineSweeper1;
        byte[] GameSnake = Properties.Resources.Snake1;
        byte[] GameReversi = Properties.Resources.Reversi1;
        byte[] GameShashki = Properties.Resources.Checkers1;
        byte[] GameBalls = Properties.Resources.Balls1;
        byte[] GameTetr = Properties.Resources.Tetris1;
        byte[] GameBrick = Properties.Resources.BrickBreaker1;
        byte[] GamePong = Properties.Resources.Pong1;
        byte[] GameFlappy = Properties.Resources.FlappyBird1;

        public FormGame()
        {
            InitializeComponent();

            Pyatnashki.Click += (s, a) => { Run(Fifteen, Game15); };
            Puzzle.Click += (s, a) => { Run(Puz, GamePuzzle); };
            Memory.Click += (s, a) => { Run(Mem, GameMemory); };
            KrestikiNoliki.Click += (s, a) => { Run(TicTac, GameTicTacToe); };
            Fourtorow.Click += (s, a) => { Run(Row4, Game4Row); };
            Dvenolfoureight.Click += (s, a) => { Run(Numbers, Game2048); };
            Miner.Click += (s, a) => { Run(Mine, GameMiner); };
            Snake.Click += (s, a) => { Run(Piton, GameSnake); };
            Reversi.Click += (s, a) => { Run(Rev, GameReversi); };
            Shashki.Click += (s, a) => { Run(Shash, GameShashki); };
            Balls.Click += (s, a) => { Run(Ball, GameBalls); };
            Tetris.Click += (s, a) => { Run(Figure, GameTetr); };
            BrickBreaker.Click += (s, a) => { Run(Breaker, GameBrick); };
            Pong.Click += (s, a) => { Run(PongPong, GamePong); };
            Flappybird.Click += (s, a) => { Run(Bird, GameFlappy); };
        }

        public void Run(String app, byte[] gameapp)
        {
            FileStream fs = new FileStream(app, FileMode.Create, FileAccess.Write);
            fs.Write(gameapp, 0, gameapp.Length);
            fs.Close();
            Process.Start(app);
        }

    }
}
