using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Lab4
{
    /// <summary>
    /// Форма для обработки массива
    /// </summary>
    public partial class ProcessingForm : Form
    {
        /// <summary>
        /// Класс квадратного массива
        /// </summary>
        SquareArray array;

        private int counter = 0;
        /// <summary>
        /// обработчик закрытия формы: когда закрывается форма, открывается начальная форма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SingletonForm.Instance.Show();
        }
        /// <summary>
        /// Обработчик нажатия кнопки переключения между состояниями массива: показывание состояний массива одно за другим в порядке их выполнения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            ShowAll();
        }
        /// <summary>
        /// Метод вывода состояний массива на экран
        /// </summary>
        private void ShowAll()
        {
            ArrayCondition condition = array.ArrayConditions[counter++];// создание временной переменной хранящей в себе экземпляр состояния массива (+ инкрементация счетчика состояний после присвоения)
            ShowArr(condition.squareArray);// вызов метода вывода массива в таблицу
            ShowOps(condition.processedOps);// вызов метода вывода произведённых операций в данном состоянии
            if (condition.average != null)// если в состоянии значение среденго арифметического не NULL, то оно было вычисленно и выводится на экран
            {
                avgBox.Visible = true;
                AverageLabel.Visible = true;
                avgBox.Text = condition.average.ToString();
            }
            else if (!condition.processedOps.Contains(OperationModes.FindAverage)) { AverageLabel.Visible = avgBox.Visible = false; }// если в массиве произведённых операций нету операции нахождения Ср.Арифметического, то поля, показывающие его, скрываются
            if (counter == array.ArrayConditions.Count())// если счётчик показанных состояний равен количеству состояний, он обнуляется
            {
                counter = 0;
            }
        }
        /// <summary>
        /// конструктор формы, если происходит открытие массива из файла и происходит умножение на -T
        /// </summary>
        /// <param name="fileName">имя файла для открытия</param>
        /// <param name="t">множитель</param>
        /// <param name="operationModes">операции, которые надо произвести над массивом</param>
        public ProcessingForm(string fileName, int t, OperationModes[] operationModes)
        {
            array = new SquareArray(fileName, t, operationModes);// вызов конструктора класса массива для открытия файла и умножения
            InitializeComponent();
        }
        /// <summary>
        /// конструктор формы, если происходит генерация нового массива, без умножения на -Т
        /// </summary>
        /// <param name="n">длинна массива</param>
        /// <param name="a">минимальное число</param>
        /// <param name="b">максимальное число</param>
        /// <param name="operationModes">операции, которые надо произвести над массивом</param>
        public ProcessingForm(int n, int a, int b, OperationModes[] operationModes)
        {
            array = new SquareArray(n, a, b, -1, operationModes);//вызов конструтора с генерацией нового массива, в качестве аргумента t используется (-1)
            InitializeComponent();
        }
        /// <summary>
        /// конструктор формы, если происходит генерация нового массива, с умножением на -Т
        /// </summary>
        /// <param name="n">длинна массива</param>
        /// <param name="a">минимальное число</param>
        /// <param name="b">максимальное число</param>
        /// <param name="t">множитель</param>
        /// <param name="operationModes">операции, которые надо произвести над массивом</param>
        public ProcessingForm(int n, int a, int b, int t, OperationModes[] operationModes) : this(n, a, b, operationModes)
        {
            array = new SquareArray(n, a, b, t, operationModes);// вызов конструтора с генерацие нового массива и с умножением на -Т
        }
        /// <summary>
        /// обработчик нажатия кнопки сохранения массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serializeArr_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)// если диалог совершил успешную работу, происходит сохранение массива в файл
                {
                    array.SerializeArray(saveFileDialog.FileName);// вызов метода сохранения массива
                    MessageBox.Show("Array successfully saved");// сообщение об успещном сохранении
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// при возникновении исключения, вывод сообщения об ошибке
            }
        }
        /// <summary>
        /// Метод вывода произведённых операций на экран
        /// </summary>
        /// <param name="ops"></param>
        private void ShowOps(OperationModes[] ops)
        {
            operationBox.Text = "";// очистка поля вывода
            foreach (OperationModes mode in ops)
            {
                operationBox.Text += mode.ToString() + "\n";// вывод каждого элемента массива
            }
        }
        /// <summary>
        /// Когда загружается форма, на экран выводится окончательное состояние массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessingForm_Load(object sender, EventArgs e)
        {
            do
            {
                ShowAll();
            } while (counter != 0);
        }
        /// <summary>
        /// Метод вывода массива в таблицу
        /// </summary>
        /// <param name="arrayToShow"></param>
        private void ShowArr(int[,] arrayToShow)
        {
            arrayGrid.RowCount = arrayToShow.GetLength(0);// задание количества строк
            arrayGrid.ColumnCount = arrayToShow.GetLength(1);// задание количества столбцов
            for (int i = 0; i < arrayToShow.GetLength(0); i++)
                for (int j = 0; j < arrayToShow.GetLength(1); j++)
                {
                    arrayGrid[i, j].Value = arrayToShow[i, j];// присвоение каждой клетке значения в соответствии с позицией элемента в массиве
                }
        }
    }
}