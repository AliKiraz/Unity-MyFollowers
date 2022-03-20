using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCharacter : MonoBehaviour
{
    public int speed;
    public static bool right, left, isFinish,isStart;
    Vector3 firstPos, endPos;
    public float playerSpeed;
    public GameObject clones,myLogo,myButton;
    Animator animator;
    static GameObject go;
    static GameObject finito, clone1, clone2, clone3, clone4, clone5, clone6, clone7, clone8;

    void Start()
    {
        isFinish = false;
        isStart=false;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(isStart==true){
 if (isFinish == false)
        {
            this.gameObject.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        else
        {
            Finish(finito);
            finishClone(clone1, 0.2f);
            finishClone(clone2, 0.4f);
            finishClone(clone3, -0.2f);
            finishClone(clone4, -0.4f);
            finishClone(clone5, 0.6f);
            finishClone(clone6, -0.6f);
            finishClone(clone7, 0.8f);
            finishClone(clone8, -0.8f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;



        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float farkX = endPos.x - firstPos.x;
            transform.Translate(farkX * Time.deltaTime * playerSpeed, 0, 0);
        }
        if (transform.position.x >= 2.29f)
        {
            this.transform.position = new Vector3(2.29f, this.transform.position.y, this.transform.position.z);
        }
        if (transform.position.x <= -1.77f)
        {
            this.transform.position = new Vector3(-1.77f, this.transform.position.y, this.transform.position.z);
        }



        }
       






    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube (1)")
        {
            cloneFunction(other.gameObject, 0.5f);
            clone1 = other.gameObject;


        }
        else if (other.gameObject.name == "Cube (2)")
        {

            cloneFunction(other.gameObject, 0.8f);
            clone2 = other.gameObject;

        }
        else if (other.gameObject.name == "Cube (3)")
        {

            cloneFunction(other.gameObject, 1.1f);
            clone3 = other.gameObject;

        }
        else if (other.gameObject.name == "Cube (4)")
        {

            cloneFunction(other.gameObject, 1.2f);
            clone4 = other.gameObject;

        }
        else if (other.gameObject.name == "Cube (8)")
        {

            cloneFunction(other.gameObject, 1.3f);
            clone5 = other.gameObject;

        }
        else if (other.gameObject.name == "Cube (9)")
        {

            cloneFunction(other.gameObject, 1.4f);
            clone6 = other.gameObject;

        }
        else if (other.gameObject.name == "Cube (10)")
        {

            cloneFunction(other.gameObject, 1.5f);
            clone7 = other.gameObject;

        }
        else if (other.gameObject.name == "Cube (11)")
        {

            cloneFunction(other.gameObject, 1.6f);
            clone8 = other.gameObject;


        }

        if (other.gameObject.name == "stopLine")
        {
            Finish(other.gameObject);
            finito = other.gameObject;

        }



    }
    void Finish(GameObject finishLine)
    {
        isFinish = true;
        this.transform.position = finishLine.transform.position;
        
    }
    void finishClone(GameObject clone, float xAxsis)
    {
        clone.transform.position = new Vector3(-1.41f, -80.21f, 117.83f);
    }
    void cloneFunction(GameObject me, float zAxis)
    {
        me.SetActive(false);
        go = GameObject.Instantiate(clones);
        go.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - zAxis);
    }
    public void ahmet(){
        isStart=true;
        myLogo.SetActive(false);
        myButton.SetActive(false);
        animator.SetBool("Land", true);

    }
}
