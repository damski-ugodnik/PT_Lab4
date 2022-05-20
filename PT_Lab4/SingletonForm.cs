namespace PT_Lab4
{
    /// <summary>
    /// Класс начальной формы
    /// </summary>
    public partial class SingletonForm : Form
    {
        /// <summary>
        /// Статическая переменная, хранящая в себе ссылку на экземпляр формы этого типа, чтобы существовал только один экземпляр 
        /// </summary>
        private static readonly SingletonForm instance = new SingletonForm();

        /// <summary>
        /// Ссылка на экземпляр открытой начальной формы
        /// </summary>
        public static SingletonForm Instance { get { return instance; } }

        public SingletonForm()
        {
            InitializeComponent();
        }

        private void SingletonForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Обработчик нажатия кнопки показа автора
        /// открывает диалоговое окно с информацией про автора проекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showPerson_Click(object sender, EventArgs e)
        {
            MyPersonForm myPersonForm = new MyPersonForm();// создание нового экземпляра
            myPersonForm.ShowDialog();// показ диалога
            myPersonForm.Dispose();// очистка формы
        }
        /// <summary>
        /// Обработчик нажатия кнопки перехода к работе с массивом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NullReferenceException"></exception>
        private void goButton_Click(object sender, EventArgs e)
        {
            ProcessingForm? form = null;
            OperationModes[] operationModes = new OperationModes[operationsList.CheckedIndices.Count];// создание массива операций, которве необходимо произвести над массивом
            for (int i = 0; i < operationsList.CheckedItems.Count; i++)
            {
                operationModes[i] = (OperationModes)operationsList.CheckedIndices[i];// запись операций, которые надо произвести
            }
            if (operationModes.Contains(OperationModes.MultiplyEvenNumsByMinusT))// если в массиве операций, есть операция умножения чётных числе на -Т, то вызывается дилоговое окно, для задания множителя 
            {
                GetT_Form getT_ = new GetT_Form();
                if (getT_.ShowDialog() == DialogResult.OK)// если результат выполнения - успех - создание экземпляра, где в качестве аргумента Т, передано значение свойства Т в диалоге
                {
                    if (generateMode.Checked)// если выбран режим создания нового массива - вызывается конструктор формы обработки с параметрами массива
                        form = new ProcessingForm((int)arrayLengthBox.Value, (int)minValueBox.Value, (int)maxValueBox.Value, getT_.T, operationModes);
                    if (openMode.Checked)// если выбран режим чтения из файла - вызывается конструктор формы обработки с именем файла, откуда происходит чтение
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            form = new ProcessingForm(openFileDialog.FileName, getT_.T, operationModes);
                        }
                        else return;// иначе - завершение процесса, пользователь остаётся на начальном окне
                }
                else return;
            }
            else // если умножать на -Т не надо, то вызываются конструкторы без параметра Т
            {
                if (generateMode.Checked)// если выбран режим создания нового массива - вызывается конструктор формы обработки с параметрами массива
                    form = new ProcessingForm((int)arrayLengthBox.Value, (int)minValueBox.Value, (int)maxValueBox.Value, operationModes);
                if (openMode.Checked)// если выбран режим чтения из файла - вызывается конструктор формы обработки с именем файла, откуда происходит чтение
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        form = new ProcessingForm(openFileDialog.FileName, 1, operationModes);
                    }
                    else return;// иначе - завершение процесса, пользователь остаётся на начальном окне
            }
            if (form != null) form.Show();// если форма создана успешно, она выводится на экран
            else throw new NullReferenceException("Unexpected error");// иначе, генерируется исключение
            this.Hide();// начальная форма скрывается до закрытия рабочей формы
        }
        /// <summary>
        /// Обработчик события изменения режима получения массива:
        /// если выбран режим генерации массива с нуля - включаются элементы задания параметров массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mode_CheckedChanged(object sender, EventArgs e)
        {
            generateBox.Enabled = generateMode.Checked;
        }
    }
}