﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {

    private bool shoot = false;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bullet, this.transform.position, Quaternion.identity);
        }
    }

    private void FixedUpdate() {

    }
}