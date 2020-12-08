using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkDollyToObject : MonoBehaviour
{

    public Transform target;
    public float smoothness = 0.1F;
    private Vector3 CameraOffset;
    private Vector3 CameraPosition;
    
    

    // Start is called before the first frame update
    void Start()
    {
        CameraOffset = transform.position - target.position;
        CameraPosition.x = target.GetComponent<Transform>().position.x + CameraOffset.x;
        CameraPosition.y = target.GetComponent<Transform>().position.y + CameraOffset.y;
        CameraPosition.z = target.GetComponent<Transform>().position.z + CameraOffset.z;
        transform.position = CameraPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraPosition.x = target.GetComponent<Transform>().position.x + CameraOffset.x;
        CameraPosition.y = target.GetComponent<Transform>().position.y + CameraOffset.y;
        CameraPosition.z = target.GetComponent<Transform>().position.z + CameraOffset.z;
        transform.position = Vector3.Lerp(transform.position, CameraPosition, smoothness * Time.fixedDeltaTime);
    }
}
