using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && GetComponent<Rigidbody>().position.z<7.5)
            transform.Translate((Vector3.forward) * Time.deltaTime * 10);
        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && GetComponent<Rigidbody>().position.z>1.25)
            transform.Translate((Vector3.back) * Time.deltaTime * 10);
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && GetComponent<Rigidbody>().position.x > -8)
            transform.Translate((Vector3.left) * Time.deltaTime * 10);
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && GetComponent<Rigidbody>().position.x < 8)
            transform.Translate((Vector3.right) * Time.deltaTime * 10);
    }
}
