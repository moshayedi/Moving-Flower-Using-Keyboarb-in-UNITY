using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBranchController : MonoBehaviour
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


        bool waving1 = Input.GetKey("1");



        // When Button 2 Is Pressed.
        if (waving1 == true)
        {
            // Setting isWaving1 Boolean To True.
            animator.SetBool("isWaving1", true);

        }
        // When Button 1 Isn't Pressed.
        if (waving1 == false)
        {
            // Setting isWaving1 Boolean To False.
            animator.SetBool("isWaving1", false);

        }


    }
}

