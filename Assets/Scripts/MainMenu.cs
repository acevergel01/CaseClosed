using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public AudioSource click;
    public Animator aboutPanel;
    public GameObject buttons,moveScript;
    public Datamanager data;
    public Animator settingsPanel;
    public void PlayButton()
    {
        data.Load();
        movePlayer.fromLocation = "Menu";
        SceneManager.LoadScene(PlayerData.scenename);
        movePlayer.PlayerVector = PlayerData.position;
        SceneManager.sceneLoaded += OnSceneLoaded;
        click.Play();
        Detective.isMoveEnabled = true;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        moveScript = GameObject.Find("MovePlayer");
        moveScript.GetComponent<movePlayer>().move_Player();
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    public void AboutButton()
    {
        click.Play();
        buttons.SetActive(false);
        bool isOpen = aboutPanel.GetBool("panel_IsOpen");
        aboutPanel.SetBool("panel_IsOpen", !isOpen);
    }
    public void ExitButton()
    {
        click.Play();
        Application.Quit();
    }
    public void CancelButton()
    {
        buttons.SetActive(true);
        click.Play();
        bool SettingsIsOpen = settingsPanel.GetBool("panel_IsOpen");
        bool AboutIsOpen = aboutPanel.GetBool("panel_IsOpen");
        if (SettingsIsOpen)
        {
            settingsPanel.SetBool("panel_IsOpen", !SettingsIsOpen);
        }
        else if (AboutIsOpen)
        {
            aboutPanel.SetBool("panel_IsOpen", !AboutIsOpen);
        }
    }
    public void settings()
    {
        click.Play();
        buttons.SetActive(false);
        settingsPanel.SetBool("panel_IsOpen", !settingsPanel.GetBool("panel_IsOpen"));
    }
}
