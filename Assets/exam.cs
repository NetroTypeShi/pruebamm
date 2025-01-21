using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exam : MonoBehaviour
{
    Vector3 direction;
    [SerializeField] float speed = 0f;
    [SerializeField] ParticleSystem particles;
    
    // Start is called before the first frame update
    void Start()
    {
        //transform.up = new Vector3(1, 1, 0);  
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;
        
        if (Input.GetKeyDown(KeyCode.W)) {particles.Play();}
        if (Input.GetKey(KeyCode.W)) {direction += Vector3.up;}
        if (Input.GetKeyUp(KeyCode.W)) {particles.Stop();}
                    
        if (Input.GetKeyDown(KeyCode.S)) { particles.Play(); }
        if (Input.GetKey(KeyCode.S)) { direction += Vector3.down; }
        if (Input.GetKeyUp(KeyCode.S)) { particles.Stop(); }
        
        if (Input.GetKeyDown(KeyCode.D)) { particles.Play(); }
        if (Input.GetKey(KeyCode.D)) { direction += Vector3.right; }
        if (Input.GetKeyUp(KeyCode.D)) { particles.Stop(); }
        
        if (Input.GetKeyDown(KeyCode.A)) { particles.Play(); }
        if (Input.GetKey(KeyCode.A)) { direction += Vector3.left; }
        if (Input.GetKeyUp(KeyCode.A)) { particles.Stop(); }

        if (direction.x != 0 && direction.y != 0)
        {
            float magnitude = Mathf.Sqrt(direction.x * direction.x + direction.y * direction.y);
            direction.x /= magnitude;
            direction.y /= magnitude;
        }

        gameObject.transform.position += direction * Time.deltaTime * speed;



    }
}
