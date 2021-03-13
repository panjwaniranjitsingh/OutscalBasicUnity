using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScriptForLearning : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("MyFirstScript Awake function");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MyFirstScript Start function");
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("MyFirstScript Update function");
       if(Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("Update Input F pressed");
        }

        if (Input.GetKey(KeyCode.F) || Input.GetMouseButton(0))
        {
            Debug.Log("Update Input F ");
        }

        if (Input.GetKeyUp(KeyCode.F) || Input.GetMouseButtonUp(0))
        {
            Debug.Log("Update Input F released");
        }
    }

     private void LateUpdate()
    {
        Debug.Log("MyFirstScript LateUpdate function");
    }

    private void OnDestroy()
    {
        Debug.Log("MyFirstScript OnDestroy function");
    }

}
