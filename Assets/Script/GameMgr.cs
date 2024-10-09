using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    private bool m_bGamePaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Escape) )
            m_bGamePaused = true;
        else
            m_bGamePaused = false;

        if (m_bGamePaused)
            Cursor.lockState = CursorLockMode.Locked;
        else
            Cursor.lockState &= ~CursorLockMode.None;
    }
}
