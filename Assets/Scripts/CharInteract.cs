using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class CharInteract : MonoBehaviour
{
    DialogDisplay Dial;
    public Image talk;
    public GameObject buttons,Antique,Husband,Sister,Best;
    public Animator MiniGame1,MiniGame2,MiniGame3,MiniGame4,MiniGame5;


    void Start()
    {
        talk.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D triggerObj)
    {
        if (triggerObj.gameObject.CompareTag("Talkable"))
        {
            talk.enabled = true;
            buttons.SetActive(true);
            Dial = triggerObj.gameObject.GetComponent<DialogDisplay>();
            PlayerData.Dial = Dial;
            PlayerData.speakerUILeft = Dial.speakerLeft.GetComponent<SpeakerUI>();
            PlayerData.speakerUIRight = Dial.speakerRight.GetComponent<SpeakerUI>();
            PlayerData.speakerUILeft.Speaker = Dial.conversation.speakerLeft;
            PlayerData.speakerUIRight.Speaker = Dial.conversation.speakerRight;
        }
        if (triggerObj.gameObject.CompareTag("MiniGame"))
        {
            if (triggerObj.gameObject.name == "Minigame1")
            {
                MiniGame1.SetBool("isOpen", true);
            }
            else if (triggerObj.gameObject.name == "Minigame2")
            {
                MiniGame2.SetBool("isOpen", true);
            }
            else if (triggerObj.gameObject.name == "Minigame3")
            {
                MiniGame3.SetBool("isOpen", true);
            }
            else if (triggerObj.gameObject.name == "Minigame4")
            {
                MiniGame4.SetBool("isOpen", true);
            }
            else if (triggerObj.gameObject.name == "Minigame5")
            {
                MiniGame5.SetBool("isOpen", true);
            }
        }
        if (triggerObj.gameObject.CompareTag("Suspect"))
        {
            if (triggerObj.gameObject.name == "Antique")
            {
                Antique.SetActive(true);
            }
            else if (triggerObj.gameObject.name == "Husband")
            {
                Husband.SetActive(true);
            }
            else if (triggerObj.gameObject.name == "Sissy")
            {
                Sister.SetActive(true);
            }
            else if (triggerObj.gameObject.name == "Besty")
            {
                Best.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D triggerObj)
    {
        if (triggerObj.gameObject.CompareTag("Talkable"))
        {
            talk.enabled = false;
        }
        else if (triggerObj.gameObject.CompareTag("Untalkable"))
        {
            talk.enabled = false;
        }
        else if (triggerObj.gameObject.CompareTag("MiniGame"))
        {
            MiniGame1.SetBool("isOpen", false);
            MiniGame2.SetBool("isOpen", false);
            MiniGame3.SetBool("isOpen", false);
            MiniGame4.SetBool("isOpen", false);
            MiniGame5.SetBool("isOpen", false);
        }
        else if (triggerObj.gameObject.CompareTag("Suspect"))
        {
            Antique.SetActive(!true);
            Husband.SetActive(!true);
            Sister.SetActive(!true);
            Best.SetActive(!true);
        }
    }

}
