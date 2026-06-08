using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotPotTrigger : MonoBehaviour
{
    public Animator hotPotAnimator;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("무언가 들어옴");
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어 진입!");

            hotPotAnimator.SetBool("isBoil", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어 나감!");
            hotPotAnimator.SetBool("isBoil", false);
        }
    }
}
