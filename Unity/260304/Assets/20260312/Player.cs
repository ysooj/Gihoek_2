using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown은 키가 눌리는 순간에만 true가 됩니다.
        // GetKey는 키가 눌리는 동안 계속 true가 됩니다.
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,speed), Space.Self);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -speed), Space.Self);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed, 0, 0), Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed, 0, 0), Space.Self);
        }
    }
}
