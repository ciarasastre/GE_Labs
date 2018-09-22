using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    private Rigidbody tankBody;

    int move_speed = 5;
    int rotate_speed = 15;

    // Use this for initialization
    void Start () {

        tankBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {

        //Move tank in accordance to button pressing
        if (Input.GetKey("up"))
        {
            //Tank_Body.Translate(Vector3.left, Time.deltaTime, Space.World););
            tankBody.transform.Translate(0, 0, move_speed * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            tankBody.transform.Translate(0, 0, -move_speed * Time.deltaTime);
        }

        //Move tank by twisting left and right
        if (Input.GetKey("left"))
        {
            tankBody.transform.Rotate(0, -rotate_speed * Time.deltaTime, 0);
        }

        if (Input.GetKey("right"))
        {
            tankBody.transform.Rotate(0, rotate_speed * Time.deltaTime, 0);
        }

    }
}
