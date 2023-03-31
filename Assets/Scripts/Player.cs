using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    public float verticalInput;
    public float horizontalInput;
    GameManagerDos gmDos;
    public float rotationSpeed;

    Animator chickenAnim;


    // Start is called before the first frame update
    void Start()
    {
        chickenAnim = GetComponent<Animator>();
        gmDos = GameObject.Find("GameManager").GetComponent<GameManagerDos>();
    }

    void Update()
    {
         // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis ("Horizontal");

         // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * verticalInput);


        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);


        if(verticalInput > 0 || verticalInput < 0)
        {
            chickenAnim.SetBool("Walk", true);
        }else if (verticalInput == 0)
        {
            chickenAnim.SetBool("Walk", false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       

       
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("Chicken Leg"))
        {
            Destroy(other.gameObject);
            gmDos.AddScore(1);

        }
    }
}