using System;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ZedGraph;

namespace Shuffles
{
    public partial class Form_Face : Form
    {
        public Form_Face()
        {
            InitializeComponent();
        }
        GraphPane pane;
        Random Rand = new Random();

        PointPairList FY_list = new PointPairList();
        PointPairList RT_list = new PointPairList();
        PointPairList Perm_list = new PointPairList();
        PointPairList RC_list = new PointPairList();

        private void Form_Face_Load(object sender, EventArgs e)
        {
            pane = ZedGrath.GraphPane;
            pane.XAxis.Title.Text = "Колличество эллементов";
            pane.YAxis.Title.Text = "Время в секундах";
            pane.Title.Text = "Рассчет эффективности";
        }

        private void PrintTxt (int[] array)
        {
            string writePath = @"Out.txt";
            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);//Файл
            foreach (int number in array)
                sw.Write(number + " ");
            sw.Close();
        }

        private int[] Fuller(string TBC)
        {
            int n;
            if (TBC == "")
            {
                n = Rand.Next(0, 100000);
            }
            else
            {
                n = Convert.ToInt32(TBC);
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = i + 1;
            return arr;
        }

        private void FY_Click(object sender, EventArgs e)
        {
            int[] A = Fuller(TBCount1.Text);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            A = ShufflesClass.FisherYates(A);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            
            double time = Convert.ToDouble(elapsedTime);
            label2.Text = Convert.ToString(time);
            label3.Text = elapsedTime2;
            FY_list.Add(A.Length, time);
            PrintTxt(A);
        }

        private void Permutations_Click(object sender, EventArgs e)
        {
            int[] A = Fuller(TBCount2.Text);
            int n = Rand.Next();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            A = ShufflesClass.PermutationShuffle(A, A.Length);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            double time = Convert.ToDouble(elapsedTime);
            label2.Text = Convert.ToString(time);
            label3.Text = elapsedTime2;
            Perm_list.Add(A.Length, time);
            PrintTxt(A);
        }

        private void Rand_Throw_Click(object sender, EventArgs e)
        {
            int[] A = Fuller(TBCount3.Text);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            A = ShufflesClass.RandomThrow(A);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            double time = Convert.ToDouble(elapsedTime);
            label2.Text = Convert.ToString(time);
            label3.Text = elapsedTime2;
            RT_list.Add(A.Length, time);
            PrintTxt(A);
        }

        private void RC_4_Click(object sender, EventArgs e)
        {
            int[] A = Fuller(TBCount4.Text);
            int[] key = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
                key[i] = Rand.Next(A.Length);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            A = ShufflesClass.RC4Shuffle(key, A);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = Convert.ToString(ts.TotalSeconds);
            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

            double time = Convert.ToDouble(elapsedTime);
            label2.Text = Convert.ToString(time);
            label3.Text = elapsedTime2;
            RC_list.Add(A.Length, time);
            PrintTxt(A);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ZedGrath.GraphPane.CurveList.Clear();

            // Ось X будет пересекаться с осью Y на уровне Y = 0
            pane.XAxis.Cross = 0.0;

            // Ось Y будет пересекаться с осью X на уровне X = 0
            pane.YAxis.Cross = 0.0;

            LineItem FY_Curve = pane.AddCurve("F-Y", FY_list, Color.Blue, SymbolType.None);
            LineItem Perm_Curve = pane.AddCurve("Permutation", Perm_list, Color.Red, SymbolType.None);
            LineItem RT_Curve = pane.AddCurve("Rand_Throw", RT_list, Color.Yellow, SymbolType.None);
            LineItem RC_Curve = pane.AddCurve("RC 4", RC_list, Color.Green, SymbolType.None);

            ZedGrath.AxisChange();
            ZedGrath.Invalidate();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
