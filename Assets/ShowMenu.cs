using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ShowMenu : MonoBehaviour
{
    public GameObject menu;
    private bool isShowing = false;

    public Button Move;
    public Button Rotate;
    public Button ChangeColor;
    public Button ClearAction;
    public Button Exit;

    private float speed;                                            // Cube rotation and translation speed
    [SerializeField] private Vector3 axis = new Vector3(1, 1, 0);   // Axis of cube rotation
    private bool isOriginalColor = true;

    // Which action is currently selected
    private bool move = false;
    private bool rotate = false;
    private bool changeColor = false;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(isShowing);
        gameObject.GetComponent<Outline>().enabled = false;

        Move.onClick.AddListener(() => moveCallBack());
        Rotate.onClick.AddListener(() => rotateCallBack());
        ChangeColor.onClick.AddListener(() => changeColorCallBack());
        ClearAction.onClick.AddListener(() => clearActionCallBack());
        Exit.onClick.AddListener(() => exitCallBack());
    }


    // Call back functions for responding to button presses
    private void moveCallBack()
    {
        move = true;
        rotate = false;
        changeColor = false;
        
        isShowing = false;
        menu.SetActive(isShowing);
    }
    private void rotateCallBack()
    {
        move = false;
        rotate = true;
        changeColor = false;
        
        isShowing = false;
        menu.SetActive(isShowing);
    }
    private void changeColorCallBack()
    {
        move = false;
        rotate = false;
        changeColor = true;
        
        isShowing = false;
        menu.SetActive(isShowing);
    }
    private void clearActionCallBack()
    {
        move = false;
        rotate = false;
        changeColor = false;

        isShowing = false;
        menu.SetActive(isShowing);
    }
    private void exitCallBack()
    {
        isShowing = false;
        menu.SetActive(isShowing);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           isShowing = !isShowing;
           menu.SetActive(isShowing);
        }
        if (move)
        {
            gameObject.transform.position += new Vector3(speed, 0, 0);
        }
        if (rotate)
        {
            gameObject.transform.Rotate(axis, speed);
        }
    }

    public void PointerEnter()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void PointerExit()
    {
        gameObject.GetComponent<Outline>().enabled = false;
        if (move == true || rotate == true)
        {
            speed = 0;
        }
    }

    // Sets the correct speed based on menu selection
    public void PointerDown()
    {
        if (move)
        {
            speed = .003F;
        }
        if (rotate)
        {
            speed = .3F;
        }
    }

    public void PointerUp()
    {
        if (move == true || rotate == true)
        {
            speed = 0;
        }
    }

    public void PointerClick()
    {
        if (changeColor == true)
        {
            if (isOriginalColor)
            {
                gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
                isOriginalColor = false;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                isOriginalColor = true;
            }
        }
    }
}
