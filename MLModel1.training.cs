﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace CICDPoc
{
    public partial class MLModel1
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"col0", @"col0"),new InputOutputColumnPair(@"col1", @"col1"),new InputOutputColumnPair(@"col2", @"col2"),new InputOutputColumnPair(@"col5", @"col5"),new InputOutputColumnPair(@"col6", @"col6"),new InputOutputColumnPair(@"col7", @"col7"),new InputOutputColumnPair(@"col8", @"col8"),new InputOutputColumnPair(@"col10", @"col10"),new InputOutputColumnPair(@"col11", @"col11"),new InputOutputColumnPair(@"col12", @"col12")})      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"col3", @"col3"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"col4", @"col4"))      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(@"col9", @"col9"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"col0",@"col1",@"col2",@"col5",@"col6",@"col7",@"col8",@"col10",@"col11",@"col12",@"col3",@"col4",@"col9"}))      
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(@"col13", @"col13"))      
                                    .Append(mlContext.Transforms.NormalizeMinMax(@"Features", @"Features"))      
                                    .Append(mlContext.MulticlassClassification.Trainers.LbfgsMaximumEntropy(l1Regularization:0.182722152871016F,l2Regularization:2.65622188477284F,labelColumnName:@"col13",featureColumnName:@"Features"))      
                                    .Append(mlContext.Transforms.Conversion.MapKeyToValue(@"PredictedLabel", @"PredictedLabel"));

            return pipeline;
        }
    }
}