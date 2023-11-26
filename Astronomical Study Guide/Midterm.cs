using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Study_Guide
{
    class Midterm
    {
        public enum QuestionType
        {
            MultipleChoice = 0,
            TrueOrFalse = 1
        };

        public int questionsInGame;
        private int numberOfQuestions;
        private int numberOfAnswers;
        public int minutes;
        public int seconds;
        private string[] question;
        public string[,] answer;
        public bool[] mastered;
        private int[] order;
        public int[] randomOrder;
        public int score;
        public int antiScore;
        public int questionNumber;
        public string text;
        public string yourAnswer;
        public QuestionType[] questiontype;

        private void Setup_Questions()
        {
            numberOfQuestions = 40;
            numberOfAnswers = 4;
            question = new string[numberOfQuestions];
            answer = new string[numberOfQuestions, numberOfAnswers];
            questiontype = new QuestionType[numberOfQuestions];
            mastered = new bool[numberOfQuestions];

            question[0] = ""; answer[0, 0] = ""; answer[0, 1] = ""; answer[0, 2] = ""; answer[0, 3] = ""; questiontype[0] = QuestionType.MultipleChoice;
            question[1] = ""; answer[1, 0] = ""; answer[1, 1] = ""; answer[1, 2] = ""; answer[1, 3] = ""; questiontype[1] = QuestionType.MultipleChoice;
            question[2] = ""; answer[2, 0] = ""; answer[2, 1] = ""; answer[2, 2] = ""; answer[2, 3] = ""; questiontype[2] = QuestionType.MultipleChoice;
            question[3] = ""; answer[3, 0] = ""; answer[3, 1] = ""; answer[3, 2] = ""; answer[3, 3] = ""; questiontype[3] = QuestionType.MultipleChoice;
            question[4] = ""; answer[4, 0] = ""; answer[4, 1] = ""; answer[4, 2] = ""; answer[4, 3] = ""; questiontype[4] = QuestionType.MultipleChoice;
            question[5] = ""; answer[5, 0] = ""; answer[5, 1] = ""; answer[5, 2] = ""; answer[5, 3] = ""; questiontype[5] = QuestionType.MultipleChoice;
            question[6] = ""; answer[6, 0] = ""; answer[6, 1] = ""; answer[6, 2] = ""; answer[6, 3] = ""; questiontype[6] = QuestionType.MultipleChoice;
            question[7] = ""; answer[7, 0] = ""; answer[7, 1] = ""; answer[7, 2] = ""; answer[7, 3] = ""; questiontype[7] = QuestionType.MultipleChoice;
            question[8] = ""; answer[8, 0] = ""; answer[8, 1] = ""; answer[8, 2] = ""; answer[8, 3] = ""; questiontype[8] = QuestionType.MultipleChoice;
            question[9] = ""; answer[9, 0] = ""; answer[9, 1] = ""; answer[9, 2] = ""; answer[9, 3] = ""; questiontype[9] = QuestionType.MultipleChoice;
            question[10] = ""; answer[10, 0] = ""; answer[10, 1] = ""; answer[10, 2] = ""; answer[10, 3] = ""; questiontype[10] = QuestionType.MultipleChoice;
            question[11] = ""; answer[11, 0] = ""; answer[11, 1] = ""; answer[11, 2] = ""; answer[11, 3] = ""; questiontype[11] = QuestionType.MultipleChoice;
            question[12] = ""; answer[12, 0] = ""; answer[12, 1] = ""; answer[12, 2] = ""; answer[12, 3] = ""; questiontype[12] = QuestionType.MultipleChoice;
            question[13] = ""; answer[13, 0] = ""; answer[13, 1] = ""; answer[13, 2] = ""; answer[13, 3] = ""; questiontype[13] = QuestionType.MultipleChoice;
            question[14] = ""; answer[14, 0] = ""; answer[14, 1] = ""; answer[14, 2] = ""; answer[14, 3] = ""; questiontype[14] = QuestionType.MultipleChoice;
            question[15] = ""; answer[15, 0] = ""; answer[15, 1] = ""; answer[15, 2] = ""; answer[15, 3] = ""; questiontype[15] = QuestionType.MultipleChoice;
            question[16] = ""; answer[16, 0] = ""; answer[16, 1] = ""; answer[16, 2] = ""; answer[16, 3] = ""; questiontype[16] = QuestionType.MultipleChoice;
            question[17] = ""; answer[17, 0] = ""; answer[17, 1] = ""; answer[17, 2] = ""; answer[17, 3] = ""; questiontype[17] = QuestionType.MultipleChoice;
            question[18] = ""; answer[18, 0] = ""; answer[18, 1] = ""; answer[18, 2] = ""; answer[18, 3] = ""; questiontype[18] = QuestionType.MultipleChoice;
            question[19] = ""; answer[19, 0] = ""; answer[19, 1] = ""; answer[19, 2] = ""; answer[19, 3] = ""; questiontype[19] = QuestionType.MultipleChoice;
            question[20] = ""; answer[20, 0] = ""; answer[20, 1] = ""; answer[20, 2] = ""; answer[20, 3] = ""; questiontype[20] = QuestionType.MultipleChoice;
            question[21] = ""; answer[21, 0] = ""; answer[21, 1] = ""; answer[21, 2] = ""; answer[21, 3] = ""; questiontype[21] = QuestionType.MultipleChoice;
            question[22] = ""; answer[22, 0] = ""; answer[22, 1] = ""; answer[22, 2] = ""; answer[22, 3] = ""; questiontype[22] = QuestionType.MultipleChoice;
            question[23] = ""; answer[23, 0] = ""; answer[23, 1] = ""; answer[23, 2] = ""; answer[23, 3] = ""; questiontype[23] = QuestionType.MultipleChoice;
            question[24] = ""; answer[24, 0] = ""; answer[24, 1] = ""; answer[24, 2] = ""; answer[24, 3] = ""; questiontype[24] = QuestionType.MultipleChoice;
            question[25] = ""; answer[25, 0] = ""; answer[25, 1] = ""; answer[25, 2] = ""; answer[25, 3] = ""; questiontype[25] = QuestionType.MultipleChoice;
            question[26] = ""; answer[26, 0] = ""; answer[26, 1] = ""; answer[26, 2] = ""; answer[26, 3] = ""; questiontype[26] = QuestionType.MultipleChoice;
            question[27] = ""; answer[27, 0] = ""; answer[27, 1] = ""; answer[27, 2] = ""; answer[27, 3] = ""; questiontype[27] = QuestionType.MultipleChoice;
            question[28] = ""; answer[28, 0] = ""; answer[28, 1] = ""; answer[28, 2] = ""; answer[28, 3] = ""; questiontype[28] = QuestionType.MultipleChoice;
            question[29] = ""; answer[29, 0] = ""; answer[29, 1] = ""; answer[29, 2] = ""; answer[29, 3] = ""; questiontype[29] = QuestionType.MultipleChoice;
            question[30] = ""; answer[30, 0] = ""; answer[30, 1] = ""; answer[30, 2] = ""; answer[30, 3] = ""; questiontype[30] = QuestionType.MultipleChoice;
            question[31] = ""; answer[31, 0] = ""; answer[31, 1] = ""; answer[31, 2] = ""; answer[31, 3] = ""; questiontype[31] = QuestionType.MultipleChoice;
            question[32] = ""; answer[32, 0] = ""; answer[32, 1] = ""; answer[32, 2] = ""; answer[32, 3] = ""; questiontype[32] = QuestionType.MultipleChoice;
            question[33] = ""; answer[33, 0] = ""; answer[33, 1] = ""; answer[33, 2] = ""; answer[33, 3] = ""; questiontype[33] = QuestionType.MultipleChoice;
            question[34] = ""; answer[34, 0] = ""; answer[34, 1] = ""; answer[34, 2] = ""; answer[34, 3] = ""; questiontype[34] = QuestionType.MultipleChoice;
            question[35] = ""; answer[35, 0] = ""; answer[35, 1] = ""; answer[35, 2] = ""; answer[35, 3] = ""; questiontype[35] = QuestionType.MultipleChoice;
            question[36] = ""; answer[36, 0] = ""; answer[36, 1] = ""; answer[36, 2] = ""; answer[36, 3] = ""; questiontype[36] = QuestionType.MultipleChoice;
            question[37] = ""; answer[37, 0] = ""; answer[37, 1] = ""; answer[37, 2] = ""; answer[37, 3] = ""; questiontype[37] = QuestionType.MultipleChoice;
            question[38] = ""; answer[38, 0] = ""; answer[38, 1] = ""; answer[38, 2] = ""; answer[38, 3] = ""; questiontype[38] = QuestionType.MultipleChoice;
            question[39] = ""; answer[39, 0] = ""; answer[39, 1] = ""; answer[39, 2] = ""; answer[39, 3] = ""; questiontype[39] = QuestionType.MultipleChoice;

            order = new int[numberOfQuestions];
            randomOrder = new int[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                order[i] = i;
                randomOrder[i] = i;
            }
        }

        public Midterm()
        {
            Setup_Questions();
        }

        public void Randomize_Questions()
        {
            Random rnd = new Random();
            randomOrder = order.OrderBy(x => rnd.Next()).ToArray();
        }

        public string Get_Question(int index)
        {
            if (index >= 0 && index < numberOfQuestions)
            {
                return question[index];
            }

            return string.Empty;
        }

        public string Get_Answer(int index)
        {
            if (index >= 0 && index < numberOfQuestions)
            {
                return answer[index, 0];
            }

            return string.Empty;
        }

        public int Get_Number_Of_Questions()
        {
            return numberOfQuestions;
        }

        public int Get_Minutes()
        {
            return minutes;
        }

        public int Get_Seconds()
        {
            return seconds;
        }
    }
}
