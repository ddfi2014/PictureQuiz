using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PictureQuizDB;
using System.Reflection;

namespace PictureQuiz
{
    public partial class FormQuiz : Form
    {
        Quiz quizControl;
        Question question;
        string filePath;
        string fileDir;
        public FormQuiz()
        {
            InitializeComponent();
            filePath = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath; //Methode übergibt den absoluten Dateipfad der .exe-Datei
            fileDir = Path.GetDirectoryName(filePath).Replace("%20", " ");                  //Methode isoliert den absoluten Dateipfad auf den Ordner, in der sich die .exe-Datei befindet
            quizControl = new Quiz(Properties.Settings.Default.DBPathTest);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pBox = (PictureBox)sender;
            pBox.BorderStyle = BorderStyle.None;
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pBox = (PictureBox)sender;
            pBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //labelQuestion.Text = "I";
            int value = 1;                  //Vergleichswert
            checkAnswer(value);             //Vergleichswert wird mit dem Wert von "question.correctAnswer" abgeglichen
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //labelQuestion.Text = "II";
            int value = 2;
            checkAnswer(value);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //labelQuestion.Text = "III";
            int value = 3;
            checkAnswer(value);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //labelQuestion.Text = "IV";
            int value = 4;
            checkAnswer(value);
        }

        private void checkAnswer(int value)             //Auswertung der Antwort
        {
            if (value == question.CorrectAnswer)
            {
                DialogResult diaResult = MessageBox.Show("Ihre Antwort war korrekt!", "Richtige Antwort!");
                if (diaResult == DialogResult.OK)
                {
                    if (!quizControl.IsFinalRound)
                    {
                        nextRound();
                    }
                    else
                    {
                        diaResult = MessageBox.Show("Herzlichen Glückwunsch! Sie haben alle Fragen korrekt beantwortet! Nochmal spielen?", "Sie haben gewonnen!", MessageBoxButtons.YesNo);
                        if (diaResult == DialogResult.Yes) //Benutzer möchte nochmal spielen
                        {
                            initializeQuiz();
                        }
                        else if (diaResult == DialogResult.No)  //Benutzer möchte nicht mehr weiterspielen
                        {
                            gameOver();
                        }
                    }
                }
            }
            else
            {
                DialogResult diaResult = MessageBox.Show("Das Spiel ist aus!", "Falsche Antwort!");
                if (diaResult == DialogResult.OK)
                {
                    gameOver();
                }
            }
        }

        private void pictureBoxTelephoneJoker_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Wollen Sie wirklich den Telefonjoker verwenden?", "Telefonjoker", MessageBoxButtons.YesNo);
            if (diaResult == DialogResult.Yes)
            {
                pictureBoxTelephoneJoker.Enabled = false;
                pictureBoxTelephoneJoker.Image = Properties.Resources.telefonjoker_dis;
                //quizControl.telephoneJoker();
                TelephoneJokerDialog tjg = new TelephoneJokerDialog();
                tjg.Show();
            }
        }

