﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name="Low Blood Pressure")] Low,
        [Display(Name="Ideal Blood Pressure")]  Ideal,
        [Display(Name="Pre-High Blood Pressure")] PreHigh,
        [Display(Name ="High Blood Pressure")]  High,
        [Display(Name = "Input is invalid")] Error
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG

        // calculate BP category
        public BPCategory Category
        {
            get
            {
                // implement as part of project
                if (Systolic >= 70 && Systolic < 90 && Diastolic >= 40 && Diastolic < 60)
                    return BPCategory.Low;
                else if (Systolic >= 90 && Systolic < 120 && Diastolic >= 60 && Diastolic < 80)
                    return BPCategory.Ideal;
                else if (Systolic >= 120 && Systolic < 140 && Diastolic >= 80 && Diastolic < 90)
                    return BPCategory.PreHigh;
                else if (Systolic >= 140 && Systolic < 190 && Diastolic >= 90 && Diastolic < 100)
                    return BPCategory.High;
                else
                    return BPCategory.Error;


                //throw new NotImplementedException("not implemented yet");
                //return new BPCategory();                       // replace this                    
            }
        }
    }
}
