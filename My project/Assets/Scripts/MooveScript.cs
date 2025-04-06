using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MooveScript : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    
    private bool changer=true;
    // Start is called before the first frame update
    void Start()
    {
        

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position == point1.position) changer = false;
        if (transform.position == point2.position) changer = true;
        if (changer) transform.position = Vector3.MoveTowards(transform.position, point1.position, Time.deltaTime);
        if (changer == false) transform.position = Vector3.MoveTowards(transform.position, point2.position, Time.deltaTime);
    }
}
