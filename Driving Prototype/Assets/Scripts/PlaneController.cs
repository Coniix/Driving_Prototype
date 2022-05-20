using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed = 25f;
    public float turnSpeed = 25f;
    private float pitch = 0f;
    private float roll = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        pitch = Input.GetAxis("Vertical");
        roll = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.right, Time.deltaTime * turnSpeed * pitch);
        transform.Rotate(Vector3.forward, Time.deltaTime * turnSpeed * -roll);
    }
}
