using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectileObject;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            spawn();
            timer = 0;
        }
    }


    private void spawn()
    {
        Instantiate(projectileObject, transform.position, transform.rotation);
    }
}
