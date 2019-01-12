using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody rb;
    public ManagerScript gameManager;
    //public Material playerMaterial;
    //public Material[] material;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "ObstacleBlue")
        {
            movement.enabled = false;
            rb.useGravity = true;
            //Debug.Log(GetComponent<Material>().name);
            FindObjectOfType<ManagerScript>().EndGame();
        }               
    }
}
