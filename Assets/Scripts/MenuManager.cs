using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    [Header("Menus")]
    public GameObject[] Menus = new GameObject[4];

    public GameObject CurrentMenu;
 
    private void Awake()
    {
        instance = this;
    }

    public void ChangeMenuByName(String menuName)
    {
        var index = MenuNameToIndex(menuName);

        if (index < 0)
            return;

        if (CurrentMenu != null)
        {
            CurrentMenu.SetActive(false);
        }
        CurrentMenu = Menus[index];
        
        if (CurrentMenu != null)
        {
            CurrentMenu.SetActive(true);
        }
    }

    private int MenuNameToIndex(String menuName)
    {
        switch (menuName.ToLower())
        {
            case "loading":
                return 0;
            case "login":
                return 1;
            case "signup":
                return 2;
            case "home":
                return 3;
        }
        return -1;
    }
}
