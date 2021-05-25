using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Determine what directions are being held
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 velocity = direction * speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y = 0;

        characterController.Move(velocity);
    }
}
