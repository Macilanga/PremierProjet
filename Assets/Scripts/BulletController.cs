using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    private new Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start() {
        rigidbody2D = this.GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(new Vector2(0f, 200f));
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}