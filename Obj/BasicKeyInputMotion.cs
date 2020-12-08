using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicKeyInputMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y-0.1F, transform.position.z);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1F, transform.position.z);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - 0.1F, transform.position.y , transform.position.z);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + 0.1F, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = new Vector3(transform.position.x,  transform.position.y, transform.position.z + 0.1F);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position = new Vector3(transform.position.x,  transform.position.y, transform.position.z - 0.1F);
        }
    }
}
