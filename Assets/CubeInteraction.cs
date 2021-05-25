using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteraction : MonoBehaviour
{
    private bool active = false;
    private bool colorFlag = true;

    private float rotateSpeed = .3F, moveSpeed = .003F;     // Cube rotation and translation speed
    private Vector3 axis = new Vector3(1, 1, 0);            // Axis of cube rotation
    private bool isOriginalColor = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true && Input.GetButton(Global.key))
        {
            if (Global.action == 1)
            {
                gameObject.transform.position += new Vector3(moveSpeed, 0, 0);
            }
            else if (Global.action == 2)
            {
                gameObject.transform.Rotate(axis, rotateSpeed);
            }
            else if (Global.action == 3 && colorFlag)
            {
                changeColor();
                colorFlag = false;
            }
            else if (Global.action == 0)
            {
                Global.action = 0;
            }
        }
        else
        {
            colorFlag = true;
        }
    }

    private void changeColor()
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

    public void PointerEnter()
    {
        active = true;
        gameObject.GetComponent<Outline>().enabled = true;
    }

    public void PointerExit()
    {
        active = false;
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
