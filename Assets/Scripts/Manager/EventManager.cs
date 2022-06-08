using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : CustomBehaviour
{
    public Action OnGameStart;
    public Action OnFail;
    public Action OnLevelDone;
    public Action<float> OnDamage;

    public void GameStarted()
    {
        OnGameStart?.Invoke();
    }

    public void ItsFail()
    {
        OnFail?.Invoke();
    }

    public void ItsLevelDone()
    {
        OnLevelDone?.Invoke();
    }

    public void TakeDamage(float damageAmount)
    {
        OnDamage?.Invoke(damageAmount);
    }


}