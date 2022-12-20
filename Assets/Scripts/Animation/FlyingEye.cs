using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEye : MonoBehaviour
{
    private float timer;
    private Animator fe_animator;
    private Rigidbody2D fe_body2d;
    private bool fe_shoot;
    private float fe_timeSinceShot;
    private float fe_shootDelay = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        fe_animator = GetComponent<Animator>();
        fe_body2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        fe_timeSinceShot += Time.deltaTime;
        if (timer >= 1.8f)
        {
            fe_animator.SetBool("fe_shoot", true);
            
            if (timer > 2)
            {
                fe_animator.SetBool("fe_shoot", false);
                timer = 0;
            }
        }
        
    }
}
