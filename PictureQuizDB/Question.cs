using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PictureQuizDB
{
    public class Question
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { }
        }
        public String QuestionText { get; set; }
        public String Answer_1 { get; set; }
        public String Answer_2 { get; set; }
        public String Answer_3 { get; set; }
        public String Answer_4 { get; set; }
        public String Image_1 { get; set; }
        public String Image_2 { get; set; }
        public String Image_3 { get; set; }
        public String Image_4 { get; set; }
        public int CorrectAnswer { get; set; }

        public Question(int id)
        {
            this.Id = id;
        }
    }
}
