using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;


public class EventUser : MonoBehaviour
{

    public UnityEvent OnGameStarted;

    private void Update()
    {
        if(Input.anyKeyDown) OnGameStarted?.Invoke();
        if(Input.touchCount > 0) OnGameStarted?.Invoke();


    }
}
