
namespace SafetyTesting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeltimerminute = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltimer = new System.Windows.Forms.Label();
            this.labelminute = new System.Windows.Forms.Label();
            this.labelsecond = new System.Windows.Forms.Label();
            this.labeltimersecond = new System.Windows.Forms.Label();
            this.timerremaining = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.addProfile = new System.Windows.Forms.Button();
            this.addQuestion = new System.Windows.Forms.Button();
            this.comboBoxMinute = new System.Windows.Forms.ComboBox();
            this.comboBoxSecond = new System.Windows.Forms.ComboBox();
            this.timerWarning = new System.Windows.Forms.Label();
            this.comboBoxNumberQuestions = new System.Windows.Forms.ComboBox();
            this.numberQuestionsWarning = new System.Windows.Forms.Label();
            this.numberQuestionsText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ResultsText = new System.Windows.Forms.Label();
            this.picturesettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxtest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturesettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtest)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(523, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти как гость";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(14, 136);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 25);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(14, 189);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(138, 25);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(14, 240);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 25);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(14, 291);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(138, 25);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.Visible = false;
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxlogin.Location = new System.Drawing.Point(277, 168);
            this.textBoxlogin.Multiline = true;
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(434, 39);
            this.textBoxlogin.TabIndex = 7;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.AcceptsTab = true;
            this.textBoxpassword.AllowDrop = true;
            this.textBoxpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxpassword.Location = new System.Drawing.Point(277, 291);
            this.textBoxpassword.Multiline = true;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(434, 39);
            this.textBoxpassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(447, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(437, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль:";
            // 
            // labeltimerminute
            // 
            this.labeltimerminute.AutoSize = true;
            this.labeltimerminute.BackColor = System.Drawing.Color.Transparent;
            this.labeltimerminute.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltimerminute.Location = new System.Drawing.Point(767, 235);
            this.labeltimerminute.Name = "labeltimerminute";
            this.labeltimerminute.Size = new System.Drawing.Size(15, 23);
            this.labeltimerminute.TabIndex = 11;
            this.labeltimerminute.Text = " ";
            this.labeltimerminute.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltimer
            // 
            this.labeltimer.AutoSize = true;
            this.labeltimer.BackColor = System.Drawing.Color.Transparent;
            this.labeltimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labeltimer.Location = new System.Drawing.Point(776, 132);
            this.labeltimer.Name = "labeltimer";
            this.labeltimer.Size = new System.Drawing.Size(154, 28);
            this.labeltimer.TabIndex = 14;
            this.labeltimer.Text = "Время таймера:";
            this.labeltimer.Visible = false;
            // 
            // labelminute
            // 
            this.labelminute.AutoSize = true;
            this.labelminute.BackColor = System.Drawing.Color.Transparent;
            this.labelminute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelminute.Location = new System.Drawing.Point(757, 169);
            this.labelminute.Name = "labelminute";
            this.labelminute.Size = new System.Drawing.Size(84, 20);
            this.labelminute.TabIndex = 15;
            this.labelminute.Text = "В минутах";
            this.labelminute.Visible = false;
            // 
            // labelsecond
            // 
            this.labelsecond.AutoSize = true;
            this.labelsecond.BackColor = System.Drawing.Color.Transparent;
            this.labelsecond.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelsecond.Location = new System.Drawing.Point(861, 169);
            this.labelsecond.Name = "labelsecond";
            this.labelsecond.Size = new System.Drawing.Size(88, 20);
            this.labelsecond.TabIndex = 16;
            this.labelsecond.Text = "В секундах";
            this.labelsecond.Visible = false;
            // 
            // labeltimersecond
            // 
            this.labeltimersecond.AutoSize = true;
            this.labeltimersecond.BackColor = System.Drawing.Color.Transparent;
            this.labeltimersecond.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltimersecond.Location = new System.Drawing.Point(840, 235);
            this.labeltimersecond.Name = "labeltimersecond";
            this.labeltimersecond.Size = new System.Drawing.Size(15, 23);
            this.labeltimersecond.TabIndex = 17;
            this.labeltimersecond.Text = " ";
            // 
            // timerremaining
            // 
            this.timerremaining.AutoSize = true;
            this.timerremaining.BackColor = System.Drawing.Color.Transparent;
            this.timerremaining.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerremaining.Location = new System.Drawing.Point(781, 186);
            this.timerremaining.Name = "timerremaining";
            this.timerremaining.Size = new System.Drawing.Size(149, 32);
            this.timerremaining.TabIndex = 18;
            this.timerremaining.Text = "Осталось:";
            this.timerremaining.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(241, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 36);
            this.button2.TabIndex = 20;
            this.button2.Text = "Войти через профиль";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(142, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 38);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header.Location = new System.Drawing.Point(131, 18);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(729, 62);
            this.header.TabIndex = 22;
            this.header.Text = "Программа по обучению и тестированию знаний по охране труда.\r\nРазработано Цуприко" +
    "вым Романом.";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addProfile
            // 
            this.addProfile.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProfile.Location = new System.Drawing.Point(90, 257);
            this.addProfile.Name = "addProfile";
            this.addProfile.Size = new System.Drawing.Size(168, 36);
            this.addProfile.TabIndex = 23;
            this.addProfile.Text = "Добавить профиль";
            this.addProfile.UseVisualStyleBackColor = true;
            this.addProfile.Visible = false;
            this.addProfile.Click += new System.EventHandler(this.addProfile_Click);
            // 
            // addQuestion
            // 
            this.addQuestion.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuestion.Location = new System.Drawing.Point(409, 257);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(173, 35);
            this.addQuestion.TabIndex = 24;
            this.addQuestion.Text = "Изменить вопросы";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Visible = false;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // comboBoxMinute
            // 
            this.comboBoxMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinute.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMinute.FormattingEnabled = true;
            this.comboBoxMinute.Items.AddRange(new object[] {
            "60",
            "59",
            "58",
            "57",
            "56",
            "55",
            "54",
            "53",
            "52",
            "51",
            "50",
            "49",
            "48",
            "47",
            "46",
            "45",
            "44",
            "43",
            "42",
            "41",
            "40",
            "39",
            "38",
            "37",
            "36",
            "35",
            "34",
            "33",
            "32",
            "31",
            "30",
            "29",
            "28",
            "27",
            "26",
            "25",
            "24",
            "23",
            "22",
            "21",
            "20",
            "19",
            "18",
            "17",
            "16",
            "15",
            "14",
            "13",
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.comboBoxMinute.Location = new System.Drawing.Point(758, 204);
            this.comboBoxMinute.Name = "comboBoxMinute";
            this.comboBoxMinute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxMinute.Size = new System.Drawing.Size(77, 28);
            this.comboBoxMinute.TabIndex = 25;
            this.comboBoxMinute.Visible = false;
            // 
            // comboBoxSecond
            // 
            this.comboBoxSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecond.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSecond.FormattingEnabled = true;
            this.comboBoxSecond.Items.AddRange(new object[] {
            "60",
            "59",
            "58",
            "57",
            "56",
            "55",
            "54",
            "53",
            "52",
            "51",
            "50",
            "49",
            "48",
            "47",
            "46",
            "45",
            "44",
            "43",
            "42",
            "41",
            "40",
            "39",
            "38",
            "37",
            "36",
            "35",
            "34",
            "33",
            "32",
            "31",
            "30",
            "29",
            "28",
            "27",
            "26",
            "25",
            "24",
            "23",
            "22",
            "21",
            "20",
            "19",
            "18",
            "17",
            "16",
            "15",
            "14",
            "13",
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.comboBoxSecond.Location = new System.Drawing.Point(866, 205);
            this.comboBoxSecond.Name = "comboBoxSecond";
            this.comboBoxSecond.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSecond.Size = new System.Drawing.Size(77, 28);
            this.comboBoxSecond.TabIndex = 26;
            this.comboBoxSecond.Visible = false;
            // 
            // timerWarning
            // 
            this.timerWarning.AutoSize = true;
            this.timerWarning.BackColor = System.Drawing.Color.Transparent;
            this.timerWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerWarning.Location = new System.Drawing.Point(766, 240);
            this.timerWarning.Name = "timerWarning";
            this.timerWarning.Size = new System.Drawing.Size(164, 40);
            this.timerWarning.TabIndex = 27;
            this.timerWarning.Text = "По умолчанию будет\r\n ставиться 10 минут.";
            this.timerWarning.Visible = false;
            // 
            // comboBoxNumberQuestions
            // 
            this.comboBoxNumberQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberQuestions.FormattingEnabled = true;
            this.comboBoxNumberQuestions.Items.AddRange(new object[] {
            "15",
            "14",
            "13",
            "12",
            "11",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBoxNumberQuestions.Location = new System.Drawing.Point(375, 227);
            this.comboBoxNumberQuestions.Name = "comboBoxNumberQuestions";
            this.comboBoxNumberQuestions.Size = new System.Drawing.Size(254, 28);
            this.comboBoxNumberQuestions.TabIndex = 28;
            this.comboBoxNumberQuestions.Visible = false;
            // 
            // numberQuestionsWarning
            // 
            this.numberQuestionsWarning.AutoSize = true;
            this.numberQuestionsWarning.BackColor = System.Drawing.Color.Transparent;
            this.numberQuestionsWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberQuestionsWarning.Location = new System.Drawing.Point(409, 300);
            this.numberQuestionsWarning.Name = "numberQuestionsWarning";
            this.numberQuestionsWarning.Size = new System.Drawing.Size(180, 40);
            this.numberQuestionsWarning.TabIndex = 29;
            this.numberQuestionsWarning.Text = "По умолчанию будет\r\nставиться 15 вопросов.";
            this.numberQuestionsWarning.Visible = false;
            // 
            // numberQuestionsText
            // 
            this.numberQuestionsText.AutoSize = true;
            this.numberQuestionsText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberQuestionsText.Location = new System.Drawing.Point(416, 178);
            this.numberQuestionsText.Name = "numberQuestionsText";
            this.numberQuestionsText.Size = new System.Drawing.Size(173, 20);
            this.numberQuestionsText.TabIndex = 30;
            this.numberQuestionsText.Text = "Количество вопросов:";
            this.numberQuestionsText.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(916, 349);
            this.textBox1.TabIndex = 31;
            this.textBox1.Visible = false;
            // 
            // ResultsText
            // 
            this.ResultsText.AutoSize = true;
            this.ResultsText.BackColor = System.Drawing.Color.Transparent;
            this.ResultsText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultsText.Location = new System.Drawing.Point(142, 41);
            this.ResultsText.Name = "ResultsText";
            this.ResultsText.Size = new System.Drawing.Size(703, 186);
            this.ResultsText.TabIndex = 32;
            this.ResultsText.Text = resources.GetString("ResultsText.Text");
            this.ResultsText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResultsText.Visible = false;
            // 
            // picturesettings
            // 
            this.picturesettings.BackColor = System.Drawing.Color.Transparent;
            this.picturesettings.Image = ((System.Drawing.Image)(resources.GetObject("picturesettings.Image")));
            this.picturesettings.Location = new System.Drawing.Point(82, 28);
            this.picturesettings.Name = "picturesettings";
            this.picturesettings.Size = new System.Drawing.Size(514, 235);
            this.picturesettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturesettings.TabIndex = 33;
            this.picturesettings.TabStop = false;
            this.picturesettings.Visible = false;
            // 
            // pictureBoxtest
            // 
            this.pictureBoxtest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxtest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxtest.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxtest.Image")));
            this.pictureBoxtest.Location = new System.Drawing.Point(437, 107);
            this.pictureBoxtest.Name = "pictureBoxtest";
            this.pictureBoxtest.Size = new System.Drawing.Size(300, 200);
            this.pictureBoxtest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxtest.TabIndex = 34;
            this.pictureBoxtest.TabStop = false;
            this.pictureBoxtest.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 455);
            this.Controls.Add(this.pictureBoxtest);
            this.Controls.Add(this.picturesettings);
            this.Controls.Add(this.ResultsText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numberQuestionsText);
            this.Controls.Add(this.numberQuestionsWarning);
            this.Controls.Add(this.comboBoxNumberQuestions);
            this.Controls.Add(this.timerWarning);
            this.Controls.Add(this.comboBoxSecond);
            this.Controls.Add(this.comboBoxMinute);
            this.Controls.Add(this.addQuestion);
            this.Controls.Add(this.addProfile);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timerremaining);
            this.Controls.Add(this.labeltimersecond);
            this.Controls.Add(this.labelsecond);
            this.Controls.Add(this.labelminute);
            this.Controls.Add(this.labeltimer);
            this.Controls.Add(this.labeltimerminute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Тестирующая система по охране труда";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturesettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeltimerminute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltimer;
        private System.Windows.Forms.Label labelminute;
        private System.Windows.Forms.Label labelsecond;
        private System.Windows.Forms.Label labeltimersecond;
        private System.Windows.Forms.Label timerremaining;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button addProfile;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.ComboBox comboBoxMinute;
        private System.Windows.Forms.ComboBox comboBoxSecond;
        private System.Windows.Forms.Label timerWarning;
        private System.Windows.Forms.ComboBox comboBoxNumberQuestions;
        private System.Windows.Forms.Label numberQuestionsWarning;
        private System.Windows.Forms.Label numberQuestionsText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ResultsText;
        private System.Windows.Forms.PictureBox picturesettings;
        private System.Windows.Forms.PictureBox pictureBoxtest;
    }
}

