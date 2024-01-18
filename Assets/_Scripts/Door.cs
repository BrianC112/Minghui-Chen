using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    private bool isOpen = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    public void OpenDoor()
    {
        if (isOpen)
        {
            return;
        }
        isOpen = true;
        anim = GetComponent<Animator>();
        anim.SetBool("isOpen", true);
    }

    public void CloseDoor()
    {
        if (!isOpen)
        {
            return;
        }
        isOpen = false;
        anim = GetComponent<Animator>();
        anim.SetBool("isOpen", false);
    }
}
