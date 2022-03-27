using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Encora.Statement.Two
{
    public class DataHandler : MonoBehaviour
    {
        public delegate void OnPositionChanged(string data);
        public OnPositionChanged delegateOfPositionChanged;
        
        private Vector3 lastPosition;
        private Vector3 sendPosition;
        private float xPosOffset = 22.0f;
        
        private void Start() 
        {
            InvokeRepeating("EmitData", 0.0f, 1.0f / 10.0f);
        }

        private void EmitData()
        {
            if(lastPosition != sendPosition)
            {
                // send new position
                sendPosition = lastPosition;
                string strData = System.Convert.ToBase64String(VectorConverter.VectorToByteArray(sendPosition));
                
                Debug.Log("Encoded : " + strData);
                Debug.Log(string.Format("Sent : {0} || size: {1} bits", sendPosition, VectorConverter.VectorToByteArray(sendPosition).Length * 8));
                
                if(delegateOfPositionChanged != null)
                    delegateOfPositionChanged(strData);
            }
        }

        public void SendData(Vector3 argPos)
        {
            lastPosition = argPos;
            lastPosition[0] = lastPosition[0] + xPosOffset;
        }
    }
}
