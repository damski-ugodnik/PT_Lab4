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
    /// Форма для задания множителя Т
    /// </summary>
    public partial class GetT_Form : Form
    {
        public GetT_Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Множитель, заданный в окне
        /// </summary>
        public int T
        {
            get { return (int)tValueBox.Value; }
        }

        private void GetT_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
