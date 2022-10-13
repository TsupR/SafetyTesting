using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafetyTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        //количество вопросов
        string[] arrQuestions=new string[999];
        string[] arrAnswers_1 = new string[999];
        string[] arrAnswers_2 = new string[999];
        string[] arrAnswers_3 = new string[999];
        string[] arrAnswers_4 = new string[999];
        string[] arrRightAnswers = new string[999];
        string[] arrLogins = new string[999];
        string[] arrPasswords = new string[999];

        int RightAnswers;
        int CurrId = -3;
        int n;
        int minuteold;
        int secondold;
        int secondtime;
        int minutetime;
        bool authorized;
        private void TestVisible(bool flag)
        {
            radioButton1.Visible = flag;
            radioButton2.Visible = flag;
            radioButton3.Visible = flag;
            radioButton4.Visible = flag;
            label1.Visible = flag;
            labeltimerminute.Visible = flag;
            labeltimersecond.Visible = flag;
            timerremaining.Visible = flag;
            timer1.Enabled = flag;
            pictureBoxtest.Visible = flag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(CurrId == -1000) Close();
            if(CurrId >= 0)
            {
                if (radioButton1.Checked & arrRightAnswers[CurrId] == radioButton1.Text |
                    radioButton2.Checked & arrRightAnswers[CurrId] == radioButton2.Text |
                    radioButton3.Checked & arrRightAnswers[CurrId] == radioButton3.Text |
                    radioButton4.Checked & arrRightAnswers[CurrId] == radioButton4.Text)
                    RightAnswers++;
            }
            CurrId++;
            if (CurrId == -2)
            {
                authorized = false;
                CurrId++;
                Autorization(false);
            }
            //теоретическая база
            if (CurrId == -1)
            {
                SettingsVisible(false);
                if (comboBoxMinute.Text == "" & comboBoxSecond.Text == "")
                {
                    minuteold = 10;
                    secondold = 0;
                }
                else
                {
                    minuteold = Convert.ToInt32(comboBoxMinute.Text);
                    secondold = Convert.ToInt32(comboBoxSecond.Text);
                }
                Info();
            }
            //тестирование
            if (CurrId == 0)
            {
                //парсинг вопросов из базы данных
                string pathtest = "Questions.db";
                string texttest = "";
                using (StreamReader readertest = new StreamReader(pathtest)) texttest = readertest.ReadToEnd();
                string[] arrNoParsetest = texttest.Split('@');
                string[] arrParsetest;
                for (; n < arrNoParsetest.Length; n++)
                {
                    arrParsetest = arrNoParsetest[n].Split('-');
                    arrQuestions[n] = arrParsetest[0];
                    arrAnswers_1[n] = arrParsetest[1];
                    arrAnswers_2[n] = arrParsetest[2];
                    arrAnswers_3[n] = arrParsetest[3];
                    arrAnswers_4[n] = arrParsetest[4];
                    arrRightAnswers[n] = arrParsetest[5];
                }
                button1.Text = "Следующий вопрос";
                button2.Text = "Прервать тест";
                TestVisible(true);
                ParsingQuestions();
                Theory(false);
            }
            if (CurrId >= 1)
            {
                if (CurrId == n) Results();
                else ParsingQuestions();
            }
        }
        private void Results()
        {
            TestVisible(false);
            label4.Visible = true;
            ResultsText.Visible = true;
            label4.Text = "Ваш результат: " + RightAnswers + " правильных ответов из " + n;
            button1.Text = "Закрыть программу";
            button2.Text = "Вернуться к теории";
            CurrId = -1000;
            minutetime = minuteold;
            secondtime = secondold;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondtime--;
            if(minutetime == 0 & secondtime < 0) Results();
            if(minutetime > 0 & secondtime < 0)
            {
                minutetime--;
                secondtime = 59;
            }
            labeltimerminute.Text= minutetime + " минут";
            labeltimersecond.Text= secondtime + " секунд";
        }
        static int FindIndex(string[ ] array, string value)
        {
            for(int i=0;i<array.Length; i++) if (array[i] == value) return i;
            return 0;
        }
        private void Settings()
        {
            button1.Text = "Перейти к обучению";
            button2.Text = "Сменить профиль";
            SettingsVisible(true);
        }
        private void SettingsVisible(bool flag)
        {
            comboBoxMinute.Visible = flag;
            comboBoxSecond.Visible = flag;
            labelminute.Visible = flag;
            labelsecond.Visible = flag;
            labeltimer.Visible = flag;
            timerWarning.Visible = flag;
            addProfile.Visible = flag;
            addQuestion.Visible = flag;
            picturesettings.Visible = flag;
            numberQuestionsWarning.Visible = flag;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(CurrId == -3)
            {
                //парсинг аккаунтов из базы данных
                string login = textBoxlogin.Text;
                string password = textBoxpassword.Text;
                string path = "Accounts.db";
                string text = "";
                using (StreamReader reader = new StreamReader(path)) text = reader.ReadToEnd();
                string[] arrNoParse = text.Split('@');
                string[] arrParse;
                for (int k = 0; k < arrNoParse.Length; k++)
                {
                    arrParse = arrNoParse[k].Split('-');
                    arrLogins[k] = arrParse[0];
                    arrPasswords[k] = arrParse[1];
                }
                int indexlogin = FindIndex(arrLogins, login);
                int indexpassword = FindIndex(arrPasswords, password);
                string loginTrue = arrLogins[indexlogin];
                string passwordTrue = arrPasswords[indexpassword];
                if ((login == loginTrue) & (password == passwordTrue))
                {
                    CurrId = -1;
                    authorized = true;
                    Autorization(false);
                }
                else
                {
                    MessageBox.Show("Вы неверно ввели логин и пароль!");
                    CurrId++;
                }
            }
            if (CurrId == -1000)
            {
                CurrId = 0;
                label4.Visible = false;
                RightAnswers = 0;
                ResultsText.Visible = false;
            }
            CurrId--;
            //настройки программы
            if (CurrId == -2)
            {
                Theory(false);
                if (authorized == true) Settings();
                else CurrId--;
            }
            if (CurrId == -3)
            {
                Autorization(true);
                SettingsVisible(false);
                button1.Text = "Войти как гость";
                button2.Text = "Войти через профиль";
            }
            //теоретическая база
            if (CurrId >= -1)
            {
                Info();
                RightAnswers = 0;
                CurrId = -1;
                TestVisible(false);
            }
        }
        private void Info()
        {
            button1.Text = "Начать тестирование";
            button2.Text = "Вернуться назад";
            minutetime = minuteold;
            secondtime = secondold;
            Theory(true);
            string paththeory = "Theory.db";
            using StreamReader readertheory = new StreamReader(paththeory);
            string texttheory = readertheory.ReadToEnd();
            textBox1.Text = texttheory.ToString();
        }
        private void ParsingQuestions()
        {
            label1.Text = CurrId + 1 + ") " + arrQuestions[CurrId];
            radioButton1.Text = arrAnswers_1[CurrId];
            radioButton2.Text = arrAnswers_2[CurrId];
            radioButton3.Text = arrAnswers_3[CurrId];
            radioButton4.Text = arrAnswers_4[CurrId];
        }
        private void Theory(bool flag)
        {
            textBox1.Visible = flag;
        }
        private void Autorization(bool flag)
        {
            label2.Visible = flag;
            label3.Visible = flag;
            textBoxlogin.Visible = flag;
            textBoxpassword.Visible = flag;
            header.Visible = flag;
        }

        private void addProfile_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void addQuestion_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
