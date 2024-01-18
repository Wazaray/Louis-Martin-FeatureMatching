using System;
using System.IO;
using System.Text.Json;
using Louis.Martin.FeatureMatching;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: dotnet run <chemin_objet> <chemin_scenes>");
            return;
        }

        string cheminObjet = args[0];
        string cheminScenes = args[1];

        byte[] objectImageData = File.ReadAllBytes(cheminObjet);
        string[] sceneImagePaths = Directory.GetFiles(cheminScenes);

        var objectDetection = new ObjectDetection();
        foreach (var sceneImagePath in sceneImagePaths)
        {
            byte[] sceneImageData = File.ReadAllBytes(sceneImagePath);
            var detectObjectInScenesResults = objectDetection.DetectObjectInScene(objectImageData, sceneImageData);

            Console.WriteLine($"Points: {JsonSerializer.Serialize(detectObjectInScenesResults.Points)}");
        }
    }
}