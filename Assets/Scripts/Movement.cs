using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    float horizontalAxisValue, verticalAxisValue;
    Vector3 direction;
    Animations anim;

    private void Start()
    {
        anim = GetComponent<Animations>();
    }

    private void Update()
    {
        horizontalAxisValue = Input.GetAxis("Horizontal");
        verticalAxisValue = Input.GetAxis("Vertical");
        direction = new Vector3(horizontalAxisValue, 0, verticalAxisValue);
        MoveCharacter(anim);
    }
    void MoveCharacter(Animations animation)
    {
        if (direction != Vector3.zero)
        {
            animation.StartWalking();
            transform.forward = direction;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        else
        {
            animation.EndWalking();
        }
    }
}
