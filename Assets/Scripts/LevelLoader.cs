using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public Rigidbody2D detective;
    public GameObject moveScript;
    public Animator transition;

    private void OnTriggerEnter2D(Collider2D triggerObj)
    {
        StartCoroutine("sceneTransition");
        if (triggerObj.gameObject.CompareTag("Door"))
        {
            DontDestroy.playerPosition = detective.position;
            movePlayer.fromLocation = SceneManager.GetActiveScene().name;
            if (triggerObj.gameObject.name != "Story 1")
            {
                SceneManager.LoadScene(triggerObj.gameObject.name);
            }
            else
            {
                SceneManager.LoadScene("Story 1");
                SceneManager.sceneLoaded += OnSceneLoaded;
            }
        }
    }
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Story 1")

        {
            if (movePlayer.fromLocation == "Store1")
            {
                movePlayer.PlayerVector = new Vector2(-12.5f, 28.78f);
            }
            else if (movePlayer.fromLocation == "Store2")
            {
                movePlayer.PlayerVector = new Vector2(-12.6f, 27.2f);
            }
            else if (movePlayer.fromLocation == "Store3")
            {
                movePlayer.PlayerVector = new Vector2(-12.75f, 25.5f);
            }
            else if (movePlayer.fromLocation == "Bar1")
            {
                movePlayer.PlayerVector = new Vector2(-21.877f, 23.548f);
            }
            else if (movePlayer.fromLocation == "House1")
            {
                movePlayer.PlayerVector = new Vector2(-23.335f, 26.179f);
            }
            else if (movePlayer.fromLocation == "House2")
            {
                movePlayer.PlayerVector = new Vector2(-21.727f, 26.179f);
            }
            else if (movePlayer.fromLocation == "House3")
            {
                movePlayer.PlayerVector = new Vector2(-21.883f, 21.663f);
            }
            else if (movePlayer.fromLocation == "Office")
            {
                movePlayer.PlayerVector = new Vector2(-24.5f, 29.5f);
            }
            else if (movePlayer.fromLocation == "Menu")
            {
                movePlayer.PlayerVector = PlayerData.position;
            }
        }
        GameObject currChar = GameObject.Find(PlayerData.Characters[PlayerData.currentCharacter]);
        if (currChar != null){
            currChar.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        
        moveScript = GameObject.Find("MovePlayer");
        moveScript.GetComponent<movePlayer>().move_Player();
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    IEnumerable sceneTransition()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
    }
}
