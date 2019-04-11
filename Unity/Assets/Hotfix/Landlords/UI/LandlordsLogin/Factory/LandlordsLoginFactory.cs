using ETModel;
using System;
using UnityEngine;

namespace ETHotfix
{
    public static class LandlordsLoginFactory
    {
        public static UI Create()
        {
            try
            {
                ResourcesComponent resourcesComponent = ETModel.Game.Scene.GetComponent<ResourcesComponent>();
                resourcesComponent.LoadBundle(UIType.LandlordsLogin.StringToAB());
                GameObject bundleGameObject = (GameObject)resourcesComponent.GetAsset(UIType.LandlordsLogin.StringToAB(), UIType.LandlordsLogin);
                GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);

                UI ui = ComponentFactory.Create<UI, string, GameObject>(UIType.LandlordsLogin, gameObject, false);

                ui.AddComponent<LandlordsLoginComponent>();
                return ui;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return null;
            }
        }
    }
}
