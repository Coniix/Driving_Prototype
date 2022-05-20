using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 30f;
    private float horizontalInput = 0f;
    private float forwardInput = 0f;
    public LayerMask m_LayerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Taking player input
        if(checkIsGrounded() == true){
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
        }

        //We move the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    bool checkIsGrounded()
    {
        Collider[] hitColliders = Physics.OverlapBox(transform.position, new Vector3(1.5f,1.5f,2.5f), Quaternion.identity, m_LayerMask);

        if(hitColliders.Length > 0){
            return true;
        }
        else{
            return false;
        }
    }
}
