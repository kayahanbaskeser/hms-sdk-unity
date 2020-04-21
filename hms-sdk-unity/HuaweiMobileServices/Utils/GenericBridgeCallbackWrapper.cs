﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    internal class GenericBridgeCallbackWrapper : AndroidJavaProxy
    {

        private Action<AndroidIntent> mOnSuccessListener;
        private Action<Exception> mOnFailureListener;
        
        public GenericBridgeCallbackWrapper() : base("org.m0skit0.android.hms.unity.GenericBridgeCallback") { }

        public GenericBridgeCallbackWrapper AddOnSuccessListener(Action<AndroidIntent> onSuccessListener)
        {
            mOnSuccessListener = onSuccessListener;
            return this;
        }

        public GenericBridgeCallbackWrapper AddOnFailureListener(Action<Exception> onFailureListener)
        {
            mOnFailureListener = onFailureListener;
            return this;
        }

        // WARNING: DO NO MODIFY METHOD NAME, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onSuccess(AndroidJavaObject intent)
        {
            if (mOnSuccessListener != null)
            {
                mOnSuccessListener.Invoke(intent.AsWrapper<AndroidIntent>());
            }
        }

        // WARNING: DO NO MODIFY METHOD NAME, THIS IS CALLED DIRECTLY FROM JAVA!
        public void onFailure(AndroidJavaObject exception)
        {
           if (mOnFailureListener != null)
            {
                mOnFailureListener.Invoke(exception.AsException());
            }
        }
    }
}