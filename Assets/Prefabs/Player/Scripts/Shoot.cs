using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject flash;

    //Aiming
    public GameObject hipFire;
    public GameObject aim;
    public GameObject mCamera;
    public GameObject aimCamera;

    public GameObject rifle;
    public GameObject flameThrower;

    void Update()
    {
        SwitchWeapons();

        if(Input.GetMouseButtonDown(0))
        {
            flash.SetActive(true);

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

    public void SwitchWeapons()
    {
        if (Input.GetKey(KeyCode.Alpha1)) // forward
        {
            rifle.SetActive(true);
            flameThrower.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.Alpha2)) // backwards
        {
            rifle.SetActive(false);
            flameThrower.SetActive(true);
        }
    }

}
