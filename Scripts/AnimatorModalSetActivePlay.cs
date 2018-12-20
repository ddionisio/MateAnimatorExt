using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using M8;

/// <summary>
/// Use this to play an animation when a modal activates after opening
/// </summary>
[AddComponentMenu("M8/Extension/Animator/Modal SetActive Play")]
public class AnimatorModalSetActivePlay : MonoBehaviour, IModalActive {
    public M8.Animator.Animate animator;
    [M8.Animator.TakeSelector(animatorField = "animator")]
    public string takeActive;
    [M8.Animator.TakeSelector(animatorField = "animator")]
    public string takeInactive;

    void IModalActive.SetActive(bool aActive) {
        if(aActive) {
            if(animator && !string.IsNullOrEmpty(takeActive))
                animator.Play(takeActive);
        }
        else {
            if(animator && !string.IsNullOrEmpty(takeInactive))
                animator.Play(takeInactive);
        }
    }
}
