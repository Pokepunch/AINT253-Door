using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoorOpenScript : MonoBehaviour {

    public Animator anim;
    private bool isClosed;

    public bool isLocked;

    private void Start()
    {
        isClosed = anim.GetBool("IsClosed");
        if (isLocked)
        {
            anim.SetBool("IsLocked", true);
        }
    }

    public void Activate()
    {
        if (isLocked)
        {
            anim.Play("Locked");
        }
        if (isClosed)
        {
            anim.SetBool("IsClosed", false);
        }
        else
        {
            anim.SetBool("IsClosed", true);
        }
    }

    public void SetDoorOpen()
    {
        isClosed = false;
    }

    public void SetDoorClosed()
    {
        isClosed = true;
    }
}
