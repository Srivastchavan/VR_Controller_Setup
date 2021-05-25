using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Interaction : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(speed, 0, 0);
    }

    public void PointerDown()
    {
        speed = .003F;
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
