
using UnityEngine;

public class SpeedLimiter : MonoBehaviour
{
    private Rigidbody speed;
    private Vector3 direction;
    private float fspeed;
    void Start()
    {
        speed = this.GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(speed.velocity.magnitude);
        fspeed = speed.velocity.magnitude;
        if (fspeed > 60f)
        {
            direction = speed.velocity.normalized;
            speed.velocity = direction * 60f;

        }   
       
    }
}
