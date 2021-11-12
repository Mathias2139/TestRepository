using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [Range(0,180)]
    public float startTime = 60;
    private float time = 100;
    private float globalScore = 0;

    public GameObject[] minigames;

    private PlayerControls input;
    private bool[] held;

    private void Start()
    {
        input = new PlayerControls();
        held = new bool[9];
        time = startTime;
    }
    public void MinigameCompleted(float score)
    {
        //Add score and time
        globalScore += score;
        //Remove Previous Minigame
        RemoveMinigame();
        //Spawn Next Minigame
        SpawnNextMinigame();
    }
    private void SpawnNextMinigame()
    {
        //Spawn Prefab
        //Initialize Controls, link game to manager
        //Start Game
    }

    private void RemoveMinigame()
    {
        //Destroy
    }

    private void LateUpdate()
    {
        time -= Time.deltaTime;
    }

    public void One(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[0] = true;
        }
        if (context.canceled)
        {
            held[0] = false;
        }
    }
    public void Two(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[1] = true;
        }
        if (context.canceled)
        {
            held[1] = false;
        }
    }
    public void Three(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[2] = true;
        }
        if (context.canceled)
        {
            held[2] = false;
        }
    }
    public void Four(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[3] = true;
        }
        if (context.canceled)
        {
            held[3] = false;
        }
    }
    public void Five(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[4] = true;
        }
        if (context.canceled)
        {
            held[4] = false;
        }
    }
    public void Six(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[5] = true;
        }
        if (context.canceled)
        {
            held[5] = false;
        }
    }
    public void Seven(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[6] = true;
        }
        if (context.canceled)
        {
            held[6] = false;
        }
    }
    public void Eight(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[7] = true;
        }
        if (context.canceled)
        {
            held[7] = false;
        }
    }
    public void Nine(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            held[8] = true;
        }
        if (context.canceled)
        {
            held[8] = false;
        }
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }
}
