// See https://aka.ms/new-console-template for more information
// Add input data
using LearnML;

Console.WriteLine("Enter your review");
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = Console.ReadLine()
};

// Load model and predict output of sample data
var result = SentimentModel.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
string sentiment = result.Prediction == 1 ? $"{result.Score[1]:P} Positive" : $"{result.Score[0]:P} Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
