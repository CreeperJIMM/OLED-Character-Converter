using System;
using System.Windows.Forms;

namespace OLED漢字轉換
{
    public partial class InputDialog : Form
    {
        public InputDialog()
        {
            InitializeComponent();
        }
        public string txt = "";

        private void btnOK_Click(object sender, EventArgs e)
        {
            txt = richTextBox1.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsData(DataFormats.Text))
            {
                richTextBox1.Text = Clipboard.GetText();
            }
        }
    }
}
