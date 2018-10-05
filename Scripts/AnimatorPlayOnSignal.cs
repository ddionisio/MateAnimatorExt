using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPlayOnSignal : MonoBehaviour {
    public M8.Animator.Animate animator;

    [M8.Animator.TakeSelector(animatorField = "animator")]
    public string take;

    public bool resetTakeOnEnable;

    public M8.Signal signal;

    private int mTakeInd;

    void OnEnable() {
        if(resetTakeOnEnable)
            animator.ResetTake(mTakeInd);
    }

    void OnDestroy() {
        signal.callback -= OnSignal;
    }

    void Awake() {
        mTakeInd = animator.GetTakeIndex(take);

        signal.callback += OnSignal;
    }

    void OnSignal() {
        animator.Play(mTakeInd);
    }
}
