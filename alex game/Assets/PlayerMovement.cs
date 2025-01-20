using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float HorizontalInput;
    float verticalInput;
    [SerializeField] CharacterController cc;
    [SerializeField] float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Vector3 Dir = new Vector3(-verticalInput, 0, HorizontalInput);
        cc.Move(Dir * speed * Time.deltaTime);
    }

    void CheckInput ()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

}
