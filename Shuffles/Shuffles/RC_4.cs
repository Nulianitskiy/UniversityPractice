using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffles
{
    class RC4
    {
        public static int[] Crypt(int[] key, int[] A)
        {

            int j = 0;
            int n = A.Length;

            int[] S = new int[n];
            for (int i = 0; i < n; i++)
                S[i] = i;

            for (int i = 0; i < n; i++)
            {
                j = (j + S[i] + key[i]) % n;
                int t = S[i];
                S[i] = S[j];
                S[j] = t;
            }
            j = 0;

            int[] KeyStream = new int[n];

            for (int i = 0; i < n; i++)
            {
                j = (j + S[i]) % n;
                int t = S[i];
                S[i] = S[j];
                S[j] = t;
                int c = (S[i] + S[j]) % n;
                KeyStream[i] = S[c];
            }

            int[] Result = new int[n];
            for (int i = 0; i < n; i++)
            {
                Result[i] = (A[i] + KeyStream[i]) % n;
            }
            return Result;
        }

        public static int[] RC4Shuffle(int[] key, int[] A)
        {

            int j = 0;
            int n = A.Length;

            int[] S = new int[n];
            for (int i = 0; i < n; i++)
                S[i] = i;

            for (int i = 0; i < n; i++)
            {
                j = (j + S[i] + key[i]) % n;
                int t = S[i];
                S[i] = S[j];
                S[j] = t;
            }
            return S;
        }
    }
}
