using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    //list of objects to look at
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActiveAndEnabled) {
        timer += Time.deltaTime / 2.5f;
        float distance = Mathf.Sin(timer) / 10f;
        transform.Rotate(0, distance, 0, Space.Self);
        }
    }
}
