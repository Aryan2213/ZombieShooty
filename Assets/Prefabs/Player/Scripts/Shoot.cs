using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject flash;
    public AudioSource bang;

    //Aiming
    public GameObject hipFire;
    public GameObject aim;
    public GameObject mCamera;
    public GameObject aimCamera;
    

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            flash.SetActive(true);
            bang.Play();

        }
        else if(Input.GetMouseButtonUp(0))
        {
            flash.SetActive(false);
            //bang.Stop();
        }

        // Aim
        if (Input.GetMouseButtonDown(1))
        {
            aim.SetActive(true);
            hipFire.SetActive(false);
            mCamera.SetActive(false);
            aimCamera.SetActive(true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            aim.SetActive(false);
            hipFire.SetActive(true);
            mCamera.SetActive(true);
            aimCamera.SetActive(false);
        }
    }
}
