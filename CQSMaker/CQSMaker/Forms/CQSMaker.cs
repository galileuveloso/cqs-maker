using System.Windows.Forms;

namespace CQSMaker.Forms
{
    public partial class CQSMaker : Form
    {
        public CQSMaker()
        {
            InitializeComponent();

            ProjetoSelect.SelectedIndex = 0;
            TypeSelect.SelectedIndex = 0;
        }

        private void CreateBtn_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(CommandNameTxt.Text) && !string.IsNullOrEmpty(FeatureTxt.Text))
            {
                ResultTxt.Text =
                    Maker
                    .CreateCommand
                    (
                        CommandNameTxt.Text,
                        ProjetoSelect.SelectedItem.ToString(),
                        TypeSelect.SelectedItem.ToString(),
                        FeatureTxt.Text,
                        ResponseListCkb.Checked
                    );
            }
        }

        private void CopyBtn_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultTxt.Text))
                Clipboard.SetText(ResultTxt.Text);
        }

        private void ClearBtn_Click(object sender, System.EventArgs e)
        {
            CommandNameTxt.Text = "";
            FeatureTxt.Text = "";
            ResultTxt.Text = "";
        }
    }
}
