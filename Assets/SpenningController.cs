using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpenningController : MonoBehaviour
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


        bool spenning = Input.GetKey("3");



        // When Button 2 Is Pressed.
        if (spenning == true)
        {
            // Setting isWaving1 Boolean To True.
            animator.SetBool("isSpenning", true);

        }
        // When Button 1 Isn't Pressed.
        if (spenning == false)
        {
            // Setting isWaving1 Boolean To False.
            animator.SetBool("isSpenning", false);

        }


    }
}

