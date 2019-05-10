using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMaze : MonoBehaviour {

    public Transform PlayerObj;

    // Update is called once per frame
    void Update () {
        if (!LeaveControl.IsPaused)
        {
            if (Input.GetKey("w"))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -MainGame.MoveSpeed);
                PlayerObj.transform.eulerAngles = new Vector3(0, 0, 0);
            }

            else if (Input.GetKey("s"))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, MainGame.MoveSpeed);
                PlayerObj.transform.eulerAngles = new Vector3(0, 0, 180);
            }

            else if (Input.GetKey("a"))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(MainGame.MoveSpeed, 0);
                PlayerObj.transform.eulerAngles = new Vector3(0, 0, 90);
            }

            else if (Input.GetKey("d"))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-MainGame.MoveSpeed, 0);
                PlayerObj.transform.eulerAngles = new Vector3(0, 0, 270);
            }

            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
        }
    }
}
