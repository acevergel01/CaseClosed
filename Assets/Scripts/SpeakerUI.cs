using UnityEngine;
using UnityEngine.UI;
public class SpeakerUI : MonoBehaviour
{
    public Text fullName,dialog;
    public Image portrait;

    private NPC speaker;
    public NPC Speaker
    {
        get { return speaker; }
        set
        {
            speaker = value;
            fullName.text = speaker.fullName;
            portrait.sprite = speaker.Portrait;
        }
    }
    public string Dialog
    {
        set { dialog.text = value; }
    }
    public bool hasSpeaker()
    {
        return speaker != null;
    }
    public bool SpeakerIs(NPC character)
    {
        return speaker == character;
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
