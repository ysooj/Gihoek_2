using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, speed), Space.Self);
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
