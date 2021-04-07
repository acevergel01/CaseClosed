using UnityEngine;
public class PlayerData
{
    public static string scenename = "Office";
    public static DialogDisplay Dial;
    public static bool DialogueOngoing;
    public static SpeakerUI speakerUILeft;
    public static SpeakerUI speakerUIRight;

    public static float soundLevel = 1f;
    public static float musicLevel = 1f;
    public static Vector2 position = new Vector2(-18f,-12.3f);
    public static bool journal1 = false;
    public static bool journal2 = false;
    public static bool journal3 = false;
    public static bool journal4 = false;
    public static bool journal5 = false;
    public static int currentJournal;
    public static int currentCharacter =0;
    public static string[] Characters = { "Intel", "Mr. Ereh", "Aramin", "Mikasa", "Fortune", "Jean", "Grey", "Sasha", "Pandy", "Christa", "Wah" };
    public static string[] doors = { "Bar1" };
}