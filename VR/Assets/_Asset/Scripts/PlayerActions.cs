using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    public float speed;
    private void OnMove(InputValue value)
    {
        Vector2 inputval = value.Get<Vector2>();
        Vector3 dir = new Vector3(inputval.x, 0, inputval.y);
        this.transform.Translate(dir * speed);
    }
}
