using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class playControl : MonoBehaviour
{
    private CharacterController cc;

    public float moveSpeed;

    public float jumpSpeed;

    private float horizontalMove, verticalMove;

    private Vector3 dir;

    public float gravity;

    private Vector3 velocity;

  

    // Start is called before the first frame update
    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {


        horizontalMove = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis("Vertical") * moveSpeed;

        dir = transform.forward * verticalMove + transform.right * horizontalMove;
        cc.Move(dir * Time.deltaTime);


        velocity.y -= gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);

    }
}
