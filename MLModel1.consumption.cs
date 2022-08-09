﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace Assembly_CSharp
{
    public partial class MLModel1
    {
        /// <summary>
        /// model input class for MLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"Name")]
            public string Name { get; set; }

            [ColumnName(@"lvl2playertime")]
            public string Lvl2playertime { get; set; }

            [ColumnName(@"lvl2aitime")]
            public string Lvl2aitime { get; set; }

            [ColumnName(@"lvl2idle")]
            public string Lvl2idle { get; set; }

            [ColumnName(@"lvl2playeraitime")]
            public string Lvl2playeraitime { get; set; }

            [ColumnName(@"lvl3score")]
            public string Lvl3score { get; set; }

            [ColumnName(@"lvl3aitime")]
            public string Lvl3aitime { get; set; }

            [ColumnName(@"lvl3idle")]
            public string Lvl3idle { get; set; }

            [ColumnName(@"lvl4score")]
            public string Lvl4score { get; set; }

            [ColumnName(@"lvl4aitime")]
            public string Lvl4aitime { get; set; }

            [ColumnName(@"lvl4idle")]
            public string Lvl4idle { get; set; }

            [ColumnName(@"lvl5score")]
            public string Lvl5score { get; set; }

            [ColumnName(@"lvl5totalshot")]
            public string Lvl5totalshot { get; set; }

            [ColumnName(@"lvl5left")]
            public string Lvl5left { get; set; }

            [ColumnName(@"lvl5right")]
            public string Lvl5right { get; set; }

            [ColumnName(@"lvl5total")]
            public string Lvl5total { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName("PredictedLabel")]
            public string Prediction { get; set; }

            public float[] Score { get; set; }
        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel1.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
