using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using M8.UIModal.Interface;

/// <summary>
/// Use this to play an animation when a modal activates after opening
/// </summary>
[AddComponentMenu("M8/Extension/Animator/Modal Play On Active")]
public class AnimatorModalPlayOnActive : MonoBehaviour, IActive {
    public M8.Animator.Animate animator;
    [M8.Animator.TakeSelector(animatorField = "animator")]
    public string take;

    void IActive.SetActive(bool aActive) {
        if(aActive) {
            if(animator && !string.IsNullOrEmpty(take))
                animator.Play(take);
        }
    }
}
