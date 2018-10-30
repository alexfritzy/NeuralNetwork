using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impossible_Game
{
    class ConnectionMaker
    {
        public ConnectionMaker()
        {
        }

        public void HiddenLayerFromScratch(string path)
        {
            Random random = new Random();
            float connection;
            List<string> writing = new List<string>();
            List<float> Neuron1 = new List<float>();
            Neuron1.Add(random.Next(-10, 1));
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    connection = (float)(random.Next(-400, 401));
                    connection = connection / 100;
                    Neuron1.Add(connection);
                }
            }
            foreach (float f in Neuron1)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron1.txt"), writing);
            writing = new List<string>();
            List<float> Neuron2 = new List<float>();
            Neuron2.Add(random.Next(-10, 1));
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    connection = (float)(random.Next(-400, 401));
                    connection = connection / 100;
                    Neuron2.Add(connection);
                }
            }
            foreach (float f in Neuron2)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron2.txt"), writing);
            writing = new List<string>();
            List<float> Neuron3 = new List<float>();
            Neuron3.Add(random.Next(-10, 1));
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    connection = (float)(random.Next(-400, 401));
                    connection = connection / 100;
                    Neuron3.Add(connection);
                }
            }
            foreach (float f in Neuron3)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron3.txt"), writing);
            writing = new List<string>();
            List<float> Neuron4 = new List<float>();
            Neuron4.Add(random.Next(-10, 1));
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    connection = (float)(random.Next(-400, 401));
                    connection = connection / 100;
                    Neuron4.Add(connection);
                }
            }
            foreach (float f in Neuron4)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron4.txt"), writing);
            writing = new List<string>();
            List<float> Neuron5 = new List<float>();
            Neuron5.Add(random.Next(-10, 1));
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    connection = (float)(random.Next(-400, 401));
                    connection = connection / 100;
                    Neuron5.Add(connection);
                }
            }
            foreach (float f in Neuron5)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron5.txt"), writing);
            writing = new List<string>();
            List<float> Neuron6 = new List<float>();
            Neuron6.Add(random.Next(-10, 1));
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    connection = (float)(random.Next(-400, 401));
                    connection = connection / 100;
                    Neuron6.Add(connection);
                }
            }
            foreach (float f in Neuron6)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron6.txt"), writing);
            writing = new List<string>();
            List<float> Neuron7 = new List<float>();
            Neuron7.Add(random.Next(-10, 1));
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    connection = (float)(random.Next(-400, 401));
                    connection = connection / 100;
                    Neuron7.Add(connection);
                }
            }
            foreach (float f in Neuron7)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron7.txt"), writing);
            writing = new List<string>();
            List<float> Neuron8 = new List<float>();
            Neuron8.Add(random.Next(-10, 1));
            for (int y = -20; y <= 20; y = y + 4)
            {
                for (int x = -20; x <= 20; x = x + 4)
                {
                    connection = (float)(random.Next(-400, 401));
                    connection = connection / 100;
                    Neuron8.Add(connection);
                }
            }
            foreach (float f in Neuron8)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron8.txt"), writing);
        }
        public void OutputLayerFromScratch(string path)
        {
            Random random = new Random();
            float connection;
            List<string> writing = new List<string>();
            List<float> Neuron1 = new List<float>();
            Neuron1.Add(random.Next(-10, 1));
            for (int y = 0; y < 8; y++)
            { 
                connection = (float)(random.Next(-400, 401));
                connection = connection / 100;
                Neuron1.Add(connection);
            }
            foreach (float f in Neuron1)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron1.txt"), writing);
            writing = new List<string>();
            List<float> Neuron2 = new List<float>();
            Neuron2.Add(random.Next(-10, 1));
            for (int y = 0; y < 8; y++)
            {
                connection = (float)(random.Next(-400, 401));
                connection = connection / 100;
                Neuron2.Add(connection);
            }
            foreach (float f in Neuron2)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron2.txt"), writing);
            writing = new List<string>();
            List<float> Neuron3 = new List<float>();
            Neuron3.Add(random.Next(-10, 1));
            for (int y = 0; y < 8; y++)
            {
                connection = (float)(random.Next(-400, 401));
                connection = connection / 100;
                Neuron3.Add(connection);
            }
            foreach (float f in Neuron3)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron3.txt"), writing);
            writing = new List<string>();
            List<float> Neuron4 = new List<float>();
            Neuron4.Add(random.Next(-10, 1));
            for (int y = 0; y < 8; y++)
            {
                connection = (float)(random.Next(-400, 401));
                connection = connection / 100;
                Neuron4.Add(connection);
            }
            foreach (float f in Neuron4)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron4.txt"), writing);
            writing = new List<string>();
            List<float> Neuron5 = new List<float>();
            Neuron5.Add(random.Next(-10, 1));
            for (int y = 0; y < 8; y++)
            {
                connection = (float)(random.Next(-400, 401));
                connection = connection / 100;
                Neuron5.Add(connection);
            }
            foreach (float f in Neuron5)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron5.txt"), writing);
            writing = new List<string>();
            List<float> Neuron6 = new List<float>();
            Neuron6.Add(random.Next(-10, 1));
            for (int y = 0; y < 8; y++)
            {
                connection = (float)(random.Next(-400, 401));
                connection = connection / 100;
                Neuron6.Add(connection);
            }
            foreach (float f in Neuron6)
            {
                writing.Add(f.ToString());
            }
            System.IO.File.WriteAllLines((path + "Neuron6.txt"), writing);
        }
        public List<int> GetScores(string[] paths)
        {
            List<int> scores = new List<int>();
            foreach (string path in paths)
            {
                string scoreS = System.IO.File.ReadAllText(path + "Score.txt");
                int score = Int32.Parse(scoreS);
                scores.Add(score);
            }
            return scores;
        }
        public List<int> TopTen(List<int> scores)
        {
            List<int> topPlayers = new List<int>();
            List<int> temp = new List<int>();
            foreach (int i in scores)
            {
                temp.Add(i);
            }
            temp.Sort();
            for (int i = 10; i < 20; i++)
            {
                for (int x = 0; x < 20; x++)
                {
                    if (temp[i] == scores[x])
                        topPlayers.Add(x);
                }
            }
            return topPlayers;
        }
        public void HiddenLayerFromParents(string[] newPaths, string[] oldPaths, List<int> parents)
        {
            Random random = new Random();
            List<int> parentNumbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            for (int i = 0; i < parentNumbers.Count; i++)
            {
                int temp = parentNumbers[i];
                int index = random.Next(20);
                parentNumbers[i] = parentNumbers[index];
                parentNumbers[index] = temp;
            }
            int parent = 0;
            int parento = parent + 1;
            foreach (string path in newPaths)
            {
                float connection;
                string[] parent1;
                string[] parent2;
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron1.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron1.txt");
                List<string> Neuron1 = new List<string>();
                int gene;
                gene = random.Next(0, 21);
                if (gene < 10)
                    Neuron1.Add(parent1[0]);
                else if (gene > 9 && gene < 20)
                    Neuron1.Add(parent2[0]);
                else if (gene == 20)
                {
                    connection = (float)(random.Next(-15, 1));
                    Neuron1.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 101);
                    if (gene < 50)
                        Neuron1.Add(parent1[i]);
                    else if (gene > 49 && gene < 100)
                        Neuron1.Add(parent2[i]);
                    else if (gene == 100)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron1.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron1.txt"), Neuron1);
                List<string> Neuron2 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron2.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron2.txt");
                gene = random.Next(0, 21);
                if (gene < 10)
                    Neuron2.Add(parent1[0]);
                else if (gene > 9 && gene < 20)
                    Neuron2.Add(parent2[0]);
                else if (gene == 20)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron2.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 101);
                    if (gene < 50)
                        Neuron2.Add(parent1[i]);
                    else if (gene > 49 && gene < 100)
                        Neuron2.Add(parent2[i]);
                    else if (gene == 100)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron2.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron2.txt"), Neuron2);
                List<string> Neuron3 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron3.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron3.txt");
                gene = random.Next(0, 21);
                if (gene < 10)
                    Neuron3.Add(parent1[0]);
                else if (gene > 9 && gene < 20)
                    Neuron3.Add(parent2[0]);
                else if (gene == 20)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron3.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 101);
                    if (gene < 50)
                        Neuron3.Add(parent1[i]);
                    else if (gene > 49 && gene < 100)
                        Neuron3.Add(parent2[i]);
                    else if (gene == 100)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron3.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron3.txt"), Neuron3);
                List<string> Neuron4 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron4.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron4.txt");
                gene = random.Next(0, 21);
                if (gene < 10)
                    Neuron4.Add(parent1[0]);
                else if (gene > 9 && gene < 20)
                    Neuron4.Add(parent2[0]);
                else if (gene == 20)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron4.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 101);
                    if (gene < 50)
                        Neuron4.Add(parent1[i]);
                    else if (gene > 49 && gene < 100)
                        Neuron4.Add(parent2[i]);
                    else if (gene == 100)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron4.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron4.txt"), Neuron4);
                List<string> Neuron5 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron5.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron5.txt");
                gene = random.Next(0, 21);
                if (gene < 10)
                    Neuron5.Add(parent1[0]);
                else if (gene > 9 && gene < 20)
                    Neuron5.Add(parent2[0]);
                else if (gene == 20)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron5.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 101);
                    if (gene < 50)
                        Neuron5.Add(parent1[i]);
                    else if (gene > 49 && gene < 100)
                        Neuron5.Add(parent2[i]);
                    else if (gene == 100)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron5.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron5.txt"), Neuron5);
                List<string> Neuron6 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron6.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron6.txt");
                gene = random.Next(0, 21);
                if (gene < 10)
                    Neuron6.Add(parent1[0]);
                else if (gene > 9 && gene < 20)
                    Neuron6.Add(parent2[0]);
                else if (gene == 20)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron6.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 101);
                    if (gene < 50)
                        Neuron6.Add(parent1[i]);
                    else if (gene > 49 && gene < 100)
                        Neuron6.Add(parent2[i]);
                    else if (gene == 100)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron6.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron6.txt"), Neuron6);
                List<string> Neuron7 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron7.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron7.txt");
                gene = random.Next(0, 21);
                if (gene < 10)
                    Neuron7.Add(parent1[0]);
                else if (gene > 9 && gene < 20)
                    Neuron7.Add(parent2[0]);
                else if (gene == 20)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron7.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 101);
                    if (gene < 50)
                        Neuron7.Add(parent1[i]);
                    else if (gene > 49 && gene < 100)
                        Neuron7.Add(parent2[i]);
                    else if (gene == 100)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron7.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron7.txt"), Neuron7);
                List<string> Neuron8 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron8.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron8.txt");
                gene = random.Next(0, 21);
                if (gene < 10)
                    Neuron8.Add(parent1[0]);
                else if (gene > 9 && gene < 20)
                    Neuron8.Add(parent2[0]);
                else if (gene == 20)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron8.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 101);
                    if (gene < 50)
                        Neuron8.Add(parent1[i]);
                    else if (gene > 49 && gene < 100)
                        Neuron8.Add(parent2[i]);
                    else if (gene == 100)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron8.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron8.txt"), Neuron8);
                parent = parent + 2;
                if (parent == 10)
                    parent = 1;
                if (parent == 11)
                    parent = 0;
                parento = parent + 1;
                if (parent == 9)
                    parento = 0;
            }
        }
        public void OutputLayerFromParents(string[] newPaths, string[] oldPaths, List<int> parents)
        {
            Random random = new Random();
            List<int> parentNumbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            for (int i = 0; i < parentNumbers.Count; i++)
            {
                int temp = parentNumbers[i];
                int index = random.Next(20);
                parentNumbers[i] = parentNumbers[index];
                parentNumbers[index] = temp;
            }
            int parent = 0;
            int parento = parent + 1;
            foreach (string path in newPaths)
            {
                float connection;
                string[] parent1;
                string[] parent2;
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron1.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron1.txt");
                List<string> Neuron1 = new List<string>();
                int gene;
                gene = random.Next(0, 11);
                if (gene < 5)
                    Neuron1.Add(parent1[0]);
                if (gene > 4 && gene < 10)
                    Neuron1.Add(parent2[0]);
                if (gene == 10)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron1.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 11);
                    if (gene < 5)
                        Neuron1.Add(parent1[i]);
                    if (gene > 4 && gene < 10)
                        Neuron1.Add(parent2[i]);
                    if (gene == 10)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron1.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron1.txt"), Neuron1);
                List<string> Neuron2 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron2.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron2.txt");
                gene = random.Next(0, 11);
                if (gene < 5)
                    Neuron2.Add(parent1[0]);
                if (gene > 4 && gene < 10)
                    Neuron2.Add(parent2[0]);
                if (gene == 10)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron2.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 11);
                    if (gene < 5)
                        Neuron2.Add(parent1[i]);
                    if (gene > 4 && gene < 10)
                        Neuron2.Add(parent2[i]);
                    if (gene == 10)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron2.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron2.txt"), Neuron2);
                List<string> Neuron3 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron3.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron3.txt");
                gene = random.Next(0, 11);
                if (gene < 5)
                    Neuron3.Add(parent1[0]);
                if (gene > 4 && gene < 10)
                    Neuron3.Add(parent2[0]);
                if (gene == 10)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron3.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 11);
                    if (gene < 5)
                        Neuron3.Add(parent1[i]);
                    if (gene > 4 && gene < 10)
                        Neuron3.Add(parent2[i]);
                    if (gene == 10)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron3.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron3.txt"), Neuron3);
                List<string> Neuron4 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron4.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron4.txt");
                gene = random.Next(0, 11);
                if (gene < 5)
                    Neuron4.Add(parent1[0]);
                if (gene > 4 && gene < 10)
                    Neuron4.Add(parent2[0]);
                if (gene == 10)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron4.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 11);
                    if (gene < 5)
                        Neuron4.Add(parent1[i]);
                    if (gene > 4 && gene < 10)
                        Neuron4.Add(parent2[i]);
                    if (gene == 10)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron4.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron4.txt"), Neuron4);
                List<string> Neuron5 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron5.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron5.txt");
                gene = random.Next(0, 11);
                if (gene < 5)
                    Neuron5.Add(parent1[0]);
                if (gene > 4 && gene < 10)
                    Neuron5.Add(parent2[0]);
                if (gene == 10)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron5.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 11);
                    if (gene < 5)
                        Neuron5.Add(parent1[i]);
                    if (gene > 4 && gene < 10)
                        Neuron5.Add(parent2[i]);
                    if (gene == 10)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron5.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron5.txt"), Neuron5);
                List<string> Neuron6 = new List<string>();
                parent1 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parent]]] + "Neuron6.txt");
                parent2 = System.IO.File.ReadAllLines(oldPaths[parents[parentNumbers[parento]]] + "Neuron6.txt");
                gene = random.Next(0, 11);
                if (gene < 5)
                    Neuron6.Add(parent1[0]);
                if (gene > 4 && gene < 10)
                    Neuron6.Add(parent2[0]);
                if (gene == 10)
                {
                    connection = (float)(random.Next(-10, 1));
                    Neuron6.Add(connection.ToString());
                }
                for (int i = 1; i < parent1.Length; i++)
                {
                    gene = random.Next(0, 11);
                    if (gene < 5)
                        Neuron6.Add(parent1[i]);
                    if (gene > 4 && gene < 10)
                        Neuron6.Add(parent2[i]);
                    if (gene == 10)
                    {
                        connection = (float)(random.Next(-400, 401));
                        connection = connection / 100;
                        Neuron6.Add(connection.ToString());
                    }
                }
                System.IO.File.WriteAllLines((path + "Neuron6.txt"), Neuron6);
                parent = parent + 2;
                if (parent == 10)
                    parent = 1;
                if (parent == 11)
                    parent = 0;
                parento = parent + 1;
                if (parent == 9)
                    parento = 0;
            }
        }
    }
}
