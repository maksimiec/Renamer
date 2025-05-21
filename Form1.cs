namespace RenamerPro_S
{
    public partial class Form1 : Form
    {

        string selectedPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BTND_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "�������� ����������";
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = folderBrowserDialog.SelectedPath;
                    MessageBox.Show("��������� ����: " + selectedPath);

                }
            }

        }

        private void BTNR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPath)) { MessageBox.Show("���������� �� ��������"); }
            else
            if (string.IsNullOrEmpty(TBO.Text)) { MessageBox.Show("�� ���� ������� ��� ������"); }
            else
            if (string.IsNullOrEmpty(TBN.Text)) { MessageBox.Show("�� ���� ������� �� ��� ������"); }
            else

            {
                string[] files = Directory.GetFiles(selectedPath);
               
                foreach (string file in files) 
                {
                    string fileName = Path.GetFileName(file);

                    if (fileName.Contains(TBO.Text)) { string newFN = fileName.Replace(TBO.Text,TBN.Text);
                    File.Move(file, Path.Combine(selectedPath,newFN));

                    }
                }

                MessageBox.Show("�������������� ����� ������ �������");
            }
        }
    }
}
