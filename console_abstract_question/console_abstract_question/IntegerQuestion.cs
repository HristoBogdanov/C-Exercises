using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_abstract_question
{
    public class IntegerQuestion : Question
    {
        private int studentanswer;
        private int wrighanswer;
        public int StudentAnswer {
            get
            {
                return this.studentanswer;
            }
            set {
                if (value <= 0) throw new ArgumentException("Invalid data");
                else this.studentanswer = value;
            }
            }    
        public int WrightAnswer
        {
            get {
                return this.wrighanswer;
            }
            set {
                if (value <= 0) throw new ArgumentException("Invalid data");
                else this.wrighanswer = value;
            }
        }

        public IntegerQuestion(int studentanswer, int wrightanswer)
        {
            this.StudentAnswer = studentanswer;
            this.WrightAnswer = wrighanswer;
        }

        public override void askQuestion()
        {
            Console.WriteLine("Question: What is 4 times 5? Answer on next line: ");
            this.StudentAnswer = int.Parse(Console.ReadLine());
            
        }
    }
}
