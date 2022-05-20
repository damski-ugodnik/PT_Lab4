using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PT_Lab4
{
    /// <summary>
    /// Класс квадратного массива
    /// </summary>
    public class SquareArray
    {
        /// <summary>
        /// Квадратный массив
        /// </summary>
        int[,] sqArray;
        /// <summary>
        /// Размерность массива
        /// </summary>
        int size;
        /// <summary>
        /// Очередь из произведённых операций
        /// </summary>
        Queue<OperationModes> processedOps = new Queue<OperationModes>();
        /// <summary>
        /// Список состояний массива
        /// </summary>
        List<ArrayCondition> conditions;
        /// <summary>
        /// Конструктор класса при открытии массива из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="t">множитель Т</param>
        /// <param name="modesToProcess">Операции, которые необходимо произвести</param>
        public SquareArray(string fileName, int t, OperationModes[] modesToProcess)
        {
            sqArray = new int[0, 0];// создание экземпляра массива
            conditions = new List<ArrayCondition>();// создание списка  состояний
            processedOps.Enqueue(OperationModes.NoOperation);// добавление в очередь пустой операции
            DeserializeArray(fileName);// вызов метода десериализации массива
            foreach (OperationModes operation in modesToProcess)// просмотр массива операций для выполнения
            {
                switch (operation)
                {

                    case OperationModes.FindAverage:// если операция нахождения среднего арифметического, вызов метода нахождения 
                        {
                            Average();
                            break;
                        }
                    case OperationModes.SortDownward:// если операция сортировки - вызов метода сортировки массива по столбцам
                        {
                            SortDownward();
                            break;
                        }
                    case OperationModes.MultiplyEvenNumsByMinusT:// если операция умножения чётных числе на -Т: вызов соответсвующего метода
                        {

                            MultiplyEvenNumsByMinusT(t);

                            break;
                        }
                    default: break;
                }

            }
        }
        /// <summary>
        /// Конструктор класса массива, для генерации нового массива
        /// </summary>
        /// <param name="size">размерность</param>
        /// <param name="min">минимальное значение</param>
        /// <param name="max">максимальное значение</param>
        /// <param name="t">множитель Т</param>
        /// <param name="modesToProcess"></param>
        public SquareArray(int size, int min, int max, int t, OperationModes[] modesToProcess)
        {
            Random r = new Random();
            this.size = size;// установка размерности
            sqArray = new int[size, size];//создание нового экземпляра массива с указанной размерностью
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    sqArray[i, j] = r.Next(min, max);// инициализация элементов массива
            conditions = new List<ArrayCondition>();// создание списка состояний массива
            processedOps.Enqueue(OperationModes.NoOperation);//добавление в очередь операций пустой операции
            conditions.Add(new ArrayCondition((int[,])sqArray.Clone()));// добаление первоначального состояния массива в список
            foreach (OperationModes operation in modesToProcess)
            {
                switch (operation)
                {

                    case OperationModes.FindAverage:
                        {
                            Average();

                            break;
                        }
                    case OperationModes.SortDownward:
                        {
                            SortDownward();
                            break;
                        }
                    case OperationModes.MultiplyEvenNumsByMinusT:
                        {

                            MultiplyEvenNumsByMinusT(t);

                            break;
                        }
                    default: break;
                }
            }
        }
        /// <summary>
        /// Квадратный массив
        /// </summary>
        public int[,] SqArray
        {
            get { return sqArray; }
        }
        /// <summary>
        /// Список состояний массива представленный в виде массива
        /// Состоит из:
        /// Массив;
        /// Произведённые над ним операции
        /// </summary>
        public ArrayCondition[] ArrayConditions
        {
            get
            {
                return conditions.ToArray();
            }
        }
        /// <summary>
        /// Метод вычисления среднего арифметического
        /// </summary>
        /// <returns></returns>
        private double Average()
        {
            processedOps.Enqueue(OperationModes.FindAverage);// добавление в очередь соответствующей произведённой операции
            int sum = 0;
            for (int i = 0; i < SqArray.GetLength(0); i++)
            {
                for (int j = 0; j < SqArray.GetLength(1); j++)
                {
                    sum += SqArray[i, j];// прибавление к сумме каждого элемента массива
                }
            }

            conditions.Add(new ArrayCondition((int[,])sqArray.Clone(), processedOps.ToArray(), (double)Math.Round((double)(sum / SqArray.Length), 2)));// запись в список состояния массива, массива произведённых операций и значения среднего арифметического (sum/количество элементов) 
            return (double)Math.Round((double)(sum / SqArray.Length));
        }
        /// <summary>
        /// Метод сортировки столбцов массива по убыванию
        /// </summary>
        private void SortDownward()
        {
            processedOps.Enqueue(OperationModes.SortDownward);// добавление в очередь соответствующей произведённой операции
            for (int i = 0; i < size; i++)//проход по столбцам массива
            {
                int[] temp = new int[size];// создание временного ожномерного массива с размерностью равной длинне стобца
                for (int j = 0; j < size; j++)
                {
                    temp[j] = SqArray[i, j];// запись столбца i в массив
                }
                Array.Sort(temp);// сортировка временного массива по возрастанию
                Array.Reverse(temp);// переворачивание массива 
                for (int j = 0; j < size; j++)// запись обработанного временного массива в столбец i
                {
                    SqArray[i, j] = temp[j];
                }
            }
            conditions.Add(new ArrayCondition((int[,])sqArray.Clone(), processedOps.ToArray()));// запись состояния массива и массива произведённых операций в список
        }
        /// <summary>
        /// Метод умножения чётных чисел на -Т
        /// </summary>
        /// <param name="t">множитель</param>
        private void MultiplyEvenNumsByMinusT(int t)
        {
            processedOps.Enqueue(OperationModes.MultiplyEvenNumsByMinusT);// добавление в очередь соответствующей произведённой операции
            for (int i = 0; i < sqArray.GetLength(0); i++)
                for (int j = 0; j < sqArray.GetLength(1); j++)
                {
                    if (sqArray[i, j] % 2 == 0)// если число чётное - умножение на -Т
                        sqArray[i, j] *= -t;
                }
            conditions.Add(new ArrayCondition((int[,])sqArray.Clone(), processedOps.ToArray()));// запись состояния массива и массива произведённых операций в список
        }
        /// <summary>
        /// Метод записи массива в файл
        /// </summary>
        /// <param name="fileName">имя файла, куда происходит запись</param>
        public void SerializeArray(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))// открытие потока для записи
            {
                StreamWriter sw = new StreamWriter(fs);// открытие записывающего потока
                for (int i = 0; i < sqArray.GetLength(0); i++)
                {
                    for (int j = 0; j < sqArray.GetLength(1); j++)
                    {
                        if (j == sqArray.GetLength(1) - 1)// если элемент последний в строке, то пробел не добавляется
                        {
                            sw.Write(sqArray[j, i]);
                        }
                        else
                            sw.Write(sqArray[j, i] + " ");// иначе записывается элемент + пробел
                    }
                    sw.Write("\n");// добавление новой строки
                }
                sw.Close();// закрытие потока
            }
        }
        /// <summary>
        /// Метод считывания массива з файла
        /// </summary>
        /// <param name="fileName"></param>
        public void DeserializeArray(string fileName)
        {

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))// открытие потока чтения из файла
            {
                int size = 1; string[] row;// создание массива строк, отображающего каждый элемент в строке массива 
                StreamReader sr = new StreamReader(fs);
                for (int i = 0; i < size; i++)
                {
                    row = sr.ReadLine().Split(new char[] { ' ', '\n' });// запись в массив разбитой на элементы строки
                    if (i == 0)// при чтении первой строки определяется размерность массива
                    {
                        size = row.Length;
                        sqArray = new int[size, size];
                    }
                    for (int j = 0; j < size; j++)
                    {
                        sqArray[j, i] = int.Parse(row[j]);// запись элемента массива строк на нужное место в массиве в виде числа
                    }
                }
            }
            conditions.Add(new ArrayCondition((int[,])sqArray.Clone(), processedOps.ToArray()));// запись состояния массива и массива произведённых операций в список
            size = sqArray.GetLength(0);// установка размерности массива
        }
        // статические методы с аналогичной логикой, предназначенные для модульного тестирования
        public static double Avg_ForTesting(int[,] array)
        {
            int n = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    n += array[i, j];
                }
            }
            return (double)Math.Round((double)(n / array.Length));
        }

        public static int[,] SortDownward_ForTesting(int[,] array)
        {
            int size = array.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                int[] temp = new int[size];
                for (int j = 0; j < size; j++)
                {
                    temp[j] = array[i, j];
                }
                Array.Sort(temp);
                Array.Reverse(temp);
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = temp[j];
                }
            }
            return array;
        }

        public static int[,] MultiplyEvenNumByMinusT_ForTesting(int[,] array, int t)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                        array[i, j] *= -t;
                }
            return array;
        }
    }
    /// <summary>
    /// Структура, отображающая состояние массива после операции
    /// </summary>
    public struct ArrayCondition
    {
        /// <summary>
        /// Массив после операции
        /// </summary>
        public readonly int[,] squareArray;
        /// <summary>
        /// Массив произведённых операций
        /// </summary>
        public readonly OperationModes[] processedOps;
        /// <summary>
        /// Среднее арифметическое (если вычислялось)
        /// </summary>
        public readonly double? average;
        /// <summary>
        /// Конструктор, где вручную инициализируется каждое поле
        /// </summary>
        /// <param name="_squareArray">массив</param>
        /// <param name="_processedOps">массив произведённых операций</param>
        /// <param name="_average">среднее арифметическое</param>
        public ArrayCondition(int[,] _squareArray, OperationModes[] _processedOps, double _average)
        {
            squareArray = _squareArray;
            processedOps = _processedOps;
            average = _average;
        }
        /// <summary>
        /// Конструктор, где инициализируются только массив и произведённые операции (среднее арифметическое = NULL)
        /// Используется, когда не вычислялось среднее арифметическое
        /// </summary>
        /// <param name="_squareArray">массив</param>
        /// <param name="_processedOps">массив произведённых операций</param>
        public ArrayCondition(int[,] _squareArray, OperationModes[] _processedOps)
        {
            squareArray = _squareArray;
            processedOps = _processedOps;
            average = null;
        }
        /// <summary>
        /// Конструктор, где инициализируется только массив
        /// Используется, когда массив только создан
        /// </summary>
        /// <param name="_squareArray">Массив</param>
        public ArrayCondition(int[,] _squareArray)
        {
            squareArray = _squareArray;
            processedOps = new OperationModes[] { OperationModes.NoOperation };
            average = null;
        }
    }
    /// <summary>
    /// Перечисление возможных операций
    /// </summary>
    public enum OperationModes
    {
        FindAverage,
        SortDownward,
        MultiplyEvenNumsByMinusT,
        NoOperation
    }
}