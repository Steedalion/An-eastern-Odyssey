using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ModifyCursor : MonoBehaviour
{
    [FormerlySerializedAs("idle")] [SerializeField] private Texture2D enter;
    [SerializeField] private Texture2D exit;


    private void SetCursor(Texture2D setTo)
    {
        Cursor.SetCursor(setTo, Vector2.zero, CursorMode.Auto);
    }
    

    private void OnMouseEnter()
    {
        SetCursor(enter);
    }

    private void OnMouseExit()
    {
        SetCursor(exit);
    }
}
