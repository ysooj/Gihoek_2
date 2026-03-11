using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator buildingAnimator;

    public void OnTriggerEnter(Collider other)
    {
        buildingAnimator.SetBool("IsOpen", true);
    }
    public void OnTriggerExit(Collider other)
    {
        buildingAnimator.SetBool("IsOpen", false);
    }
}
