﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    public float Angle { set; private get; } = 0.5f*Mathf.PI;

    private Rigidbody2D rb;

    public ParticleSystem hitParticlePrefab;

    public List<string> collisionTags = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(Mathf.Cos(Angle),Mathf.Sin(Angle),0).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collisionTags.Contains(other.tag)) {
            if (CueManager.HasCues()) {
                Instantiate(hitParticlePrefab, rb.position, Quaternion.identity);
            }
            Destroy(gameObject); 
        }
    }
}