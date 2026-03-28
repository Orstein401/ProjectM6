using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    public void FootStepSound()
    {
        AudioManager.Instance.PlaySound(SoundID.FootStep);
    }
    public void RunFootStepSound()
    {
        AudioManager.Instance.PlaySound(SoundID.RunFootStep);
    }
    public void JumpSound()
    {
        AudioManager.Instance.PlaySound(SoundID.Jump);
    }
    public void JumpLandSound()
    {
        AudioManager.Instance.PlaySound(SoundID.JumpLand);
    }
}
