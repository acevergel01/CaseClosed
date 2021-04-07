using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detective : MonoBehaviour
{
    public static bool isMoveEnabled= true;
    InputManager inputManager;
    public Animator animator;
    Rigidbody2D detective;

    [SerializeField] float playerSpeed = 5f;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        detective = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isMoveEnabled)
        {
            detective.MovePosition(detective.position + inputManager.CurrentInput * Time.fixedDeltaTime * playerSpeed);
            animator.SetFloat("Horizontal", inputManager.CurrentInput.x);
            animator.SetFloat("Vertical", inputManager.CurrentInput.y);
            animator.SetFloat("Speed", inputManager.CurrentInput.sqrMagnitude);
        }
    }
}
