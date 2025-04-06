using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpringbehavior : MonoBehaviour
{
    public Transform springStrartPosition;
    public Rigidbody spring;
    private float timer = 5;
    private bool releasedSpring = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = springStrartPosition.position;
        spring.isKinematic = true;
        
    }
    private void SpringRelease()
    {
        if (timer < 0)
        {
            spring.isKinematic = false;
            timer = 5;
            releasedSpring = true;


        }
        if (timer < 4 && releasedSpring)
        {
            transform.position = springStrartPosition.position;
            spring.isKinematic = true;
            releasedSpring = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        SpringRelease();
    }
}
