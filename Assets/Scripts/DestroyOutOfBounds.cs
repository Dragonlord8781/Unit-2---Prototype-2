using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30; //top limit
    private float lowerBound = -10; // lower limit
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroys object when out of bounds + debug annoucement 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game.Over!");
        }
    }
}
