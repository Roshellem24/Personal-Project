using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRB;
    private GameObject player;
    Animator anim;
    GameManagerDos gmDos;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
        gmDos = GameObject.Find("GameManager").GetComponent<GameManagerDos>();
        if(player != null)
        {
            anim.SetBool("Walk Forward", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
        Vector3 lookDirection = (player.transform.position- transform.position).normalized;
        enemyRB.AddForce(lookDirection * speed);
    }
    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == player)
        {
            gmDos.UpdateLives(-1);
        }
    }

}
