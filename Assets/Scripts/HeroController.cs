using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    Rigidbody2D myBody;
    public float speed = 45.0f;

	void Start ()
    {
        myBody = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        float vertical = Input.GetAxis("Vertical") * speed;
        myBody.AddForce(new Vector2(horizontal, vertical));

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Gem")
        {
            Destroy(other.gameObject);
        }
    }

}
