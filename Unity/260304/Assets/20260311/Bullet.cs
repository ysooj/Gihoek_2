using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed; // 총알의 이동 속도를 조절할 수 있도록 하는 변수.

    // 게임이 시작되면 한 번 실행되는 함수. 총알이 생성될 때 한 번 실행된다.
    private void Start()
    {
        Destroy(gameObject, 3f);
        // gameObject는 총알 게임 오브젝트 자체를 나타내는 변수이다. Destroy 함수는 게임 오브젝트를 제거하는 함수이다. 즉, 이 코드는 총알이 생성된 후 일정한 시간이 지나면 총알이 자동으로 제거되도록 하는 역할을 한다. 이렇게 하면 총알이 무한히 존재하지 않고, 일정 시간 후에 사라지게 된다. Destroy(gameObject, 2f);와 같이 쓰면 총알이 생성된 후 2초가 지나면 제거된다.
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(new Vector3(0, 0, speed), Space.Self); // 총알이 자신의 앞쪽 방향으로 이동한다. 즉, 총알이 발사된 방향으로 이동한다. transform.Translate는 게임 오브젝트의 위치를 변환하는 함수이다. new Vector3(0, 0, speed)는 총알이 이동할 방향과 거리를 나타내는 벡터이다. Space.Self는 총알의 로컬 좌표계를 기준으로 이동한다는 뜻이다. 즉, 총알이 바라보는 방향이 앞으로 간다.
    }

    // 이 함수가 제대로 실행되려면
    // Rigidbody 컴포넌트가 필요하다. Rigidbody 컴포넌트는 물리 엔진을 사용해서 게임 오브젝트의 움직임과 충돌을 처리하는 컴포넌트이다. 이 컴포넌트를 추가하면 총알이 몬스터와 충돌할 때 OnCollisionEnter 함수가 호출된다. 즉, 이 함수를 사용하려면 총알 게임 오브젝트에 Rigidbody 컴포넌트를 추가해야 한다.
    // 또한 Use Gravity 옵션을 꺼야 한다. Use Gravity 옵션이 켜져 있으면 총알이 중력의 영향을 받아서 떨어지게 된다. 하지만 총알이 발사된 방향으로 직선으로 이동하도록 하려면 Use Gravity 옵션을 꺼야 한다. 이렇게 하면 총알이 중력의 영향을 받지 않고, 발사된 방향으로 직선으로 이동하게 된다.
    private void OnCollisionEnter(Collision collision)  // collision을 통해 타겟의 정보를 알 수 있다.
    {
        // 총알이 몬스터와 충돌했을 때, 총알을 제거한다.
        Destroy(collision.gameObject); // 충돌한 게임 오브젝트를 제거한다. 즉, 총알이 몬스터와 충돌하면 몬스터가 제거된다. collision.gameObject는 충돌한 게임 오브젝트를 나타내는 변수이다. Destroy 함수는 게임 오브젝트를 제거하는 함수이다. 즉, 이 코드는 총알이 몬스터와 충돌했을 때 몬스터가 제거되도록 하는 역할을 한다.
    }
}
