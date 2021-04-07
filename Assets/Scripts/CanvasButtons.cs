using UnityEngine;
using UnityEngine.UI;
using CodeMonkey;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public Image talk;
    public GameObject settingsButton, journalButton, buttons,bar,Store1,House2,Store2,House3;
    public GameObject Journal1, Journal2, Journal3, Journal4, Journal5;
    public Animator settingsAnimator, journalAnimator,Minigame1,Minigame2,Minigame3,Minigame4,Minigame5;
    public Rigidbody2D detective;
    public Datamanager data;
    public InputField input1,input2,input3,input4,input5;
    public void Awake()
    {
        
        if (detective == null){
            detective = GameObject.Find("Detective Variant").GetComponent<Rigidbody2D>();
        }
        if (detective == null)
        {
            detective = GameObject.Find("Detective").GetComponent<Rigidbody2D>();
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void continueDialog()
    {
        PlayerData.Dial.AdvanceDialog();
    }
    public void talkClick()
    {
        talk.enabled = false;
        buttons.SetActive(false);
        continueDialog();
    }
    public void settings()
    {
        settingsAnimator.SetBool("panel_IsOpen", !settingsAnimator.GetBool("panel_IsOpen"));
        Detective.isMoveEnabled = !Detective.isMoveEnabled;
        buttons.SetActive(!buttons.activeSelf);
        journalButton.SetActive(!journalButton.activeSelf);
    }
    public void openJournal()
    {
        if (PlayerData.journal1)
        {
            Journal1.SetActive(true);
            Detective.isMoveEnabled = false;
            buttons.SetActive(false);
            settingsButton.SetActive(false);
            journalButton.SetActive(false);
            PlayerData.currentJournal = 1;
        }
    }
    public void CloseJournal()
    {
        Detective.isMoveEnabled = true;
        buttons.SetActive(true);
        settingsButton.SetActive(true);
        journalButton.SetActive(true);
        Journal1.SetActive(false);
        Journal2.SetActive(false);
        Journal3.SetActive(false);
        Journal4.SetActive(false);
        Journal5.SetActive(false);
    }
    public void Save()
    {
        PlayerData.scenename = SceneManager.GetActiveScene().name;
        PlayerData.position = detective.position;
        CMDebug.TextPopupMouse("Saved!");
        data.Save();
    }
    public void journalNext()
    {
        if (PlayerData.journal2 & PlayerData.currentJournal == 1)
        {
            Journal1.SetActive(false);
            Journal2.SetActive(true);
            PlayerData.currentJournal += 1;
        }
        else if (PlayerData.journal3 & PlayerData.currentJournal == 2)
        {
            Journal2.SetActive(false);
            Journal3.SetActive(true);
            PlayerData.currentJournal += 1;
        }
        else if (PlayerData.journal4 & PlayerData.currentJournal == 3)
        {
            Journal3.SetActive(false);
            Journal4.SetActive(true);
            PlayerData.currentJournal += 1;
        }
        else if (PlayerData.journal5 & PlayerData.currentJournal == 4)
        {
            Journal4.SetActive(false);
            Journal5.SetActive(true);
        }
    }
    public void journalPrev()
    {
        if (PlayerData.journal5 & PlayerData.currentJournal == 4)
        {
            Journal4.SetActive(true);
            Journal5.SetActive(false);
            PlayerData.currentJournal -= 1;
        }
        else if (PlayerData.journal4 & PlayerData.currentJournal == 3)
        {
            Journal4.SetActive(false);
            Journal3.SetActive(true);
            PlayerData.currentJournal -= 1;
        }
        else if (PlayerData.journal3 & PlayerData.currentJournal == 2)
        {
            Journal3.SetActive(false);
            Journal2.SetActive(true);
            PlayerData.currentJournal -= 1;
        }
        else if (PlayerData.journal2 & PlayerData.currentJournal == 1)
        {
            Journal2.SetActive(false);
            Journal1.SetActive(true);
        }
    }
    public void MiniGame1()
    {

        if ((input1.text == "bar") || (input1.text == "BAR")){
            GameObject.Find("MiniGame1").SetActive(false);
            bar.GetComponent<BoxCollider2D>().isTrigger = true;
            Minigame1.SetBool("isOpen", false);
        }
        input1.text = "";
    }
    public void MiniGame2()
    {

        if ((input2.text == "antique") || (input2.text == "Antique"))
        {
            GameObject.Find("MiniGame2").SetActive(false);
            Store1.GetComponent<BoxCollider2D>().isTrigger = true;
            Minigame2.SetBool("isOpen", false);
        }
        input2.text = "";
    }
    public void MiniGame3()
    {
        if ((input3.text == "lover") || (input3.text == "Lover"))
        {
            GameObject.Find("MiniGame3").SetActive(false);
            House2.GetComponent<BoxCollider2D>().isTrigger = true;
            Minigame3.SetBool("isOpen", false);
        }
        input3.text = "";
    }
    public void MiniGame4()
    {

        if ((input4.text == "money") || (input4.text == "Money"))
        {
            GameObject.Find("MiniGame4").SetActive(false);
            Store2.GetComponent<BoxCollider2D>().isTrigger = true;
            Minigame4.SetBool("isOpen", false);
        }
        input4.text = "";
    }
    public void MiniGame5()
    {

        if ((input5.text == "ace") || (input5.text == "Ace"))
        {
            GameObject.Find("MiniGame5").SetActive(false);
            House3.GetComponent<BoxCollider2D>().isTrigger = true;
            Minigame5.SetBool("isOpen", false);
        }
        input5.text = "";
    }
}
