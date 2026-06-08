using UnityEngine;

public class StoneTrigger : MonoBehaviour
{
    public Animator stoneAnimator;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("무언가 들어옴");

        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어 진입!");

            stoneAnimator.Play("stoneFall", 0, 0f);
        }
    }
}