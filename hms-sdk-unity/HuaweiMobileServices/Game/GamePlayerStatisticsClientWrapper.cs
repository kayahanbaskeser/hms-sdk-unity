﻿namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class GamePlayerStatisticsClientWrapper : JavaObjectWrapper, IGamePlayerStatisticsClient
    {

        
        public GamePlayerStatisticsClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<GamePlayerStatistics> GetGamePlayerStatistics(bool paramBoolean) =>
            CallAsWrapper<TaskJavaObjectWrapper<GamePlayerStatistics>>("getGamePlayerStatistics", paramBoolean);
    }
}
