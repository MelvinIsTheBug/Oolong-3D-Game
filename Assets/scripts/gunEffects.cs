using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunEffects : MonoBehaviour
{
    public Animator cameraAnimator;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cameraAnimator.SetBool("pistol anim", true);
        }
        
    }
}
