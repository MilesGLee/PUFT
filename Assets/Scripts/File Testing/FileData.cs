using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FileData
{
    public int Score;

    public FileData(FileManager file) 
    {
        Score = file.Score;
    }
}
