using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impossible_Game
{
    public partial class Form1 : Form
    {
        private ScoreCounter score;
        private float x;
        private float y;
        private Vector2 spawnLocation;
        private Player player;
        private Input input;
        private EnemyContainer enemies;
        private Vector2[] EnemySpawns = new Vector2[]
        {
            new Vector2(70, 50), new Vector2(630, 50),
            new Vector2(70, 450), new Vector2(630, 450)
        };
        private Enemy enemy;
        private Vector2 corner;
        private Random random;
        private InputNetwork inputNetwork;
        private HiddenLayer hiddenLayer;
        private OutputLayer outputLayer;
        private ConnectionMaker ConnectionMaker;
        private List<float> actions;
        private int currentPlayer;
        private string[] playerPaths;
        private string gen;
        private string prevGen;
        private int currentGen;
        public Form1()
        {
            InitializeComponent();
            string currentPlayerS = System.IO.File.ReadAllText(@"C:\Users\Fritz\source\repos\Impossible Game\CurrentPlayer.txt");
            currentPlayer = Int32.Parse(currentPlayerS);
            string currentGenS = System.IO.File.ReadAllText(@"C:\Users\Fritz\source\repos\Impossible Game\CurrentGen.txt");
            currentGen = Int32.Parse(currentGenS);
            Console.WriteLine(currentPlayer);
            Console.WriteLine(currentGen);
            random = new Random();
            score = new ScoreCounter();
            corner = new Vector2(700, 500);
            DoubleBuffered = true;
            x = Width / 2;
            y = Height / 2;
            spawnLocation = new Vector2(x, y);
            player = new Player(spawnLocation, corner);
            inputNetwork = new InputNetwork(player);
            hiddenLayer = new HiddenLayer();
            outputLayer = new OutputLayer();
            enemies = new EnemyContainer();
            enemy = new Enemy(EnemySpawns[0], corner, player);
            inputNetwork.AddBullets(enemy.GetBullets());
            enemies.Add(enemy);
            enemy = new Enemy(EnemySpawns[1], corner, player);
            inputNetwork.AddBullets(enemy.GetBullets());
            enemies.Add(enemy);
            enemy = new Enemy(EnemySpawns[2], corner, player);
            inputNetwork.AddBullets(enemy.GetBullets());
            enemies.Add(enemy);
            enemy = new Enemy(EnemySpawns[3], corner, player);
            inputNetwork.AddBullets(enemy.GetBullets());
            enemies.Add(enemy);
            input = new Input();
            actions = new List<float>();
            timer1.Start();
            timer1.Interval = 1;
            ConnectionMaker = new ConnectionMaker();
            gen = "Gen" + currentGenS;
            prevGen = "Gen" + (currentGen - 1).ToString();
            playerPaths = new string[]
            {
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player0\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player1\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player2\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player3\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player4\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player5\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player6\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player7\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player8\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player9\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player10\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player11\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player12\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player13\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player14\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player15\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player16\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player17\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player18\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player19\"
            };
            string[] playerPathsGen1 = new string[]
{
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player0\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player1\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player2\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player3\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player4\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player5\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player6\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player7\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player8\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player9\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player10\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player11\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player12\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player13\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player14\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player15\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player16\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player17\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player18\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player19\"
};
            string[] outputPathsGen1 = new string[]
            {
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player0\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player1\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player2\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player3\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player4\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player5\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player6\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player7\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player8\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player9\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player10\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player11\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player12\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player13\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player14\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player15\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player16\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player17\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player18\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player19\Output Layer\"
            };
            string[] outputPaths = new string[]
            {
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player0\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player1\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player2\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player3\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player4\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player5\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player6\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player7\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player8\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player9\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player10\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player11\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player12\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player13\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player14\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player15\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player16\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player17\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player18\Output Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player19\Output Layer\"
            };
            string[] hiddenPathsGen1 = new string[]
            {
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player0\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player1\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player2\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player3\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player4\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player5\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player6\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player7\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player8\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player9\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player10\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player11\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player12\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player13\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player14\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player15\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player16\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player17\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player18\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + prevGen + @"\Player19\Hidden Layer\"
            };
            string[] hiddenPaths = new string[]
            {
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player0\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player1\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player2\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player3\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player4\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player5\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player6\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player7\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player8\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player9\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player10\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player11\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player12\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player13\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player14\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player15\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player16\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player17\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player18\Hidden Layer\",
                @"C:\Users\Fritz\source\repos\Impossible Game\" + gen + @"\Player19\Hidden Layer\"
            };
            string[] neuronPaths = new string[]
            {
                "Neuron1.txt",
                "Neuron2.txt",
                "Neuron3.txt",
                "Neuron4.txt",
                "Neuron5.txt",
                "Neuron6.txt",
                "Neuron7.txt",
                "Neuron8.txt"
            };
            string[] neuronPathsO = new string[]
{
                "Neuron1.txt",
                "Neuron2.txt",
                "Neuron3.txt",
                "Neuron4.txt",
                "Neuron5.txt",
                "Neuron6.txt"
};
            if (currentPlayer == 0)
            {
                ConnectionMaker.HiddenLayerFromParents(hiddenPaths, hiddenPathsGen1, ConnectionMaker.TopTen(ConnectionMaker.GetScores(playerPathsGen1)));
                ConnectionMaker.OutputLayerFromParents(outputPaths, outputPathsGen1, ConnectionMaker.TopTen(ConnectionMaker.GetScores(playerPathsGen1)));
            }
            //foreach (string path in outputPaths)
            //{
            //    ConnectionMaker.OutputLayerFromScratch(path);
            //}
            //foreach (string path in hiddenPaths)
            //{
            //    ConnectionMaker.HiddenLayerFromScratch(path);
            //}
            foreach (string path in neuronPaths)
            {
                hiddenLayer.AddNeuron((hiddenPaths[currentPlayer] + path));
            }
            foreach (string path in neuronPathsO)
            {
                outputLayer.AddNeuron((outputPaths[currentPlayer] + path));
            }
            //foreach (int i in ConnectionMaker.TopTen(ConnectionMaker.GetScores(playerPathsGen1)))
            //{
                //Console.WriteLine(i);
            //}
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            player.Draw(e.Graphics);
            enemies.Draw(e.Graphics);
            score.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            input.AddKeyValue(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            input.RemoveKeyValue(e.KeyCode);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score.Update();
            if (score.GetScore() % 700 == 0)
            {
                enemy = new Enemy(EnemySpawns[random.Next(0, 4)], corner, player);
                inputNetwork.AddBullets(enemy.GetBullets());
                enemies.Add(enemy);
            }
            //if (!input.IsPressed(Keys.W) && !input.IsPressed(Keys.S))
            //{
            //    player.StopY();
            //}
            //if (input.IsPressed(Keys.W) && input.IsPressed(Keys.S))
            //{
            //    player.StopY();
            //}
            //if (input.IsPressed(Keys.W) && !input.IsPressed(Keys.S))
            //{
            //    player.Up();
            //}
            //if (!input.IsPressed(Keys.W) && input.IsPressed(Keys.S))
            //{
            //    player.Down();
            //}
            //if (!input.IsPressed(Keys.A) && !input.IsPressed(Keys.D))
            //{
            //    player.StopX();
            //}
            //if (input.IsPressed(Keys.A) && input.IsPressed(Keys.D))
            //{
            //    player.StopX();
            //}
            //if (input.IsPressed(Keys.A) && !input.IsPressed(Keys.D))
            //{
            //    player.Left();
            //}
            //if (!input.IsPressed(Keys.A) && input.IsPressed(Keys.D))
            //{
            //    player.Right();
            //}
            player.Update();
            enemies.Update();
            inputNetwork.Update();
            hiddenLayer.Update(inputNetwork.GetOutputs());
            outputLayer.Update(hiddenLayer.getOutputs());
            actions = outputLayer.GetOutputs();
            if (actions[0] > actions[1] && actions[0] > actions[2])
            {
                player.Up();
            }
            if (actions[1] > actions[0] && actions[1] > actions[2])
            {
                player.Down();
            }
            if (actions[2] > actions[0] && actions[2] > actions[1])
            {
                player.StopY();
            }
            if (actions[3] > actions[4] && actions[3] > actions[5])
            {
                player.Left();
            }
            if (actions[4] > actions[3] && actions[4] > actions[5])
            {
                player.Right();
            }
            if (actions[5] > actions[3] && actions[5] > actions[4])
            {
                player.StopX();
            }
            Invalidate();
            if (player.IsHit())
            {
                timer1.Stop();
                //int position = 200 - (((int)Math.Sqrt(Math.Pow(350 - (double)player.getLocation().getX(), 2) + Math.Pow(250 - (double)player.getLocation().getY(), 2))) / 10);
                string HighScoreS = System.IO.File.ReadAllText(@"C:\Users\Fritz\source\repos\Impossible Game\HighScore.txt");
                int HighScore = Int32.Parse(HighScoreS);
                //string ScoreS = (score.GetScore() + position).ToString();
                string ScoreS = (score.GetScore()).ToString();
                if (player.IsRetarded())
                {
                    ScoreS = ("0");
                }                
                if (score.GetScore() > HighScore)
                {
                    System.IO.File.WriteAllText(@"C:\Users\Fritz\source\repos\Impossible Game\HighScore.txt", ScoreS);
                }
                System.IO.File.WriteAllText(playerPaths[currentPlayer] + "Score.txt", ScoreS);
                currentPlayer++;
                if (currentPlayer == 20)
                {
                    currentGen++;
                    currentPlayer = 0;
                }
                System.IO.File.WriteAllText(@"C:\Users\Fritz\source\repos\Impossible Game\CurrentPlayer.txt", currentPlayer.ToString());
                System.IO.File.WriteAllText(@"C:\Users\Fritz\source\repos\Impossible Game\CurrentGen.txt", currentGen.ToString());
                System.Windows.Forms.Form.ActiveForm.Close();
            }
        }
    }
}
