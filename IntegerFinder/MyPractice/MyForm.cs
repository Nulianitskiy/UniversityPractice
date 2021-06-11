using System;
using System.Drawing;
using System.Windows.Forms;
using Z.Expressions;// библиотека для динамического решения функций
using System.Threading;

namespace MyPractice
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MainButton_Click(object sender, EventArgs e)// основная кнопка вычислений
        {
            try
            {
                string func = rtbTable.Text;// строка с функцией

                double n = 1;
                double a = Convert.ToDouble(tbA.Text);
                double b = Convert.ToDouble(tbB.Text);

                while (Math.Abs(SimpsonParableIntegral(a, b, 2 * n,func) - SimpsonParableIntegral(a, b, n,func)) / 15 > Convert.ToDouble(tbN.Text)) n *= 2;
                n *= 2;                                   //Точность для формулы Симпсона (парабол) равна 1/15 (I2n - In)


                // вывод ответа
                label5.Text = "Интегралл = " + SimpsonParableIntegral(a, b, n, func).ToString();


                if (Eval.Execute<double>(func, new { X = a }) * Eval.Execute<double>(func, new { X = b }) >= 0)
                    label6.Text = "На данном участке нет ответа";
                else
                    label6.Text = "Ответ = " + DichotomyMethod(a, b , Convert.ToDouble(tbEps.Text), func).ToString();
            }
            catch (Exception)// в случае, если вдруг возникнет ошибка
            {
                rtbTable.BackColor = Color.Red;// программа даст об этом знать
                Refresh();                    // перекрасив область для ввода формулы в красный цвет

                Thread.Sleep(1000); // и приостановив саму программу на 1 секунду, чтобы изменение цвета области было видно

                rtbTable.BackColor = Color.White;// а после все вернется в норму
                Refresh();
            }
        }

        /// <summary>
        /// Метод для вычисления определенного интеграла Методом Симпсона
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="n"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        double SimpsonParableIntegral(double a, double b, double n, string func)
        {
            double h = (b - a) / n; // вычисляем шаг - h
            double sum = 0;     // сумма, результат вычисления интеграла.
            double x0 = a;      // правая граница подотрезка отрезка [a, b]
            double x1 = a + h;  // левая граница подотрезка отрезка [a, b]
            double xh = x0 + h / 2;

            for (int i = 0; i < n; i++) // в цикле применяем формулу Симпсона
            {
                xh = x0 + h / 2;      //для каждого подотрезка, и складываем все полученные значения в общую сумму.
                sum += Eval.Execute<double>(func, new { X = x0 }) + 4 * Eval.Execute<double>(func, new { X = xh }) + Eval.Execute<double>(func, new { X = x1 });
                x0 += h;    // сдвигаем левую и
                x1 += h;    // правую границу
            }

            return (h / 6) * sum;	// возвращаем сумму умноженную на (h/6)(по формуле), т.к. (h/6) общий множитель который можно вынести за скобки.
        }

        /// <summary>
        /// Метод для нахождения решения функции Методом Дихотомии
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="Eps"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        private double DichotomyMethod(double a, double b, double Eps, string func)
        {

            double c = (a + b) / 2;// середина отрезка

            while (Math.Abs(a - b) > Eps)// ищем точку с заданной точностью Эпсилон
            {                           // если искомая точка находится правее середины отрезка, то меняем левую границу отрезка на его середину
                if (Eval.Execute<double>(func, new { X = a }) * Eval.Execute<double>(func, new { X = c }) < 0) b = c; 
                else a = c;           // иначе правую границу отрезка на его середину 

                c = (a + b) / 2;// находим новую середину отрезка
            }

            return c; // последняя середина отрезка является нашим ответом
        }
    }
}
