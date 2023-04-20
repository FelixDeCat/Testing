using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Inputs
{
    axis,
    touchs,
    other
}
public class CharController : MonoBehaviour
{
    Vector3 v3Move;
    bool touch = false;
    Inputs input = Inputs.axis;
    public Vector3 Move
    {
        get
        {
            switch (input)
            {
                case Inputs.axis:
                    v3Move.x = Input.GetAxis("Horizontal");
                    v3Move.z = Input.GetAxis("Vertical");
                    break;
                case Inputs.touchs:
                    //tomo inputs de eventos de pantalla UI
                    break;
                case Inputs.other:
                    //tengo algun input alienígena
                    break;
                default:
                    //¿porque? no hay porque..
                    break;
            }

            return v3Move;
        }
    }
}
