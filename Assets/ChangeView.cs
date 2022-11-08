using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    //list of objects to look at
    public GameObject[] targets;
    private int currentTarget = 0;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targets[currentTarget].transform.position);
        timer += Time.deltaTime;
        if(timer % 5 <= 0.1) {
            currentTarget++;
        }
    }
}
