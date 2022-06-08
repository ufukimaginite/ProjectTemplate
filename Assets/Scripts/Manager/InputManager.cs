using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : CustomBehaviour
{
    public override void Initialize(GameManager gameManager)
    {
        base.Initialize(gameManager);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Example for InputManager usage

            //_currentHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            //if (_currentHit.transform != null)
            //{
            //    if (_currentHit.transform.GetComponent<IClickableDown>() != null)
            //    {
            //        _currentHit.transform.GetComponent<IClickableDown>().FingerDown();
            //    }
            //}
        }
        else if (Input.GetMouseButton(0))
        {
            //Example for InputManager usage

            //if (_currentHit.transform != null)
            //{
            //    if (_currentHit.transform.GetComponent<LevelCell>() != null)
            //    {
            //        _currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //        _deltaPos = _currentPos - _lastPos;

            //        GameManager.EventManager.FingerUpdate(_deltaPos);
            //        _lastPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //    }
            //}
        }
        else if (Input.GetMouseButtonUp(0))
        {

        }

    }
}