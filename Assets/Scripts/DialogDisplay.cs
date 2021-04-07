using UnityEngine;
public class DialogDisplay : MonoBehaviour
{
    public Conversation conversation;
    public GameObject speakerLeft;
    public GameObject speakerRight;

    private SpeakerUI speakerUILeft;
    private SpeakerUI speakerUIRight;
    public GameObject button,NPC,nextNPC,nextDoor,nextGame;
    private int activeLineIndex = 0;
    void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<SpeakerUI>();
        speakerUIRight= speakerRight.GetComponent<SpeakerUI>();
        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUIRight.Speaker = conversation.speakerRight;
    }
    public void AdvanceDialog()
    {
        if (activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex += 1;
        }
        else
        {
            speakerUILeft.Hide();
            speakerUIRight.Hide();
            activeLineIndex = 0;
            button.SetActive(true);
            NPC.transform.tag = "Untalkable";
            if (NPC.name == "Intel")
            {
                PlayerData.journal1 = true;
            }
            if (NPC.name == "Fortune")
            {
                PlayerData.journal2 = true;
            }
            if (NPC.name == "Grey")
            {
                PlayerData.journal3 = true;
            }
            if (NPC.name == "Sister")
            {
                PlayerData.journal4 = true;
            }
            if (NPC.name == "Wah")
            {
                PlayerData.journal5 = true;
            }

            if (nextNPC != null)
            {
                nextNPC.transform.tag = "Talkable";
            }
            if (nextDoor != null)
            {
                nextDoor.transform.tag = "Door";
            }
            if (nextGame !=null)
            {
                nextGame.transform.tag = "MiniGame";
            }
            PlayerData.currentCharacter += 1;
        }
    }
    public void DisplayLine()
    {
        Line line = conversation.lines[activeLineIndex];
        NPC character = line.character;
        if (speakerUILeft.SpeakerIs(character))
        {
            SetDialog(speakerUILeft, speakerUIRight, line.text);
        }
        else
        {
            SetDialog(speakerUIRight, speakerUILeft, line.text );
        }
    }
    public void SetDialog(SpeakerUI activeSpeakerUI,SpeakerUI inactiveSpeakerUI, string text)
    {
        activeSpeakerUI.Dialog = text;
        activeSpeakerUI.Show();
        inactiveSpeakerUI.Hide();
    }
}
