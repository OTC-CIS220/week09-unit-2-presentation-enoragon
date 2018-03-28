using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {

    private bool gyroEnabled;
    private Gyroscope gyro;

    //private Quaternion rot;
    private float rotx = 0;
    private float roty = 0;
    private float rotz = 0;
    private float rotw = 0;

    // Use this for initialization
    void Start () {
        gyroEnabled = EnableGyro();
	}

	// Update is called once per frame
	void Update () {
        if (gyroEnabled)
        {
            rotx = Input.acceleration.x;
            roty = Input.acceleration.y;
            rotz = Input.acceleration.z; 
            transform.rotation = new Quaternion(rotx, roty, rotz, rotw);
        }
	}

    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;


            return true;
        }

        return false;
    }
}
