using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", true);
        }

        if(!Input.GetKey("w"))
        {
            animator.SetBool("IsWalking", false);
        }
    }
}
