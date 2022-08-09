using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicNetML.Arff;

namespace TestingProjectName
{
    public class TitanicRow
    {
        [IgnoreFeature] public string passengerid { get; set; }
        [Nominal("0,1")] public string survived { get; set; }
        [Nominal("1,2,3")] public string pclass { get; set; }
        [IgnoreFeature] public string name { get; set; }
        [Nominal("male,female")] public string sex { get; set; }
        [IgnoreFeature] public double age { get; set; }
        [IgnoreFeature] public int sibsp { get; set; }
        [IgnoreFeature] public int parch { get; set; }
        [IgnoreFeature] public string ticket { get; set; }
        [IgnoreFeature] public string fare { get; set; }
        [IgnoreFeature] public string cabin { get; set; }
        [Nominal("C,Q,S")] public string embarked { get; set; }

        // We can also add some custom properies such as:

        [Nominal]
        public string agec
        {
            get
            {
                if (age <= 0 || age >= 100) return "NA";
                if (age < 4) return "toddler";
                if (age < 7) return "infant";
                if (age < 14) return "child";
                if (age < 20) return "youth";
                if (age < 40) return "adult";
                if (age < 80) return "middleaged";
                if (age < 100) return "old";

                throw new ApplicationException("Invalid age: " + age);
            }
        }
    }
}