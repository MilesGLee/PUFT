using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class FileSaveSystem
{
    private static string path = Application.persistentDataPath + "/file.txt";

    public static void SavePlayer(FileManager file)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);

        FileData data = new FileData(file);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static FileData LoadPlayer()
    {
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            FileData data = formatter.Deserialize(stream) as FileData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
