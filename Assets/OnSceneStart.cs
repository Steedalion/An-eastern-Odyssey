using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnSceneStart : MonoBehaviour
{
    [SerializeField] private UnityEvent onStart;

    // Start is called before the first frame update
    void Start()
    {
        onStart?.Invoke();
    }


}
