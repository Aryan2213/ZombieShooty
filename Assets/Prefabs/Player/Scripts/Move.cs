using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float curSpeed;
    public float speed = 5;
    public float aimSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        curSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * curSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * curSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * curSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * curSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(1))
        {
            curSpeed = aimSpeed;
        }
        else if(Input.GetMouseButtonUp(1))
        {
            curSpeed = speed;
        }
    }
}
