using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public struct Line
{
    public NPC character;
    [TextArea(2, 5)]
    public string text;
}
[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")]
public class Conversation : ScriptableObject
{
    public NPC speakerLeft;
    public NPC speakerRight;
    public Line[] lines;
}
