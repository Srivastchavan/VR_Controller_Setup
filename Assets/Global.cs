using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public GameObject menu;

    public static int action = 0;
    public static string key = "Submit";
    public static bool isShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(isShowing);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log(action);

        if (Input.GetButtonDown("Fire1"))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }
    }
}
