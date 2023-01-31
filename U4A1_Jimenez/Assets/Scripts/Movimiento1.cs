using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Movimiento1 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 100.0f;
    public Transform platform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
            transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * speed);
            transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * speed);
       

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            platform.position = Vector3.Lerp(platform.position, platform.position, Time.deltaTime);
        }
    }
}
