using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureQuizDB
{
    public class Quiz
    {
        OleDTO accDto;
        List<Question> questions = new List<Question>();
        int index = -1;
        public String DBPath { get; set; } //Pfad auf die Datenbank ist in der Settings.settings-Datei des Form-Projekts "PictureQuiz" gespeichert und wird im Konstruktor der Klasse übergeben.

        private int correctAnswer;
        private int answer1;
        private int answer2;
        private int roundNumber;
        private int maxRounds;
        private bool isFinalRound;

        public int RoundNumber
        {
            get
            {
                return roundNumber;
            }

            set
            {
                roundNumber = value;
            }
        }

        public int MaxRounds
        {
            get
            {
                return maxRounds;
            }

            set
            {
                maxRounds = value;
            }
        }

        public bool IsFinalRound
        {
            get
            {
                return isFinalRound;
            }

            set
            {
                isFinalRound = value;
            }
        }

        public Quiz(String dbPath) //dbPath: Pfad auf die Datenbank
        {
            DBPath = dbPath;
            Properties.Settings.Default.DBPath = DBPath;
        }

        public void startQuiz()
        {
            accDto = OleDTO.getInstance(); //Singleton - Pattern (nur eine Instanz der Datenbankverbindung möglich!)
            accDto.loadRows();
            questions = accDto.getQuestions();
            MaxRounds = 10;
            RoundNumber = 1;
            IsFinalRound = false;
            index = -1;
        }

        public void stopQuiz()
        {
            index = -1;
        }

        public int fiftyFiftyJoker(int correctAnswer, int answer1, int answer2) //Methode funktioniert nicht ganz richtig
        {
            this.correctAnswer = correctAnswer;
            Random r = new Random();
            int rInt = r.Next(1, 4);
            if (rInt == correctAnswer)
            {
                bool rBool;
                rBool = Convert.ToBoolean(r.Next(0, 1));
                if (rBool)
                {
                    if (correctAnswer != 4)
                    {
                        rInt += 1;
                    }
                    else
                    {
                        rInt -= 1;
                    }
                }
                else
                {
                    if (correctAnswer != 1)
                    {
                        rInt -= 1;
                    }
                    else
                    {
                        rInt += 1;
                    }
                }
                if (rInt == answer1)
                {
                    rBool = Convert.ToBoolean(r.Next(0, 1));
                    if (rBool)
                    {
                        if (answer1 != 4)
                        {
                            rInt += 1;
                        }
                        else
                        {
                            rInt -= 1;
                        }
                    }
                    else
                    {
                        if (answer1 != 1)
                        {
                            rInt -= 1;
                        }
                        else
                        {
                            rInt += 1;
                        }
                    }
                }
                this.answer1 = answer1;
                this.answer2 = answer2;
            }
            return rInt;
        }

        public Question chooseQuestion() //Methode sollte ursprünglich aus 100 eingelesenen Fragen zehn zufällig auswählen.
        {
            index++;
            return questions[index];
        }
    }
}
