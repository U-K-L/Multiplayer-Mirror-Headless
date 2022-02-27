using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        Debug.Log("movement handled");
    }

    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHori = Input.GetAxis("Horizontal");
            float moveVert = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHori *0.05f, moveVert* 0.05f, 0);
            transform.position = transform.position + movement;
            Debug.Log(moveHori);
        }
    }
}
