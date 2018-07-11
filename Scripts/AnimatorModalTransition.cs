using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using M8.UIModal.Interface;

/// <summary>
/// Use this for animating open/close of a Modal
/// </summary>
public class AnimatorModalTransition : MonoBehaviour, IOpening, IClosing {
    public M8.Animator.Animate animator;

    public string takeOpen;
    public string takeClose;

    IEnumerator IOpening.Opening() {
        if(animator && !string.IsNullOrEmpty(takeOpen)) {
            animator.Play(takeOpen);
            while(animator.isPlaying)
                yield return null;
        }
    }

    IEnumerator IClosing.Closing() {
        if(animator && !string.IsNullOrEmpty(takeClose)) {
            animator.Play(takeClose);
            while(animator.isPlaying)
                yield return null;
        }
    }
}
