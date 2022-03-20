using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mainCharacter.isStart == true)
        {
            if (mainCharacter.isFinish == false)
            {
                this.gameObject.transform.Translate(new Vector3(0, 0, 5 * Time.deltaTime));
            }

        }


    }
}
