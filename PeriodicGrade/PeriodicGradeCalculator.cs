using System;

namespace PeriodicGrade
{
    internal class PeriodicGradeCalculator
    {
        public static double ComputePeriodicGrade(
    double[] quizScores, double[] quizTotalItems,
    double[] classActivityScores, double[] classActivityTotalItems,
    double examScore)
        {
            double totalScore = GetTotalScore(
                quizScores,
                classActivityScores,
                examScore);

            double totalItems = GetTotalItems(
                quizTotalItems,
                classActivityTotalItems,
                100);

            double periodicGrade = (totalScore / totalItems) * 100;

            return periodicGrade;
        }

        private static double GetTotalScore(
            double[] quizScores,
            double[] classActivityScores,
            double examScore)
        {
            return quizScores.Sum() + classActivityScores.Sum() + examScore;
        }

        private static double GetTotalItems(
            double[] quizTotalItems,
            double[] classActivityTotalItems,
            double examTotalItems)
        {
            return quizTotalItems.Sum() + classActivityTotalItems.Sum() + examTotalItems;
        }
        public static double ComputeEquivalentGrade(double periodicGrade)
        {
            if (periodicGrade >= 97.5)
            {
                return 1.0;
            }
            else if (periodicGrade >= 94.0)
            {
                return 1.25;
            }
            else if (periodicGrade >= 91.5)
            {
                return 1.5;
            }
            else if (periodicGrade >= 88.5)
            {
                return 1.75;
            }
            else if (periodicGrade >= 85.5)
            {
                return 2.0;
            }
            else if (periodicGrade >= 82.5)
            {
                return 2.25;
            }
            else if (periodicGrade >= 79.5)
            {
                return 2.5;
            }
            else if (periodicGrade >= 76.5)
            {
                return 2.75;
            }
            else if (periodicGrade >= 74.5)
            {
                return 3.0;
            }
            else
            {
                return 5.0;
            }
        }

        public static string GetRemarks(double periodicGrade)
        {
            return periodicGrade >= 75 ? "Passed" : "Failed";
        }
    }
}
