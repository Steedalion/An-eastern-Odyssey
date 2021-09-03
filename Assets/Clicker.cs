using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    
    private PlayerController pc;
    private Vector2 mydestination;
    private bool seeking;
    public float xoffset=0.5f,yoffset = 0.5f;
    [SerializeField] private float Threshold=0.15f;

    void Start()
    {
        pc = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
                    Vector3 worldPosition;
            worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Clicked: " + worldPosition);
            mydestination = new Vector2(Mathf.Round(worldPosition.x)+xoffset, Mathf.Round(worldPosition.y)+yoffset);
            seeking = true;
        }

        Seek();
    }

    private void Seek()
    {
        if (!seeking)
        {
            return;
        }
        var toDestination = mydestination - (Vector2) transform.position;
        if (toDestination.magnitude< Threshold)
        {
            pc.moveAxis = Vector2.zero;
            seeking = false;
            return;
        }
        pc.moveAxis = toDestination.normalized;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(transform.position, mydestination);
    }
}