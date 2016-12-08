﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string Description
        {
            get
            {
                string result;
                switch(LetterGrade)
                {
                    case "A":
                        result = "Excellent!";
                        break;
                    case "B":
                        result = "Good Job";
                        break;
                    case "C":
                        result = "You'll be OK...";
                        break;
                    case "D":
                        result = "You need some work...";
                        break;
                    default:
                        result = "Get out...";
                        break;
                }

                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if(AverageGrade >= 90)
                {
                    result = "A";
                }
                else if(AverageGrade >= 80)
                {
                    result = "B";
                }
                else if(AverageGrade >= 70)
                {
                    result = "C";
                }
                else if(AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }

                return result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
