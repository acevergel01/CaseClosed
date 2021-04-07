using UnityEngine;
using System.IO;

public class Datamanager : MonoBehaviour
{
    private static string SAVE_FOLDER;
    private void Awake()
    {
        SAVE_FOLDER = Application.dataPath + "/saves/";
        if (!Directory.Exists(SAVE_FOLDER))
        {
            Directory.CreateDirectory(SAVE_FOLDER);
        }
    }
    public void Save()
    {
        SaveObject player = new SaveObject
        {
            scenename = PlayerData.scenename,
            playerPosition = PlayerData.position,
            currentLevel = PlayerData.currentCharacter,
            soundLevel = PlayerData.soundLevel,
            musicLevel = PlayerData.musicLevel,
            journal1 = PlayerData.journal1 ,
            journal2 = PlayerData.journal2 ,
            journal3 = PlayerData.journal3 ,
            journal4 = PlayerData.journal4 ,
            journal5 = PlayerData.journal5 ,
    };
        string json = JsonUtility.ToJson(player);
        File.WriteAllText(SAVE_FOLDER + "save.txt", json);
    }
    public void Load()
    {
        if (File.Exists(SAVE_FOLDER + "save.txt"))
        {
            string saveString = File.ReadAllText(SAVE_FOLDER + "save.txt");
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            PlayerData.scenename = saveObject.scenename;
            PlayerData.position = saveObject.playerPosition;
            PlayerData.currentCharacter = saveObject.currentLevel;
            PlayerData.soundLevel = saveObject.soundLevel;
            PlayerData.musicLevel = saveObject.musicLevel;
            PlayerData.journal1 = saveObject.journal1;
            PlayerData.journal2 = saveObject.journal2;
            PlayerData.journal3 = saveObject.journal3;
            PlayerData.journal4 = saveObject.journal4;
            PlayerData.journal5 = saveObject.journal5;
        }
    }
}
public class SaveObject
{
    public string scenename;
    public Vector2 playerPosition;
    public int currentLevel;
    public float soundLevel;
    public float musicLevel;
    public bool journal1;
    public bool journal2;
    public bool journal3;
    public bool journal4;
    public bool journal5;
}


