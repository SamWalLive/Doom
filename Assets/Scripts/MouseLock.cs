﻿using UnityEngine;
using System.Collections;

public class MouseLock : MonoBehaviour {

	void Awake ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}

    void Update()
    {
        if (Input.GetButtonDown("Menu"))
        {
            Change();
        }
    }

    void Change()
    {
        if (Input.GetButtonDown("Menu"))
        {
            Cursor.visible = !Cursor.visible;
            if (Cursor.visible)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
