using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeDoorOpenScript : MonoBehaviour {

    public Animation anim;
    public bool isOpen;

    public void Activate()
    {
        if (!anim.isPlaying)
        {
            if (!isOpen)
            {
                anim.Play("DoorOpen");
                isOpen = true;
            }
            else
            {
                anim.Play("DoorClose");
                isOpen = false;
            }
        }
    }
}
