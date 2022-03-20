using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloneCharacter : MonoBehaviour
{

    public int speed;
    bool right, left;
    Vector3 firstPos, endPos;
    public float playerSpeed;
    public GameObject mainCha;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mainCharacter.isFinish == false)
        {

            this.gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            this.transform.position = new Vector3(mainCha.transform.position.x, this.transform.position.y, this.transform.position.z);

        }



    }

}
