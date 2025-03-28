using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField]
    Animator anim;

    public void ToggleAnimation()
    {
        anim.SetBool("PlayAnimation", !anim.GetBool("PlayAnimation"));
    }
}
