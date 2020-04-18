using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameMouse : MonoBehaviour
{
    [SerializeField] private Texture2D curserArrow;
    
    void Awake()
    {
        Cursor.SetCursor(curserArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

}
