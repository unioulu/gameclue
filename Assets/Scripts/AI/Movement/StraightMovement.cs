﻿using System.Collections;
    {
        this.speed = speed;
        this.angle = angle;
        Rigidbody2D rb = transform.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(angle, -speed, 0f);
    }