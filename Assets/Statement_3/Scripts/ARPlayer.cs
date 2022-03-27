using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Encora.Statement.Three
{
    public class ARPlayer : MonoBehaviour
    {
        [SerializeField] private Animator mAnimator;

        private void Start()
        {
            GameManager.instance.uiManager.SetStartMessage();
            GameManager.instance.uiManager.delegateOfOnAnimationChanged += OnAnimationChanged;
        }

        private void OnDestroy() 
        {
            GameManager.instance.uiManager.delegateOfOnAnimationChanged -= OnAnimationChanged;
        }

        private void OnAnimationChanged(int argIndex)
        {
            mAnimator.SetInteger("AnimIndex", argIndex);
        }
    }
}
