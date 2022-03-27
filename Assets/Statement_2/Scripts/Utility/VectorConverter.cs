using UnityEngine;
using System;

namespace Encora.Statement.Two
{
    public class VectorConverter
    {
        public static byte[] VectorToByteArray(Vector3 argVector)
        {
            byte[] buff = new byte[sizeof(float)*3];         
            Buffer.BlockCopy( BitConverter.GetBytes( argVector.x ), 0, buff, 0*sizeof(float), sizeof(float) );
            Buffer.BlockCopy( BitConverter.GetBytes( argVector.y ), 0, buff, 1*sizeof(float), sizeof(float) );
            Buffer.BlockCopy( BitConverter.GetBytes( argVector.z ), 0, buff, 2*sizeof(float), sizeof(float) );
            return buff;
        }

        public static Vector3 ByteArrayToVector(byte[] argArray)
        {
            Vector3 vect = Vector3.zero;
            vect.x = BitConverter.ToSingle(argArray,0*sizeof(float));
            vect.y = BitConverter.ToSingle(argArray,1*sizeof(float));
            vect.z = BitConverter.ToSingle(argArray,2*sizeof(float));
            return vect;
        }
    }
}
