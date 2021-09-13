using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowRobot : MonoBehaviour
{
    public Transform target;

    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = target.position;
        position.z = Camera.main.transform.position.z;
        Camera.main.transform.position = position;
    }
}
