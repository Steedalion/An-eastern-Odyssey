﻿using UnityEngine;

public class SetCursorAtStart : MonoBehaviour
{
    [SerializeField] private Texture2D cursor;

    void Start()
    {
        Cursor.SetCursor(cursor,Vector2.zero, CursorMode.Auto);
        
    }

}
