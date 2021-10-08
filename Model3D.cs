using System;
using System.Collections.Generic;
using System.Text;

namespace ItemProjection
{
    class Model3D
    {
        int m;
        int M
        {
            get
            {
                return m;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("M cannot be <= 0");
                m = value;
            }
        }

        int n;
        int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("N cannot be <= 0");
                n = value;
            }
        }
        int p;
        int P
        {
            get
            {
                return p;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("P cannot be <= 0");
                p = value;
            }
        }

        int[,,] array;
        int[,,] Array
        {
            get
            {
                return array;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("3D Model not set");
                array = value;
            }
        }

        public int this[int m, int n, int p]
        {
            get
            {
                if ((m < 0 || m >= M) && (n < 0 || n >= N) && (p < 0 || p >= P))
                    throw new IndexOutOfRangeException("Some of indexes are incorrect");
                return array[m, n, p];
            }
            set
            {
                if ((m < 0 || m >= M) && (n < 0 || n >= N) && (p < 0 || p >= P))
                    throw new IndexOutOfRangeException("Some of indexes are incorrect");
                array[m, n, p] = value;
            }
        }

        public Model3D(int[,,] array, int m, int n, int p)
        {
            Array = array;
            M = m;
            N = n;
            P = p;
        }

        public void GetModelProjection(out int[,] arrayProjectionMN, out int[,] arrayProjectionMP, out int[,] arrayProjectionNP)
        {
            arrayProjectionMN = new int[m, n];
            arrayProjectionMP = new int[m, p];
            arrayProjectionNP = new int[n, p];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < p; k++)
                    {
                        if (array[i, j, k] == 1)
                        {
                            arrayProjectionNP[j, k] = 1;
                            arrayProjectionMP[i, k] = 1;
                            arrayProjectionMN[i, j] = 1;
                        }
                    }
                }
            }
        }
    }
}
