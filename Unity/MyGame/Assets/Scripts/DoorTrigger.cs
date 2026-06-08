using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator leftDoorAnimator;
    public Animator rightDoorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 沥规氢 犁积
            leftDoorAnimator.speed = 1;
            leftDoorAnimator.Play("Open", 0, 0f);

            rightDoorAnimator.speed = 1;
            rightDoorAnimator.Play("Open", 0, 0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 开规氢 犁积
            leftDoorAnimator.speed = -1;
            leftDoorAnimator.Play("Open", 0, 1f);

            rightDoorAnimator.speed = -1;
            rightDoorAnimator.Play("Open", 0, 1f);
        }
    }
}