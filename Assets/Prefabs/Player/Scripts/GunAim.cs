using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAim : MonoBehaviour
{
    public float speed;

    public float horizontalSpeed = 0F;
    public float verticalSpeed = -1.0f;

    public float minAim = -5f, maxAim = 5f;

    private Vector2 euler;

    void Update()
    {

        float h = horizontalSpeed *Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
    }
}
