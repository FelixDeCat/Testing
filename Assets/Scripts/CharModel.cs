using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharModel : MonoBehaviour
{
    [SerializeField] CharController controller;
    Rigidbody myrig;
    [SerializeField] float speed = 100;

    private void Awake()
    {
        myrig = GetComponentInParent<Rigidbody>();
    }

    void FixedUpdate()
    {
        myrig.velocity = controller.Move * speed * Time.deltaTime;
    }
}
