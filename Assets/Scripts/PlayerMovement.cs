using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform tr;
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;
    
    void FixedUpdate()
    {
        if (tr.position.x > 15f || tr.position.x < 0f) 
        {
            rb.useGravity = true;
        }
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(tr.position.y < -1f)
        {
            FindObjectOfType<ManagerScript>().EndGame();
        }
    }
    
}
