using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class StateSwitcher : MonoBehaviour
{
    public UnityEvent enter1, exit1, enter2, exit2;

    public bool switched = false;

    public void SwitchState()
    {
        if (!switched)
        {
            enter2?.Invoke();
            exit1?.Invoke();
            switched =!switched;
            return;
        }

        enter1?.Invoke();
        exit2?.Invoke();
        switched = !switched;
    }
}