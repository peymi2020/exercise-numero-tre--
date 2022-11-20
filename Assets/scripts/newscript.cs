using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class new script : MonoBehaviour {
    public Vector3 jump;
    public object player;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        void OnTriggerEnter(Collider other)
             if(other.tag=="player")
                Destroy(arc,10f);
    }

    void OnCollisionStay(){
        isGrounded = true;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}