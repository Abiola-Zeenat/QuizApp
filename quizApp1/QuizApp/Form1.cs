using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {

        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }


        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
                MessageBox.Show("Correct");

            }
            else
            {
                MessageBox.Show(
                    "Wrong" + Environment.NewLine +
                    "Option " + correctAnswer+
              " is the correct answer"
                    );
            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "Which city is the captial city of England?";
                    button1.Text = "Birmingham";
                    button2.Text = "Brighton";
                    button3.Text = "Liverpool";
                    button4.Text = "London";
                    correctAnswer = 4;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "What is the most visited tourist attraction in the world?";
                    button1.Text = "Statue of liberty";
                    button2.Text = "Eiffel Tower";
                    button3.Text = "Colosseum";
                    button4.Text = "Great wall of China";
                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "What is the heaviest organ in the human body?";
                    button1.Text = "Skin";
                    button2.Text = "Brain";
                    button3.Text = "Heart";
                    button4.Text = "Liver";
                    correctAnswer = 4;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "Who was the first Disney Princess?";
                    button1.Text = "Jasmine";
                    button2.Text = "Cinderella";
                    button3.Text = "Snow White";
                    button4.Text = "Aurora";
                    correctAnswer = 3;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "What is the highest-grossing video game franchise to date?";
                    button1.Text = "Pokemon";
                    button2.Text = "Mario";
                    button3.Text = "Uncharted";
                    button4.Text = "Call of Duty";
                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "What sport has been played on the moon?";
                    button1.Text = "Bocce ball";
                    button2.Text = "Soccer";
                    button3.Text = "Golf";
                    button4.Text = "Basket ball";
                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "Who was Geralt looking for in Witcher 3?";
                    button1.Text = "Victoria";
                    button2.Text = "Mr Donut";
                    button3.Text = "Ciri";
                    button4.Text = "Yennifer";
                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "Mycology is the scientific study of what?";
                    button1.Text = "Cancer cell";
                    button2.Text = "Fungi";
                    button3.Text = "Blood";
                    button4.Text = "Flowers";
                    correctAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "Which animal is the closest living relative to human?";
                    button1.Text = "Bonobos";
                    button2.Text = "Gorillas";
                    button3.Text = "Monkeys";
                    button4.Text = "cats";
                    correctAnswer = 1;
                    break;
               case 10:
                    pictureBox1.Image = Properties.Resources.background_3;
                    label1.Text = "Which sea creature has three hearts?";
                    button1.Text = "Shark";
                    button2.Text = "Jellyfish";
                    button3.Text = "Octopus";
                    button4.Text = "Crocodile";
                    correctAnswer = 3;
                    break;
            }

        }
    }
}
