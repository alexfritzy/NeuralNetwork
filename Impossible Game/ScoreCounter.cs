using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Impossible_Game
{
    class ScoreCounter
    {
        private int score;
        private Font font;
        public ScoreCounter()
        {
            score = 0;
            font = new Font("Time New Roman", 20);
        }

        public void Update()
        {
            score++;
        }

        public void Draw(Graphics g)
        {
            g.DrawString(score.ToString(), font, Brushes.Black, 330, 20);
        }

        public int GetScore()
        {
            return score;
        }
    }
}
