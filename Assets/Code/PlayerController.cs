using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    public float activateDistance = 5;

    Camera main;

    private void Start()
    {
        main = Camera.main;
    }


    private void Update()
    {
        RaycastHit hit;

        Ray fowardRay = new Ray(main.ViewportToWorldPoint(new Vector3(.5f, .5f, 0)), main.transform.forward);

        if (CrossPlatformInputManager.GetButtonDown("Activate"))
        {
            if (Physics.Raycast(fowardRay, out hit, activateDistance))
            {
                hit.transform.gameObject.SendMessage("Activate", SendMessageOptions.DontRequireReceiver);
                Debug.Log("hit " + hit.transform.gameObject.name);
            }
        }
    }
}
