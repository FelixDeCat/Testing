using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    Vector3 v3Move;
    public Vector3 Move
    {
        get
        {
            v3Move.x = Input.GetAxis("Horizontal");
            v3Move.z = Input.GetAxis("Vertical");
            return v3Move;
        }
    }
}
