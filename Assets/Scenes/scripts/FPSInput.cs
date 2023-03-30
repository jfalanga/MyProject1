using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS INput")]

public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;
    // Start is called before the first frame update
    private CharacterController _charCntrl;
    private float gravity = 9.8f;
    void Start()
    {
        _charCntrl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        // Debug.Log($"deltaX: {deltaX}");
        transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime);
        Debug.Log($"The 3 times: {deltaX * Time.deltaTime}, 0,{deltaZ * Time.deltaTime}");
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);

        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = -2 * gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charCntrl.Move(movement);
    }
}
