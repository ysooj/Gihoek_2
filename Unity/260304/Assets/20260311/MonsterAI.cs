using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public GameObject target; // 플레이어 게임 오브젝트를 저장할 변수. 즉, 몬스터가 추적할 대상이 된다.
    public GameObject bullet; // 몬스터가 발사할 총알 게임 오브젝트를 저장할 변수. 즉, 몬스터가 공격할 때 사용할 총알 프리팹이 된다.

    public float speed; // Unity의 Inspector 창에서 몬스터의 이동 속도를 조절할 수 있도록 하는 변수.

    public float coolTime=2f; // 몬스터가 공격할 때마다 일정한 시간 간격을 두도록 하는 변수. 즉, 몬스터가 공격한 후 다음 공격까지 기다려야 하는 시간을 설정하는 변수.
    float lastAttackTime=0f; // 몬스터가 마지막으로 공격한 시간을 저장하는 변수.

    public float radius;

    // Update is called once per frame
    void Update()
    {
        // 1. 응시
        transform.LookAt(target.transform.position); // 몬스터가 타겟을 바라보도록 한다.
                                                     // 몬스터가 바라본다. target의 위치를.

        // 몬스터와 플레이어 사이의 거리 계산
        float distance = Vector3.Distance(transform.position, target.transform.position);
        // 몬스터와 타겟 사이의 거리를 계산한다. Vector3.Distance는 두 점 사이의 거리를 계산하는 함수이다. transform.position은 몬스터의 현재 위치를 나타내고, target.transform.position은 타겟의 현재 위치를 나타낸다. 이 함수를 사용하면 몬스터와 타겟 사이의 거리를 쉽게 계산할 수 있다.

        // 공격 범위 안에 들어와 있는 지 체크
        if (distance < radius)
        {
            // 2. 추적. 몬스터가 플레이어를 따라간다.
            // Vector3(0, 0, 1)과 같이 쓰는데, 숫자를 작게 할 수록 천천히 이동한다. 숫자를 크게 할 수록 빠르게 이동한다.
            transform.Translate(new Vector3(0, 0, speed), Space.Self); // 몬스터가 자신의 앞쪽 방향으로 이동한다. (즉, 타겟을 향해 이동한다.)
                                                                       // 몬스터의 위치를 변환한다. 현재 위치에서 (0, 0, 0.01)만큼 더한 방향으로 이동한다. self는 몬스터 자신의 좌표계를 기준으로 이동한다는 뜻이다. 즉, 몬스터가 바라보는 방향이 앞으로 간다.
                                                                       // World는 절대 좌표(Unity의 월드 공간 Global.절대 변하지 않는 좌표) Self 자기 자신의 좌표(Unity의 Local).
                                                                       // World로 하게 되면 바라보는 방향과 관계없이 나침반 방향처럼 이동한다. Self로 하게 되면 바라보는 방향이 앞으로 간다.

            // 3. 공격
            if (Time.time - lastAttackTime >= coolTime)
            {
                Debug.Log("공격!"); // 몬스터가 공격할 때마다 콘솔에 "공격!"이라는 메시지를 출력한다.
                Instantiate(bullet, transform.position, transform.rotation); // 총알 게임 오브젝트를 동적으로 생성한다. 즉, 몬스터가 공격할 때마다 총알이 생성된다. Instantiate는 Unity에서 게임 오브젝트를 복제해서 생성하는 함수이다. bullet은 몬스터가 발사할 총알 게임 오브젝트를 저장하는 변수이므로, 이 함수를 사용하면 몬스터가 공격할 때마다 총알이 생성된다.
                // 총알이 생성될 때의 위치는 몬스터의 현재 위치(transform.position)이고, 총알이 생성될 때의 회전은 몬스터의 현재 회전(transform.rotation)이다. 이렇게 하면 총알이 몬스터가 바라보는 방향으로 발사된다.

                lastAttackTime = Time.time; // 몬스터가 공격한 시간을 현재 시간으로 업데이트한다. 이렇게 하면 다음 공격까지의 간격을 계산할 수 있다.
                                            // 즉, 이 변수를 업데이트하지 않으면 몬스터가 매 프레임마다 공격하게 된다. 하지만 이 변수를 업데이트하면 몬스터가 공격한 후 일정한 시간 간격을 두고 다음 공격을 하게 된다.
            }
        }
    }

    // 4. 추적 범위를 가시화하는 코드. Gizmo를 생성해서 시각적으로 몬스터가 추적하는 범위를 보여준다. 이 코드는 게임 실행 중에는 보이지 않고, Unity 에디터에서만 보인다.
    // 게임 개발에 도움이 되는 역할. 실제 게임 배포 시에는 이 코드를 제거해도 된다.
    // 제거하지 않아도, 기즈모는 Game Scene에는 보이지 않기 때문에 게임 플레이에 영향을 주지 않는다.
    private void OnDrawGizmos()
    {
        // 기즈모의 컬러를 빨간색으로 한다.
        Gizmos.color = new Color(1, 0, 0, 0.2f);
        // Color.red = new Color(1, 0, 0, 1); // 빨간색의 RGBA 값. R=1, G=0, B=0, A=1(불투명). A값을 0.5로 하면 반투명 빨간색이 된다.

        // 기즈모의 형태를 구체로 한다. 구체의 중심은 몬스터의 위치이고, 반지름은 5로 한다.
        Gizmos.DrawSphere(transform.position, radius);
        // 여기서 transform.position은 몬스터의 현재 위치를 나타낸다. 이 스크립트를 몬스터에게 넣을 거기 때문.
    }
}
