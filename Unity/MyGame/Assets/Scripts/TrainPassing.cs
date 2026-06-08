using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainPassing : MonoBehaviour
{
    public float speed = 5f;
    private bool isWaiting = false;
    public GameObject trainGroup;
    void Update()
    {
        if (isWaiting)
        {
            return; // 기차가 지나가는 동안 대기
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z >= 120f)
        {
            StartCoroutine(ResetTrain());
        }
    }

    IEnumerator ResetTrain()
    {
        isWaiting = true;
        // 아래 코드로 하면 이 스크립트도 같이 꺼져버려서 코루틴이 중간에 멈춰서 다시 켜지지 않을 가능성이 높다.
        // gameObject.SetActive(false); // 기차를 비활성화하여 보이지 않게 함

        // 그래서 오브젝트에 Mesh Renderer가 있으면 Renderer만 끄는 게 더 안전할 수 있다.
        // 그런데 지금은 자식 오브젝트가 많고 모두 각자의 Mesh Renderer를 가지고 있어서 일일이 끄는 게 번거로울 수 있다.
        //GetComponent<MeshRenderer>().enabled = false; // 기차의 Mesh Renderer를 비활성화하여 보이지 않게 함

        // 그러니 부모를 끄는 방법으로 간다.
        trainGroup.SetActive(false); // 기차 그룹을 비활성화하여 보이지 않게 함

        yield return new WaitForSeconds(5f);

        // 처음 기차 시작 위치로 이동
        transform.position = new Vector3(transform.position.x, transform.position.y, -20f);

        // gameObject.SetActive(true); // 기차를 다시 활성화하여 보이게 함
        // GetComponent<MeshRenderer>().enabled = true; // 기차의 Mesh Renderer를 다시 활성화하여 보이게 함
        trainGroup.SetActive(true); // 기차 그룹을 다시 활성화하여 보이게 함

        isWaiting = false;
    }
}
