using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LookAtMouse : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;
    public GameObject player;
    public PauseMenu pauseMenu;
    public float horizontal;
    public float vertical;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseMenu.isPaused == false)
        {
            turn.x += horizontal * sensitivity;
            turn.y += vertical * sensitivity;
            turn.y = Mathf.Clamp(turn.y, -50, 50);
            player.transform.localRotation = Quaternion.Euler(0, turn.x, 0);
            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        }
        
    }

    public void LookInput(Vector2 newMoveDir)
    {
        horizontal = newMoveDir.x;
        vertical = newMoveDir.y;
    }

    public void OnLook(InputValue value)
    {
        LookInput(value.Get<Vector2>());
    }

}



