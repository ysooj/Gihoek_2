using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager : MonoBehaviour
{
    public GameObject UIMain;
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
        UIMain.gameObject.SetActive(false);
    }
}
