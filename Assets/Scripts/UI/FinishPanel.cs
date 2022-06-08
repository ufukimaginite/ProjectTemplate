using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPanel : UIPanel
{
    public GameObject FailPanel, CompletedPanel;

    public override void Initialize(UIManager uiManager)
    {
        base.Initialize(uiManager);

        GameManager.EventManager.OnFail += OpenThePanel;
        GameManager.EventManager.OnLevelDone += OpenTheSuccesPanel;
    }
    private void OnDestroy()
    {
        GameManager.EventManager.OnFail -= OpenThePanel;
        GameManager.EventManager.OnLevelDone -= OpenTheSuccesPanel;
    }
    
    private void OpenThePanel()
    {
        FailPanel.gameObject.SetActive(true);
    }
    private void OpenTheSuccesPanel()
    {
        CompletedPanel.gameObject.SetActive(true);
    }
}