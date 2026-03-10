using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    public Animator playerAnimator;

    // Update is called once per frame
    void Update()
    {
        // 만약 w 키를 입력했다면 {} 안의 내용을 실행하도록 하는 조건문
        if (Input.GetKeyDown(KeyCode.W))
        {
            // playerAnimator에 접근해서 IsWalk라는 파라미터를 true로 변경한다.
            playerAnimator.SetBool("IsWalk", true);
        }

        // 만약 w 키에서 손을 뗐다면 {} 안의 내용을 실행하도록 하는 조건문
        if (Input.GetKeyUp(KeyCode.W))
        {
            // 플레이어의 애니메이터에 접근해서 IsWalk라는 파라미터를 false로 변경한다.
            playerAnimator.SetBool("IsWalk", false);
        }
    }
}
