namespace Гороскоп
{
    public partial class Form1 : Form
    {
        int month;
        int day;
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            int month = e.Start.Month;
            int day = e.Start.Day;
            if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\козерог.jpg");
                label1.Text = ("Ваш знак зодиака: Козерог");
                label2.Text = "Трудолюбие и настойчивость помогут вам достичь поставленных целей. \nВремя сосредоточиться на карьере и профессиональных задачах. \nВаши усилия обязательно будут вознаграждены.";
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\водолей.jpg");
                label1.Text = ("Ваш знак зодиака: Водолей");
                label2.Text = "Инновации и нестандартные идеи будут вашим преимуществом. \nОкружающие оценят ваше оригинальное мышление. \nПоддерживайте дружеские связи и развивайте творческие проекты.\r\n\r\n";
            }
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\рыбы.jpg");
                label1.Text = ("Ваш знак зодиака: Рыбы");
                label2.Text = "Эмоциональная чувствительность может сыграть важную роль. \nУделите время духовному развитию и самопознанию. \nВаши мечты могут стать реальностью, если вы будете верить в них.";
            }
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\овен.jpg");
                label1.Text = ("Ваш знак зодиака: Овен");
                label2.Text = "Вам предстоит период активной деятельности. \nИспользуйте свою энергию для достижения целей. \nНе бойтесь рисковать и проявлять инициативу.\r\n\r\n";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\телец.jpg");
                label1.Text = ("Ваш знак зодиака: Телец");
                label2.Text = "Финансовое благополучие ожидает вас. \nБудьте внимательны к своим ресурсам и не тратьте их впустую. \nЭмоциональная стабильность поможет вам справиться со всеми трудностями.\r\n\r\n";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\близнецы.jpg");
                label1.Text = ("Ваш знак зодиака: Близнецы");
                label2.Text = "Вас ждут интересные встречи и новые знакомства. \nОбщайтесь больше, делитесь идеями и будьте открыты для нового опыта. \nВаши коммуникативные навыки помогут вам достичь успеха.";
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\рак.jpg");
                label1.Text = ("Ваш знак зодиака: Рак");
                label2.Text = "Время уделить внимание своему дому и семье. \nЗабота о близких принесет вам удовлетворение. \nНе забывайте заботиться и о себе, отдыхайте и восстанавливайте силы.\r\n\r\n";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\лев.jpg");
                label1.Text = ("Ваш знак зодиака: Лев");
                label2.Text = "Период творчества и самовыражения. \nВаше стремление к лидерству и желание быть в центре внимания принесут плоды. \nНе стесняйтесь демонстрировать свои таланты.\r\n\r\n";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\дева.jpg");
                label1.Text = ("Ваш знак зодиака: Дева");
                label2.Text = "Внимание к деталям и аналитический подход помогут вам решить сложные задачи. \nОрганизованность и дисциплина приведут к успеху в работе и личной жизни.";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\весы.jpg");
                label1.Text = ("Ваш знак зодиака: Весы");
                label2.Text = "Стабильность и гармония станут вашими спутниками. \nСтарайтесь находить баланс во всем, особенно в отношениях. \nВаша дипломатичность поможет избежать конфликтов.";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\скорпион.jpg");
                label1.Text = ("Ваш знак зодиака: Скорпион");
                label2.Text = "Время для глубоких размышлений и самоанализа. \nИспользуйте свою интуицию и эмоциональную силу для решения сложных вопросов. \nБудьте готовы к переменам.\r\n\r\n";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                this.pictureBox1.Image = Image.FromFile(@"C:\Users\ushak\source\repos\Гороскоп\стрелец.jpg");
                label1.Text = ("Ваш знак зодиака: Стрелец");
                label2.Text = "Путешествия и новые впечатления ждут вас. \nОткройте себя миру, расширяйте кругозор и не бойтесь выходить из зоны комфорта. \nВаши приключения принесут много радости.\r\n\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
