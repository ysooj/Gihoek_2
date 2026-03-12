using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public GameObject target;
    public GameObject bullet;
    public Transform bulletCreatePosition;

    public float speed;
    public float radius;

    public float coolTime=2f;
    float lastAttackTime = 0f;

    // Update is called once per frame
    void Update()
    {
        //만약 타겟이 참조가 끊겨있으면
        if (target == null)
        {
            return;
        }
        //1.응시

        //타겟의 위치를 바라본다
        transform.LookAt(target.transform.position);

        //몬스터와 플레이어 사이의 거리 계산
        float distance = Vector3.Distance(transform.position, target.transform.position);

        //공격 범위안에 들어와 있는지 체크
        if(distance<radius)
        {
            //2.추적

            //위치를 변환하다(현재 위치에서 Vector(0,0,1)만큼,)
            transform.Translate(new Vector3(0, 0, speed), Space.Self);

            //3.공격

            if (Time.time - lastAttackTime >= coolTime)
            {
                Debug.Log("공격");
                //몬스터의 위치와 회전값을 바탕으로 불릿을 동적으로 생성한다
                Instantiate(bullet, bulletCreatePosition.position, transform.rotation);
                lastAttackTime = Time.time;
            }
        }
    }
    private void OnDrawGizmos()
    {
        //기즈모의 컬러를 빨간색으로 한다.
        Gizmos.color = new Color(1,0,0,0.2f);

        //구체형태의 기즈모를 그린다(몬스터 위치,반지름은 5)
        Gizmos.DrawSphere(transform.position, radius);
    }
}
