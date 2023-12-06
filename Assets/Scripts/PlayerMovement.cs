using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //references na druge komponente
    public Rigidbody rb;
    public Transform Cube;
    float accelaration = 1f;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name =="ARCADE")
        {
            accelaration = 1.0001f;
        }
    }
    void FixedUpdate()
    {
        //kocka ide napred
        
        forwardForce = forwardForce * accelaration;
        
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //kocka ide levo desno
        
        sidewaysForce = sidewaysForce * accelaration;
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //kada kocka padne od platforme
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
