using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : CustomBehaviour
{
    public InputManager InputManager;
    public EventManager EventManager;
    public LevelManager LevelManager;
    public UIManager UIManager;
    
    private void Awake()
    {
        InputManager.Initialize(this);
        EventManager.Initialize(this);
        LevelManager.Initialize(this);
        UIManager.Initialize(this);
    }

    private void Start()
    {
        EventManager.GameStarted();
    }
}