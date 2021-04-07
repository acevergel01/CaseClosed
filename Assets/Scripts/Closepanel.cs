using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Closepanel : MonoBehaviour
{
    GameObject moveScript,Intel;
    public void Close()
    {
        if (gameObject.name == "CaseClosed")
        {
            SceneManager.LoadScene("Office");
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        gameObject.SetActive(false);
    }
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        movePlayer.PlayerVector = new Vector2(-18f,-12.3f);
        moveScript = GameObject.Find("MovePlayer");
        moveScript.GetComponent<movePlayer>().move_Player();
        Intel = GameObject.Find("Intel");
        Intel.SetActive(false);
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
