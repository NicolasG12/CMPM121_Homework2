using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public Transform target;
    private float[] origin = {13f, 0.5f, 10.5f};
    // private float[] ending = {}
    private float movementSpeed = 0.2f;
    // Update is called once per frame
    void Update() {
        transform.position += new Vector3(-movementSpeed * Time.deltaTime, 0, movementSpeed* Time.deltaTime);
        
    }
}
