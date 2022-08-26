using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject menu;
    private void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
            //Open InscreenMenu
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (menu.activeInHierarchy)
                {
                    menu.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                }
                else
                {
                     menu.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                }   
            }
    }
}
