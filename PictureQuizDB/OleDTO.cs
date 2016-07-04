using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace PictureQuizDB
{
    class OleDTO : IDTO
    {
        static OleDTO instance = null;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        List<Question> questions = new List<Question>();
        private OleDTO()
        {
            con.ConnectionString = Properties.Settings.Default.DBPath;
            command.CommandType = CommandType.TableDirect;
            adapter = new OleDbDataAdapter("SELECT * FROM Fragen_Antworten ORDER BY ID ASC", con);
            ds = new DataSet();
        }

        public static OleDTO getInstance() //statischer Zugriff über die Klasse, um zu garantieren, dass nur eine Instanz der Klasse existiert (s. Singleton - Pattern, Lazy Initialization)
        {
            if (instance == null)
            {
                instance = new OleDTO();
            }
            return instance;
        }

        public void deleteRows()
        {
            throw new NotImplementedException();
        }

        public void insertRows()
        {
            throw new NotImplementedException();
        }

        public void loadRows() //Die Werte aus der Tabelle "Fragen_Antworten" werden in das DataSet gefüllt.
        {
            adapter.Fill(ds, "Fragen_Antworten");
            dt = ds.Tables["Fragen_Antworten"];
            mkQuestions();
        }

        public void updateRows()
        {
            throw new NotImplementedException();
        }

        private void mkQuestions() //Die Methode "mkQuestion" wird sooft aufgerufen, wie das DataTable-Objekt DataRows-Objekte besitzt.
        {
            DataRow dr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                questions.Add(mkQuestion(dr, i));
            }
        }

        private Question mkQuestion(DataRow dr, int index) //Werte der Datenbank werden verarbeitet und zur Konstruktion der Klasse "Question" verwendet.
        {
            Question question = new Question(index + 1);
            question.QuestionText = checkValue(dr["Frage"]).ToString();
            question.Answer_1 = checkValue(dr["Antwort_1"]).ToString();
            question.Answer_2 = checkValue(dr["Antwort_2"]).ToString();
            question.Answer_3 = checkValue(dr["Antwort_3"]).ToString();
            question.Answer_4 = checkValue(dr["Antwort_4"]).ToString();
            question.Image_1 = checkValue(dr["Bild_1"]).ToString();
            question.Image_2 = checkValue(dr["Bild_2"]).ToString();
            question.Image_3 = checkValue(dr["Bild_3"]).ToString();
            question.Image_4 = checkValue(dr["Bild_4"]).ToString();
            question.CorrectAnswer = Convert.ToInt32(checkValue(dr["Richtige_Antwort"]));
            Console.WriteLine(question.Id + " " + question.QuestionText + " " + question.Answer_1 + " " + question.Image_1 + " " + question.CorrectAnswer);
            return question;
        }

        private object checkValue(object value) //DBNull wird mit "" ersetzt
        {
            if (value == DBNull.Value)
            {
                value = "";
            }
            return value;
        }

        public List<Question> getQuestions() //Fragen u. Antworten werden über das List-Objekt zurückgegeben 
        {
            return questions;
        }
    }
}
