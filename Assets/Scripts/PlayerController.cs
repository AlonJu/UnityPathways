using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody pb;
    public int force=10;
    // Start is called before the first frame update
    void Start()
    {
        pb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) ==true) {
            pb.AddForce(Vector3.up*force, ForceMode.Impulse);
        }
    }
}
