using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Encora.Statement.Three
{
    public class UIManager : MonoBehaviour
    {
        public delegate void OnAnimationChanged(int index);
        public OnAnimationChanged delegateOfOnAnimationChanged;

        [SerializeField]private Text txtMessage;
        [SerializeField]private Button btnAttack;
        [SerializeField]private Button btnDie;
        [SerializeField]private Button btnIdle;

        string strStartMsg = "Hey, i am DOGKNIGHT.";

        internal void SetStartMessage()
        {
            txtMessage.text = string.Empty;
            StartCoroutine (IEnumeratorStartMessage());
        }

        private IEnumerator IEnumeratorStartMessage()
        {
            foreach (char c in strStartMsg) 
		    {
			    txtMessage.text += c;
			    yield return new WaitForSeconds (0.125f);
		    }
            btnAttack.gameObject.SetActive(true);
            btnDie.gameObject.SetActive(true);
            btnIdle.gameObject.SetActive(true);
        }

        public void OnClickButton(int argIndex)
        {
            if(delegateOfOnAnimationChanged != null)
                delegateOfOnAnimationChanged(argIndex);
        }
    }
}
