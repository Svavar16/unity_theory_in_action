using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_script : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var player = new Player();
        player.Move();
    }

    // abstract
    public class Player {
        private float speed = 10f;
        private object transform;

        // encapsulation
        public void Move()
        {
            float y = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(0, 0, y);
            transform.Translate(1, speed, Time.deltaTime);
        }

    }

    // Inheritance and polymorphism 
    public class Enemy : Player 
    {
        public GameObject enemy;
    };
}
