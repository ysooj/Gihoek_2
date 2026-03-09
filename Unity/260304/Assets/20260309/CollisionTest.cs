using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    //충돌체가 충돌영역에 닿았을 때 1번 발생하는 함수(주석)
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Enter!");
    }

    //충돌체가 충돌영역에 머물 떄 발생하는 함수(현재 게임의 타겟이 60프레임=>1초에 60번 발생함)
    public void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision Stay!");
    }

    //충돌체가 충돌영역에 벗어났을 때 1번 발생하는 함수
    public void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit!");
    }

    //충돌체가 충돌영역에 닿았을 때 1번 발생하는 함수
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter!");
    }

    //충돌체가 충돌영역에 머물 떄 발생하는 함수(현재 게임의 타겟이 60프레임=>1초에 60번 발생함)
    public void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay!");
    }

    //충돌체가 충돌영역에 벗어났을 때 1번 발생하는 함수
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit!");
    }
}
