using ETModel;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ETHotfix
{
    [ObjectSystem]
    public class LandlordsLoginComponentAwakeSystem : AwakeSystem<LandlordsLoginComponent>
    {
        public override void Awake(LandlordsLoginComponent self)
        {
            self.Awake();
        }
    }

    /// <summary>
    /// 登录界面组件
    /// </summary>
    public class LandlordsLoginComponent : Component
    {
        //账号输入框
        private InputField account;
        //密码输入框
        private InputField password;
        //提示
        private Text prompt;


        public void Awake()
        {

        }

    }
}