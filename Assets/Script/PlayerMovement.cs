using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player Movement
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    // Declare a variable 
    private Rigidbody rb;
    private Animator animator;

    bool IsWalking = false;

    [SerializeField] float movementSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        // Get a rigidbody from the component
        rb = gameObject.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        // Set animation for movement
        animator.SetBool("IsWalking", true);
        IsWalking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsWalking)
        {
            // Move a player when player start playing
            Vector3 movement = Vector3.forward * movementSpeed * Time.deltaTime;

            // Apply the movement to rigidbody 
            transform.Translate(movement);
        }
    }
}
