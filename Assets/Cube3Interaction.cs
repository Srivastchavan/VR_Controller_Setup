using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3Interaction : MonoBehaviour
{
    private bool isOriginalColor = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointerClick()
    {
        if(isOriginalColor)
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
