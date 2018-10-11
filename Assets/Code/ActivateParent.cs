using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateParent : MonoBehaviour
{
    // Send the activate message to this transform's parents.
    public void Activate()
    {
        transform.parent.SendMessage("Activate", SendMessageOptions.DontRequireReceiver);
    }
}
