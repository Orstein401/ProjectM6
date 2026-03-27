using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator playerAnim;
    [SerializeField] private string walk = "IsWalk";
    [SerializeField] private string run = "IsRun";
    [SerializeField] private string jump = "IsJump";
    [SerializeField] private string ground = "ISGround";
    [SerializeField] private string death = "IsDeath";
    private void Awake()
    {
        playerAnim = GetComponentInChildren<Animator>();
    }

    public void SetAnimationWalk(bool IsWalk)
    {
        playerAnim.SetBool(walk, IsWalk);
    }
    public void SetAnimationRun(bool IsRun)
    {
        playerAnim.SetBool(run, IsRun);
    }
    public void SetAnimationJump(bool IsJump)
    {
        playerAnim.SetBool(jump, IsJump);
    }
    public void SetAnimationGround(bool IsGround)
    {
        playerAnim.SetBool(death, IsGround);
    }
    public void SetAnimationDeath(bool IsDeath)
    {
        playerAnim.SetBool(death, IsDeath);
    }
}
