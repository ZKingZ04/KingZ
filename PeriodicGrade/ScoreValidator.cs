using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PeriodicGrade
{
    internal class ScoreValidator
    {
        public static double ValidateScore(string score, int minItems, int maxItems, string scoreType)
        {
            if (string.IsNullOrWhiteSpace(score))
                score = "0";

            if (!double.TryParse(score, out double numericScore) || numericScore < 0 || numericScore > maxItems)
                throw new ArgumentException(scoreType + " score must be between 0 and " + maxItems + " with a valid numeric input.");

            return numericScore;
        }

        public static int ValidateTotalItemsCount(string totalItems, int minItems, int maxItems, string itemType)
        {
            if (!int.TryParse(totalItems, out int numericTotalItems) || numericTotalItems < minItems || numericTotalItems > maxItems)
                throw new ArgumentOutOfRangeException(itemType + " total items must be between " + minItems + " and " + maxItems + " with a valid integer input.");

            return numericTotalItems;
        }
    }
}
