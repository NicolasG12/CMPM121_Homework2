using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private float timer = 0f;
    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        float distance = Mathf.Sin(2 * timer) / 10f;
        transform.position += new Vector3(-distance, 0, distance);
        
    }
}
