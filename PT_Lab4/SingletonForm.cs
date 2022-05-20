namespace PT_Lab4
{
    /// <summary>
    /// ����� ��������� �����
    /// </summary>
    public partial class SingletonForm : Form
    {
        /// <summary>
        /// ����������� ����������, �������� � ���� ������ �� ��������� ����� ����� ����, ����� ����������� ������ ���� ��������� 
        /// </summary>
        private static readonly SingletonForm instance = new SingletonForm();

        /// <summary>
        /// ������ �� ��������� �������� ��������� �����
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
        /// ���������� ������� ������ ������ ������
        /// ��������� ���������� ���� � ����������� ��� ������ �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showPerson_Click(object sender, EventArgs e)
        {
            MyPersonForm myPersonForm = new MyPersonForm();// �������� ������ ����������
            myPersonForm.ShowDialog();// ����� �������
            myPersonForm.Dispose();// ������� �����
        }
        /// <summary>
        /// ���������� ������� ������ �������� � ������ � ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NullReferenceException"></exception>
        private void goButton_Click(object sender, EventArgs e)
        {
            ProcessingForm? form = null;
            OperationModes[] operationModes = new OperationModes[operationsList.CheckedIndices.Count];// �������� ������� ��������, ������� ���������� ���������� ��� ��������
            for (int i = 0; i < operationsList.CheckedItems.Count; i++)
            {
                operationModes[i] = (OperationModes)operationsList.CheckedIndices[i];// ������ ��������, ������� ���� ����������
            }
            if (operationModes.Contains(OperationModes.MultiplyEvenNumsByMinusT))// ���� � ������� ��������, ���� �������� ��������� ������ ����� �� -�, �� ���������� ��������� ����, ��� ������� ��������� 
            {
                GetT_Form getT_ = new GetT_Form();
                if (getT_.ShowDialog() == DialogResult.OK)// ���� ��������� ���������� - ����� - �������� ����������, ��� � �������� ��������� �, �������� �������� �������� � � �������
                {
                    if (generateMode.Checked)// ���� ������ ����� �������� ������ ������� - ���������� ����������� ����� ��������� � ����������� �������
                        form = new ProcessingForm((int)arrayLengthBox.Value, (int)minValueBox.Value, (int)maxValueBox.Value, getT_.T, operationModes);
                    if (openMode.Checked)// ���� ������ ����� ������ �� ����� - ���������� ����������� ����� ��������� � ������ �����, ������ ���������� ������
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            form = new ProcessingForm(openFileDialog.FileName, getT_.T, operationModes);
                        }
                        else return;// ����� - ���������� ��������, ������������ ������� �� ��������� ����
                }
                else return;
            }
            else // ���� �������� �� -� �� ����, �� ���������� ������������ ��� ��������� �
            {
                if (generateMode.Checked)// ���� ������ ����� �������� ������ ������� - ���������� ����������� ����� ��������� � ����������� �������
                    form = new ProcessingForm((int)arrayLengthBox.Value, (int)minValueBox.Value, (int)maxValueBox.Value, operationModes);
                if (openMode.Checked)// ���� ������ ����� ������ �� ����� - ���������� ����������� ����� ��������� � ������ �����, ������ ���������� ������
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        form = new ProcessingForm(openFileDialog.FileName, 1, operationModes);
                    }
                    else return;// ����� - ���������� ��������, ������������ ������� �� ��������� ����
            }
            if (form != null) form.Show();// ���� ����� ������� �������, ��� ��������� �� �����
            else throw new NullReferenceException("Unexpected error");// �����, ������������ ����������
            this.Hide();// ��������� ����� ���������� �� �������� ������� �����
        }
        /// <summary>
        /// ���������� ������� ��������� ������ ��������� �������:
        /// ���� ������ ����� ��������� ������� � ���� - ���������� �������� ������� ���������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mode_CheckedChanged(object sender, EventArgs e)
        {
            generateBox.Enabled = generateMode.Checked;
        }
    }
}