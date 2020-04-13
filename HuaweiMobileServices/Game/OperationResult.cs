﻿namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.jos.games.archive.OperationResult
    public class OperationResult : JavaObjectWrapper
    {

        public OperationResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual bool Different => Call<bool>("isDifference");

        public virtual Archive Archive => CallAsWrapper<Archive>("getArchive");

        public virtual Difference Difference => CallAsWrapper<Difference>("getDifference");
    }

}