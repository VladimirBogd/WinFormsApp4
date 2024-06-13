using WindowsFormsApp4;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<Sweets> sweetsList = new List<Sweets>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ShowInfo()
        {
            // ������� �������� ��� ������ ���
            int chocosCount = 0;
            int bakerysCount = 0;
            int fruitsCount = 0;

            // �������� ���������� ���� �������
            richTextBoxQueue.Clear();
            // ��������� �� ����� ������
            foreach (var sweet in this.sweetsList)
            {
                // ������� ����� ��������� ����� ������ �����
                // �� � ������ ������ ����������, �� ���������� �������� ����� is
                if (sweet is Chocos)
                {
                    chocosCount += 1;
                    // ��������� ������� ��������
                    richTextBoxQueue.Text += "�������\n";
                }
                else if (sweet is Bakerys)
                {
                    bakerysCount += 1;
                    // ��������� ������� ��������
                    richTextBoxQueue.Text += "�������\n";
                }
                else if (sweet is Fruits)
                {
                    fruitsCount += 1;
                    // ��������� ������� ��������
                    richTextBoxQueue.Text += "�����\n";
                }
            }

            if (this.sweetsList.Count != 0)
            {
                string puth = "C:\\Users\\vovab\\OneDrive\\�����������\\������\\";
                if (this.sweetsList[0] is Chocos)
                    pictureBox1.ImageLocation = puth + "choco_icon.jpg";
                else if (this.sweetsList[0] is Bakerys)
                    pictureBox1.ImageLocation = puth + "bakery.jpg";
                else if (this.sweetsList[0] is Fruits)
                    pictureBox1.ImageLocation = puth + "fruit.jpg";
            }
            else
            {
                pictureBox1.Image = null;
            }

            richTextBoxInfo.Text = "�������\t�������\t�����";
            richTextBoxInfo.Text += "\n";
            richTextBoxInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", chocosCount, bakerysCount, fruitsCount);
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            this.sweetsList.Clear();
            var random = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (random.Next() % 3) // ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
                {
                    case 0: // ���� 0, �� �������
                        this.sweetsList.Add(Chocos.Generate());
                        break;
                    case 1: // ���� 1 �� �������
                        this.sweetsList.Add(Bakerys.Generate());
                        break;
                    case 2: // ���� 2 �� �����
                        this.sweetsList.Add(Fruits.Generate());
                        break;
                        // ��������� ������ ����� ������������
                }
            }
            ShowInfo();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            // ���� ������ ����, �� ������� ��� ����� � ������ �� �������
            if (this.sweetsList.Count == 0)
            {
                richTextBoxOut.Text = "����� Q_Q";
                richTextBoxQueue.Text = "����� Q_Q";
                return;
            }

            var sweet = this.sweetsList[0];
            this.sweetsList.RemoveAt(0);

            richTextBoxOut.Text = sweet.GetInfo();

            ShowInfo();
        }
    }
}