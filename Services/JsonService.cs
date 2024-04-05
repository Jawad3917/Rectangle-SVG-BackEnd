
using Newtonsoft.Json;
using RectangleAPI.Models;

namespace RectangleAPI.Services
{
    public class JsonService
    {

        public static string GetFilePath()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string filePath = Path.Combine(currentDirectory, "RectangleDataSet.json");
            return filePath;   
        }

        public static Rectangle GetInitialDimensions()
        {
            string json = File.ReadAllText(GetFilePath());
            return JsonConvert.DeserializeObject<Rectangle>(json);
        }

        public static void UpdateDimensions(Rectangle rectangle)
        {
            string json = JsonConvert.SerializeObject(rectangle);
            File.WriteAllText(GetFilePath(), json);
        }
    }
}
