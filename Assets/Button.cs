using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator dvere_animator_controller;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Animator>().enabled = true;
            OpenDoor();
        }
    }
    void OpenDoor()
    {
        dvere_animator_controller.enabled = true;
    }
}
