using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; //input
    public float speed = 10.0f; // speed
    public float xRange = 10; // range
    public GameObject projectilePrefab; // projectile
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets the axis input and connects it to horizontalInput & and use it in controls
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keeps player within range
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //shoots projectile
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