        private void pictureBoxFiftyFiftyJoker_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Wollen Sie wirklich den 50:50 Joker verwenden?", "50:50 Joker", MessageBoxButtons.YesNo);
            if (diaResult == DialogResult.Yes)
            {
                int answer1 = 0;    //1. Antwort die wegfällt
                int answer2 = 0;    //2. Antwort die wegfällt
                pictureBoxFiftyFiftyJoker.Enabled = false;
                pictureBoxFiftyFiftyJoker.Image = Properties.Resources._50_50__joker__dis;
                answer1 = quizControl.fiftyFiftyJoker(question.CorrectAnswer, answer1, answer2); //Wert für die 
                answer2 = quizControl.fiftyFiftyJoker(question.CorrectAnswer, answer1, answer2);
                eliminateAnswers(answer1, answer2);
            }
        }

        private void pictureBoxAudienceJoker_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Wollen Sie wirklich den Publikumsjoker verwenden?", "Publikumsjoker", MessageBoxButtons.YesNo);
            if (diaResult == DialogResult.Yes)
            {
                pictureBoxAudienceJoker.Enabled = false;
                pictureBoxAudienceJoker.Image = Properties.Resources.publikumsjoker_dis;
                //quizControl.audienceJoker();
                MessageBox.Show("Publikumsjoker ist nicht implementiert.", "Fehlende Implementation", MessageBoxButtons.OK);
            }
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            initializeQuiz();
        }

        private void initializeQuiz()
        {
            quizControl.IsFinalRound = false;
            newGame();
            quizControl.startQuiz();
            initializeRound();
        }

        private void newGame()
        {
            toolStripStatusLabelRound.Text = "Runde " + 0 + quizControl.RoundNumber;    //Runde wird hochgezählt
            enablePictureBoxes();
            pictureBoxAudienceJoker.Enabled = true;
            pictureBoxAudienceJoker.Image = Properties.Resources.publikumsjoker;
            pictureBoxFiftyFiftyJoker.Enabled = true;
            pictureBoxFiftyFiftyJoker.Image = Properties.Resources._50_50__joker_;
            pictureBoxTelephoneJoker.Enabled = true;
            pictureBoxTelephoneJoker.Image = Properties.Resources.telefonjoker;
            //quizControl.stopQuiz();
        }

        private void enablePictureBoxes()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
        }

        private void eliminateAnswers(int answer1, int answer2)
        {
            if (answer1 == 1)
            {
                pictureBox1.Enabled = false;
            }
            else if (answer1 == 2)
            {
                pictureBox1.Enabled = false;
            }
            else if (answer1 == 3)
            {
                pictureBox1.Enabled = false;
            }
            else if (answer1 == 4)
            {
                pictureBox1.Enabled = false;
            }
            if (answer2 == 1)
            {
                pictureBox1.Enabled = false;
            }
            else if (answer2 == 2)
            {
                pictureBox2.Enabled = false;
            }
            else if (answer2 == 3)
            {
                pictureBox3.Enabled = false;
            }
            else if (answer2 == 4)
            {
                pictureBox4.Enabled = false;
            }
        }

        private void nextRound()
        {
            quizControl.RoundNumber++;
            if (quizControl.RoundNumber < quizControl.MaxRounds)
            {
                toolStripStatusLabelRound.Text = "Runde " + 0 + quizControl.RoundNumber;
                initializeRound();
            }
            else
            {
                toolStripStatusLabelRound.Text = "Runde " + quizControl.RoundNumber;
                finalRound();
            }
        }

        private void finalRound()
        {
            DialogResult diaResult = MessageBox.Show("Gratulation! Sie haben es bis in die Finalrunde geschafft! Können Sie auch die letzte Frage beantworten?", "Finale");
            if (diaResult == DialogResult.OK)
            {
                initializeRound();
                quizControl.IsFinalRound = true;
            }
        }

        private void gameOver()
        {
            quizControl.IsFinalRound = false;
            toolStripStatusLabelRound.Text = "Klicken Sie auf \"neu\" um das Quiz zu starten!";
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.roman_numeral_I;
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.roman_numeral_II;
            pictureBox3.Enabled = false;
            pictureBox3.Image = Properties.Resources.roman_numeral_III;
            pictureBox4.Enabled = false;
            pictureBox4.Image = Properties.Resources.roman_numeral_IV;
            pictureBoxAudienceJoker.Enabled = false;
            pictureBoxFiftyFiftyJoker.Enabled = false;
            pictureBoxTelephoneJoker.Enabled = false;
            labelAntwort1.Text = "Answer1";
            labelAntwort2.Text = "Answer2";
            labelAntwort3.Text = "Answer3";
            labelAntwort4.Text = "Answer4";
            labelQuestion.Text = "Question";
        }

        private void initializeRound()
        {
            question = quizControl.chooseQuestion();
            if (!question.Image_1.Equals(""))
            {
                Image[] img = { Image.FromFile(fileDir + question.Image_1), Image.FromFile(fileDir + question.Image_2), Image.FromFile(fileDir + question.Image_3), Image.FromFile(fileDir + question.Image_4) };
                pictureBox1.Image = img[0];
                pictureBox2.Image = img[1];
                pictureBox3.Image = img[2];
                pictureBox4.Image = img[3];
            }
            else
            {
                pictureBox1.Image = Properties.Resources.roman_numeral_I;
                pictureBox2.Image = Properties.Resources.roman_numeral_II;
                pictureBox3.Image = Properties.Resources.roman_numeral_III;
                pictureBox4.Image = Properties.Resources.roman_numeral_IV;
                                                                                            //I - IV sind Platzhalter, sollten keine Bilder vorhanden sein.
            }
            enablePictureBoxes();
            labelQuestion.Text = question.QuestionText;
            labelAntwort1.Text = question.Answer_1;
            labelAntwort2.Text = question.Answer_2;
            labelAntwort3.Text = question.Answer_3;
            labelAntwort4.Text = question.Answer_4;
        }
    }
}
