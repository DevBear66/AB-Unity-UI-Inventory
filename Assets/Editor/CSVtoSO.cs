using UnityEngine;
using UnityEditor;
using System.IO;

public class CSVtoSO
{
    private static string objectCSVPath = "Assets/Editor/ObjectsData.csv";
    [MenuItem("Utilities/Generate Objects")]
    
    public static void GenerateEnemies()
    {
        string[] allLines = File.ReadAllLines(objectCSVPath);

        // Start the loop from the second line to skip the header of the CSV file
        for (int i = 1; i < allLines.Length; i++)
        {
            string s = allLines[i];
            string[] splitData = s.Split(',');

            if (splitData.Length < 10)
            {
                Debug.Log(s + " does not have 10 or more values");
                continue;
            }

            Items items = ScriptableObject.CreateInstance<Items>();
            items.itemID = int.Parse(splitData[0]);
            items.itemName = splitData[1];
            items.description = splitData[2];
            //items.prefab = splitData[3];
            //items.icon = splitData[4];
            //items.types = int.Parse(splitData[5]);
            //items.rarity = int.Parse(splitData[6]);
            items.maxStack = int.Parse(splitData[7]);
            items.weight = int.Parse(splitData[8]);
            items.basevalue = int.Parse(splitData[9]);

            AssetDatabase.CreateAsset(items, $"Assets/GEP/Classes/Items/{items.itemName}.asset");
        }

        AssetDatabase.SaveAssets();
    }
}
