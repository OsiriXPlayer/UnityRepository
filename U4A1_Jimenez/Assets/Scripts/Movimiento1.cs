using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Movimiento1 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 100.0f;
    public bool entra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (entra)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * speed);
            transform.Rotate(Vector3.right * verticalInput * Time.deltaTime * speed);
        }
       

    }
    private void OnTriggerEnter(Collider other)
    {
        entra = true;
    }
    private void OnTriggerExit(Collider other)
    {
        entra = false;
    }
}
