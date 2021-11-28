using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController3 : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] GameObject hills;
    SurfaceEffector2D se;
    [SerializeField] float torqueAmount = 6f;
    [SerializeField] float speedAmount = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        se = hills.GetComponent<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(torqueAmount * -1);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            se.speed += speedAmount;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            se.speed -= speedAmount;
        }
        //rb2d.AddTorque(-1*Input.GetAxis("Horizontal")*torqueAmount) ; 
        //se.speed += Input.GetAxis("Vertical") * speedAmount ;
    }
}
