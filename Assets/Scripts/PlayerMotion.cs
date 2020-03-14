using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    public float motionspeed = 50f;
    private Rigidbody2D playa;
    private Vector2 vectors;
    // Start is called before the first frame update
    void Start()
    {
        playa = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 gamerinput = new Vector2(Input.GetAxisRaw("Horizontal"), 0.0f);
        vectors = gamerinput.normalized * motionspeed;
    }

    void FixedUpdate()
    {
        playa.MovePosition(playa.position + vectors * Time.fixedDeltaTime);
    }
}
