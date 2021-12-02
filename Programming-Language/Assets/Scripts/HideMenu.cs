using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Options;
    public GameObject PurchaseMenu;

    public void SwitchMenu1()
    {
       MainMenu.SetActive(false);
       Options.SetActive(true);
    }

    public void SwitchMenu2()
    {
        MainMenu.SetActive(true);
        Options.SetActive(false);
    }

    public void SwitchMTOS()
    {
        MainMenu.SetActive(false);
        PurchaseMenu.SetActive(true);
    }

    public void SwitchSTOM()
    {
        MainMenu.SetActive(true);
        PurchaseMenu.SetActive(false);
    }

}
