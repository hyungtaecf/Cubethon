using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 100f;

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            if(rb.position.y>=1&&rb.position.y<=2) rb.AddForce(0, jumpForce *Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
