using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Move : MonoBehaviour
{
    public float curSpeed;
    public float speed = 5;
    public float aimSpeed = 1;
    public float jumpHieght = 100f;

    Rigidbody rb;
    public bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        curSpeed = speed;
        Cursor.visible = false;
        canJump = true;
        rb = GetComponent<Rigidbody>();
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

        if (canJump)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
                canJump = false;
                //LateUpdate();
            }
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
