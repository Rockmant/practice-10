using UnityEngine;

public class Impulse2Script : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = collision.rigidbody.velocity.normalized;
        collision.rigidbody.AddForce(collision.rigidbody.velocity * 2f, ForceMode.Impulse);
        if (collision.rigidbody.velocity.magnitude > 60f)
        {
            collision.rigidbody.velocity = collision.rigidbody.velocity = direction * 60f;
        }
    }


}