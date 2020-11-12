using System;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using MyMLAppML.Model;
using OfficeOpenXml;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Veuillez saisir le texte à analyser");
                var text = Console.ReadLine();

                // Add input data
                var input = new ModelInput()
                {
                    Content = text
                };

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);

                Console.WriteLine($"Text: {input.Content}\nPrediction: {result.Prediction}\nNegative Score: {String.Format("{0:0.00}%", result.Score[0])} \nNeutral Score: {String.Format("{0:0.00}%", result.Score[1])} \nPositive Score: {String.Format("{0:0.00}%", result.Score[2])}");

                Console.WriteLine("=====================================================================================================");
            }
        }

    }
}
