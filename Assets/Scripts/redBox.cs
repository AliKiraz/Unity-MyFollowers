using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBox : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject clone1;
    string cloneName;
    void Start()
    {
        cloneName="MaleFree1 (1)(Clone)";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name==cloneName){
            other.gameObject.SetActive(false);
           cloneName="E";
        }
    }
}
