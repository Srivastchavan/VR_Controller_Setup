using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Interaction : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 axis = new Vector3(1, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axis, speed);
    }

    public void PointerDown()
    {
        speed = .3F;
    }

    public void PointerUp()
    {
        speed = 0;
    }

    public void PointerExit()
    {
        speed = 0;
    }
}
