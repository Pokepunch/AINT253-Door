using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoorOpenScript : MonoBehaviour {

    private Animator anim;
    private bool isClosed;

    private void Start()
    {
        anim = GetComponent<Animator>();
        isClosed = anim.GetBool("IsClosed");
    }

    public void Activate()
    {
        anim.SetBool("IsClosed", false);
        /*
        if (isClosed)
        {
            anim.SetBool("IsClosed", false);
            isClosed = false;
        }
        else
        {
            anim.SetBool("IsClosed", true);
            isClosed = true;
        }
        */
    }
}
