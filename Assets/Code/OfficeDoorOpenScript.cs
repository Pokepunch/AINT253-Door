using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoorOpenScript : MonoBehaviour {

    public Animator anim;
    private bool isClosed;

    private void Start()
    {
        isClosed = anim.GetBool("IsClosed");
    }

    public void Activate()
    {
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
