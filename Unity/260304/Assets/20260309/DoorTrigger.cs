using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    //  [이 코드는 애니메이션을 배우기 전 코드]

    //  public GameObject right_door;
    //  public GameObject left_door;

    //  public void OnTriggerEnter(Collider other)
    //  {
    //      //왼쪽 문 게임 오브젝트를 비활성화 한다.
    //      left_door.gameObject.SetActive(false);
    //      //오른쪽 문 게임 오브젝트를 비활성화 한다.
    //      right_door.gameObject.SetActive(false);
    //  }
    //  public void OnTriggerExit(Collider other)
    //  {
    //      //왼쪽 문 게임 오브젝트를 활성화한다.
    //      left_door.gameObject.SetActive(true);
    //      //오른쪽 문 게임 오브젝트를 활성화한다.
    //      right_door.gameObject.SetActive(true);
    //  }

    // 애니메이터를 배운 후 코드

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
