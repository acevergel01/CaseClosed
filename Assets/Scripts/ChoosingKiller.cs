using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingKiller : MonoBehaviour
{
    public GameObject correct, incorrect,Menu;
    public void Correct()
    {
        gameObject.SetActive(false);
        correct.SetActive(true);
    }
    public void Incorrect()
    {
        gameObject.SetActive(false);
        incorrect.SetActive(true);
    }
    void OnTriggerEnter2D(Collider2D triggerObj)
    {
        if (triggerObj.CompareTag("Player"))
        {
            Menu.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D triggerObj)
    {
        if (triggerObj.CompareTag("Player"))
        {
            Menu.SetActive(false);
        }
    }
}
