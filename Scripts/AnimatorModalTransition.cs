using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using M8;

/// <summary>
/// Use this for animating open/close of a Modal
/// </summary>
[AddComponentMenu("M8/Extension/Animator/Modal Transition")]
public class AnimatorModalTransition : MonoBehaviour, IModalOpening, IModalClosing {
    public M8.Animator.Animate animator;
    [M8.Animator.TakeSelector(animatorField = "animator")]
    public string takeOpen;
    [M8.Animator.TakeSelector(animatorField = "animator")]
    public string takeClose;

    IEnumerator IModalOpening.Opening() {
        if(animator && !string.IsNullOrEmpty(takeOpen)) {
            animator.Play(takeOpen);
            while(animator.isPlaying)
                yield return null;
        }
    }

    IEnumerator IModalClosing.Closing() {
        if(animator && !string.IsNullOrEmpty(takeClose)) {
            animator.Play(takeClose);
            while(animator.isPlaying)
                yield return null;
        }
    }
}
