using System;
using System.Windows.Forms;

namespace PeriodicGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                (double quiz1Score, int quiz1TotalItems) = ValidateScoreAndTotalItems(txtQuiz1.Text, txtQuizN1.Text, "Quiz 1", 0, 50, 5, 50);

                (double quiz2Score, int quiz2TotalItems) = ValidateScoreAndTotalItems(txtQuiz2.Text, txtQuizN2.Text, "Quiz 2", 0, 50, 5, 50);

                (double lab1Score, int lab1TotalItems) = ValidateScoreAndTotalItems(txtLab1.Text, txtLabN1.Text, "Laboratory Activity 1", 0, 100, 50, 100);

                (double lab2Score, int lab2TotalItems) = ValidateScoreAndTotalItems(txtLab2.Text, txtLabN2.Text, "Laboratory Activity 2", 0, 100, 50, 100);

                (double lab3Score, int lab3TotalItems) = ValidateScoreAndTotalItems(txtLab3.Text, txtLabN3.Text, "Laboratory Activity 3", 0, 100, 50, 100);

                (double class1Score, int class1TotalItems) = ValidateScoreAndTotalItems(txtClass1.Text, txtClassN1.Text, "Class Activity 1", 0, 100, 30, 100);

                (double class2Score, int class2TotalItems) = ValidateScoreAndTotalItems(txtClass2.Text, txtClassN2.Text, "Class Activity 2", 0, 100, 30, 100);

                (double class3Score, int class3TotalItems) = ValidateScoreAndTotalItems(txtClass3.Text, txtClassN3.Text, "Class Activity 3", 0, 100, 30, 100);

                double examScore = ValidateScore(txtExam, "Exam", 0, 100);

                double[] quizScores = new double[] { quiz1Score, quiz2Score };
                double[] quizTotalItems = new double[] { quiz1TotalItems, quiz2TotalItems };
                double[] classActivityScores = new double[] { class1Score, class2Score, class3Score };
                double[] classActivityTotalItems = new double[] { class1TotalItems, class2TotalItems, class3TotalItems };

                double periodicGrade = PeriodicGradeCalculator.ComputePeriodicGrade(
                    quizScores, quizTotalItems,
                    classActivityScores, classActivityTotalItems,
                    examScore);

                double equivalentGrade = PeriodicGradeCalculator.ComputeEquivalentGrade(periodicGrade);
                string remarks = PeriodicGradeCalculator.GetRemarks(periodicGrade);

                lblPeriodicGrade.Text = periodicGrade.ToString("0.00");
                lblEquivalentGrade.Text = equivalentGrade.ToString("0.00");
                lblRemarks.Text = remarks;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static (double, int) ValidateScoreAndTotalItems(string quiz1, string quizN1, string activityName, int minScore, int maxScore, int minTotalItems, int maxTotalItems)
        {
            double quiz1Score = ScoreValidator.ValidateScore(quiz1, minScore, maxScore, activityName); int quiz1TotalItems = ScoreValidator.ValidateTotalItemsCount(quizN1, minTotalItems, maxTotalItems, activityName);

            return (quiz1Score, quiz1TotalItems);
        }

        private static double ValidateScore(TextBox textBox, string activityName, int minScore, int maxScore)
        {
            double score = ScoreValidator.ValidateScore(textBox.Text, minScore, maxScore, activityName);

            return score;
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuiz1.Text = "";
            txtQuizN1.Text = "";
            txtQuiz2.Text = "";
            txtQuizN2.Text = "";
            txtLab1.Text = "";
            txtLabN1.Text = "";
            txtLabN2.Text = "";
            txtLab2.Text = "";
            txtLabN3.Text = "";
            txtLab3.Text = "";
            txtClass1.Text = "";
            txtClassN1.Text = "";
            txtClass2.Text = "";
            txtClassN2.Text = "";
            txtClass3.Text = "";
            txtClassN3.Text = "";
            txtExam.Text = "";
            lblPeriodicGrade.Text = "0.0";
            lblEquivalentGrade.Text = "0.0";
            lblRemarks.Text = "None";
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void txtQuizN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuizN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupQuiz_Enter(object sender, EventArgs e)
        {

        }

        private void lblPeriodicGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
