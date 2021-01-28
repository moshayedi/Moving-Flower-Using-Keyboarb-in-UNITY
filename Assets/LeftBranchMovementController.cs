using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBranchMovementController : MonoBehaviour
{
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Increasing Preformance 

    }

    // Update is called once per frame
    void Update()
    {



        bool waving = Input.GetKey("2");



        // When Button 1 Is Pressed.
        if (waving == true)
        {
            // Setting isWaving1 Boolean To True.
            animator.SetBool("isWaving", true);

        }
        // When Button 1 Isn't Pressed.
        if (waving == false)
        {
            // Setting isWaving1 Boolean To False.
            animator.SetBool("isWaving", false);

        }


    }
}

