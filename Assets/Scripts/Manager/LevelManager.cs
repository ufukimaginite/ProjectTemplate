using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : CustomBehaviour
{
    public override void Initialize(GameManager gameManager)
    {
        base.Initialize(gameManager);

        GameManager.EventManager.OnGameStart += GameStarted;

    }
    private void OnDestroy()
    {
        GameManager.EventManager.OnGameStart -= GameStarted;

    }

    private void GameStarted()
    {
        Debug.Log("OnGameStart from LevelManager");

        //place for set level
    }
}