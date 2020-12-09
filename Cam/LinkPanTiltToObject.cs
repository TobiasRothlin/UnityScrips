using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LinkPanTiltToObject : MonoBehaviour
{
    public Transform target;
    public float smoothness = 0.1F;

    private float XAngle = 0;
    private float YAngle = 0;
    private Vector3 CameraToTarget;




    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        CameraToTarget = target.position - transform.position;

        Vector3 XangleVector = new Vector3(0, CameraToTarget.y, CameraToTarget.z);
        Vector3 YangleVector = new Vector3(CameraToTarget.x, 0, CameraToTarget.z);        

        YAngle = (float)(Math.Acos(CameraToTarget.x / (YangleVector.magnitude)) * (360 / (2 * Math.PI)));

        YAngle *= SignumFunction(CameraToTarget.z);
        Debug.Log("Z Value: " + CameraToTarget.z.ToString() + " | Signum Function: " + SignumFunction(CameraToTarget.z).ToString() + " | YAngle: " + YAngle.ToString());

        XAngle = (float)(Math.Acos(CameraToTarget.y / (CameraToTarget.magnitude)) * (360 / (2 * Math.PI)));
        

        transform.rotation = Quaternion.Euler(XAngle - 90, YAngle + 90, 0);
    }


    

    float SignumFunction(float value)
    {
        if(value < 0)
        {
            return 1F;
        }

        if(value.Equals(0))
        {
            return 0;
        }

        return - 1F;
    }
} 