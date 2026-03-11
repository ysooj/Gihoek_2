using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public GameObject target;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //1.응시

        //타겟의 위치를 바라본다
        transform.LookAt(target.transform.position);


        //2.추적

        //위치를 변환하다(현재 위치에서 Vector(0,0,1)만큼,)
        transform.Translate(new Vector3(0, 0, speed), Space.Self);
    }
}
