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
            // заведем счетчики под каждый тип
            int chocosCount = 0;
            int bakerysCount = 0;
            int fruitsCount = 0;

            // очищение текстового поля очереди
            richTextBoxQueue.Clear();
            // пройдемся по всему списку
            foreach (var sweet in this.sweetsList)
            {
                // поэтому чтобы проверить какой именно фрукт
                // мы в данный момент обозреваем, мы используем ключевое слово is
                if (sweet is Chocos)
                {
                    chocosCount += 1;
                    // заполняем очередь автомата
                    richTextBoxQueue.Text += "Шоколад\n";
                }
                else if (sweet is Bakerys)
                {
                    bakerysCount += 1;
                    // заполняем очередь автомата
                    richTextBoxQueue.Text += "Выпечка\n";
                }
                else if (sweet is Fruits)
                {
                    fruitsCount += 1;
                    // заполняем очередь автомата
                    richTextBoxQueue.Text += "Фрукт\n";
                }
            }

            if (this.sweetsList.Count != 0)
            {
                string puth = "C:\\Users\\vovab\\OneDrive\\Изображения\\Нужное\\";
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

            richTextBoxInfo.Text = "Шоколад\tВыпечка\tФрукт";
            richTextBoxInfo.Text += "\n";
            richTextBoxInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", chocosCount, bakerysCount, fruitsCount);
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            this.sweetsList.Clear();
            var random = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (random.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то шоколад
                        this.sweetsList.Add(Chocos.Generate());
                        break;
                    case 1: // если 1 то выпечка
                        this.sweetsList.Add(Bakerys.Generate());
                        break;
                    case 2: // если 2 то фрукт
                        this.sweetsList.Add(Fruits.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.sweetsList.Count == 0)
            {
                richTextBoxOut.Text = "Пусто Q_Q";
                richTextBoxQueue.Text = "Пусто Q_Q";
                return;
            }

            var sweet = this.sweetsList[0];
            this.sweetsList.RemoveAt(0);

            richTextBoxOut.Text = sweet.GetInfo();

            ShowInfo();
        }
    }
}