﻿
// This file was auto-generated by ML.NET Model Builder. 

using TumorClassificationModel_v2;
using System.IO;

// Create single instance of sample data from first line of dataset for model input
var imageBytes = File.ReadAllBytes(@"C:\Users\tobin\OneDrive\Skrivebord\MLProjectData\Brain Tumor Data Set\Brain Tumor Data Set\Brain Tumor\Cancer (1).jpg");
TumorClassificationModel_v1.ModelInput sampleData = new TumorClassificationModel_v1.ModelInput()
{
    ImageSource = imageBytes,
};

// Make a single prediction on the sample data and print results.
var predictionResult = TumorClassificationModel_v1.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Label value: {predictionResult.PredictedLabel} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
