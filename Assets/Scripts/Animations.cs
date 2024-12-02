using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator playerAnimator;
    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
    }
    public void StartWalking()
    {
        if (!IsWalking())
        {
            playerAnimator.ResetTrigger("EndWalk");
            playerAnimator.SetBool("StartWalk", true);
        }
    }

    bool IsWalking()
    {
        return playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("Walk");
    }

    public void EndWalking()
    {
        if (IsWalking())
        {
            playerAnimator.SetTrigger("EndWalk");
            playerAnimator.SetBool("StartWalk", false);
        }
    }
}
