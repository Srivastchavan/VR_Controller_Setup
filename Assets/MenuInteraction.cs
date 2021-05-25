using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInteraction : MonoBehaviour
{
    private bool active = false;
    
    public Button b;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true && Input.GetButton(Global.key))
        {
            b.onClick.Invoke();
        }
    }

    public void buttonMove()
    {
        Global.action = 1;

        Global.isShowing = false;
        menu.SetActive(Global.isShowing);
    }
    public void buttonRotate()
    {
        Global.action = 2;

        Global.isShowing = false;
        menu.SetActive(Global.isShowing);
    }
    public void buttonColor()
    {
        Global.action = 3;

        Global.isShowing = false;
        menu.SetActive(Global.isShowing);
    }
    public void buttonClear()
    {
        Global.action = 0;

        Global.isShowing = false;
        menu.SetActive(Global.isShowing);
    }
    public void buttonExit()
    {
        Global.isShowing = false;
        menu.SetActive(Global.isShowing);
    }

    public void PointerEnter()
    {
        active = true;
    }

    public void PointerExit()
    {
        active = false;
    }
}
