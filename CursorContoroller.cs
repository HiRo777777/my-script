using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorContoroller : MonoBehaviour
{
    [SerializeField] bool m_cursor;
    void Start()
    {
        Cursor.visible = m_cursor;

        if(m_cursor)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
