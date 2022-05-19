// See https://aka.ms/new-console-template for more information
using CICDPoc;

Console.WriteLine("Hello, World!");
//Load sample data
var sampleData = new MLModel1.ModelInput()
{
    Col0 = 77F,
    Col1 = 31F,
    Col2 = 20F,
    Col3 = @"8",
    Col4 = @"Blocker",
    Col5 = 2F,
    Col6 = 0F,
    Col7 = 0F,
    Col8 = 1F,
    Col9 = @"Medium",
    Col10 = 1F,
    Col11 = 1F,
    Col12 = 2F,
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);
