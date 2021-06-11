using System;

namespace Shuffles
{
    class ShufflesClass
    {
        /// <summary>
        /// Алгоритм перемешивания Фишер-Йетса 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] FisherYates(int[] array)
        {
            Random rand = new Random();
            int[] ArrayToShuffle = array;
            int CurrentPosition;

            for (CurrentPosition = ArrayToShuffle.Length - 1; CurrentPosition > 0; CurrentPosition--)
                Swap(ArrayToShuffle, CurrentPosition, rand.Next(CurrentPosition + 1));

            return ArrayToShuffle;
        }
        /// <summary>
        /// Алгоритм перемешивания случайными перекидываниями элементов
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] RandomThrow(int[] array)
        {
            Random rand = new Random();
            long n = rand.Next(array.Length * 10);

            int from, to;

            for (long i = 0; i < n; i++)
            {
                from = rand.Next(array.Length);
                to = rand.Next(array.Length);

                int t = array[from];
                array[from] = array[to];
                array[to] = t;
            }
            return array;
        }
        /// <summary>
        /// Алгоритм перемешивания перестановками
        /// </summary>
        /// <param name="Razm"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] PermutationShuffle(int[] Razm, int n)
        {
            for (int i = 0; i < n; i++)
                Permutation(Razm);
            return Razm;
        }
        private static int[] Permutation(int[] Razm)
        {
            int n = Razm.Length;
            int j = n - 2;
            while (j != -1 && Razm[j] >= Razm[j + 1]) j--;
            if (j == -1)
                return Razm;
            int k = n - 1;
            while (Razm[j] >= Razm[k]) k--;
            Swap(Razm, j, k);
            int l = j + 1, r = n - 1;
            while (l < r)
                Swap(Razm, l++, r--);
            return Razm;
        }
        /// <summary>
        /// Алгоритм перемешивания из алгоритма кодирования RC4
        /// </summary>
        /// <param name="key"></param>
        /// <param name="A"></param>
        /// <returns></returns>
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

                Swap(S, i, j);
            }
            return S;
        }
        static void Swap(int[] Arr, int i, int j)
        {
            int s = Arr[i];
            Arr[i] = Arr[j];
            Arr[j] = s;
        }
    }
}
