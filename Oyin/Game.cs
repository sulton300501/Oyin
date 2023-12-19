using System.Xml;

namespace Pitnashki
{
    internal class Pittnashki
    {
        private int[,] x3x3 = new int[4, 4];
        public void start()
        {
            fillArray();
        }
        public void PrintArray()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (x3x3[i, j] != 16)
                        Console.Write(" {0,2} |", x3x3[i, j]);
                    else
                        Console.Write("    |");
                }
                Console.WriteLine("\n -------------------");
            }
        }

        private void fillArray()
        {
            Random rnd = new Random();
            while (arrayIsFull())
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        int c = rnd.Next(1, 17);
                        if (x3x3[i, j] == 0 && isInArray(c))
                        {
                            x3x3[i, j] = c;
                        }
                    }
                }
            }
            PrintArray();
        }
        private bool arrayIsFull()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (x3x3[i, j] == 0)
                        return true;
            return false;
        }
        private bool isInArray(int item)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (x3x3[i, j] == item)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool finish()
        {
            if (x3x3[0, 0] == 1 && x3x3[0, 1] == 2 && x3x3[0, 2] == 3 && x3x3[0, 3] == 4 && x3x3[1, 0] == 5 && x3x3[1, 1] == 6 && x3x3[1, 2] == 7 && x3x3[1, 3] == 8 && x3x3[2, 0] == 9 && x3x3[2, 1] == 10 && x3x3[2, 2] == 11 && x3x3[2, 3] == 12 && x3x3[3, 0] == 13 && x3x3[3, 1] == 14 && x3x3[3, 2] == 15 && x3x3[3, 3] == 16)
                return true;
            return false;
        }

        int xh, yh;
        public void DownArrow()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (x3x3[i, j] == 16)
                    {
                        this.xh = i;
                        this.yh = j;
                    }
                }

            if (xh - 1 >= 0 && xh - 1 != 4)
            {
                var temp = x3x3[xh - 1, yh];
                x3x3[xh - 1, yh] = x3x3[xh, yh];
                x3x3[xh, yh] = temp;
                xh--;
            }
        }

        public void UpArrow()
        {

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (x3x3[i, j] == 16)
                    {
                        this.xh = i;
                        this.yh = j;
                    }
                }

            if (xh + 1 >= 0 && xh + 1 != 4)
            {
                var temp = x3x3[xh + 1, yh];
                x3x3[xh + 1, yh] = x3x3[xh, yh];
                x3x3[xh, yh] = temp;
                xh++;
            }
        }

        public void RightArrow()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (x3x3[i, j] == 16)
                    {
                        this.xh = i;
                        this.yh = j;
                    }
                }

            if (yh - 1 >= 0 && yh - 1 != 4)
            {
                var temp = x3x3[xh, yh - 1];
                x3x3[xh, yh - 1] = x3x3[xh, yh];
                x3x3[xh, yh] = temp;
                yh--;
            }
        }

        public void LeftArrow()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (x3x3[i, j] == 16)
                    {
                        this.xh = i;
                        this.yh = j;
                    }
                }

            if (yh + 1 >= 0 && yh + 1 != 4)
            {
                var temp = x3x3[xh, yh + 1];
                x3x3[xh, yh + 1] = x3x3[xh, yh];
                x3x3[xh, yh] = temp;
                yh++;
            }
        }


    }
}
