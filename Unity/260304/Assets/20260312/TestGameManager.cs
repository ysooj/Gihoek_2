using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    // 이 두 부분을 통해서 New Game 버튼을 누르면 UI가 비활성화, 즉, 꺼지도록 만들 수 있습니다.
    public GameObject UIMain;   // 이 부분과
    public void OnSave()
    {
        Debug.Log("Data Save!");
    }

    public void OnLoad()
    {
        Debug.Log("Data Load!");
    }

    public void OnNewGame()
    {
        UIMain.gameObject.SetActive(false); // 이 부분입니다.
    }
}

// 그리고 Unity에서 아까 새로 만든 오브젝트(TestGameManager)의 스크립트에 UIMain 오브젝트를 등록해줘야 한다.