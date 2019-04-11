using ETModel;
using UnityEngine;

namespace ETHotfix
{
    [Event(EventIdType.LandlordsInitSceneStart)]
    public class InitSceneStart_CreateLandlordsLogin : AEvent
    {
        public override void Run()
        {
            UI ui = LandlordsLoginFactory.Create();
            Game.Scene.GetComponent<UIComponent>().Add(ui);

            //设置canvas
            string canvasName = ui.GameObject.GetComponent<CanvasConfig>().CanvasName;
            Transform loginCanvas = Game.Scene.GetComponent<UIComponent>().Root.Get<GameObject>(canvasName).transform;
            ui.GameObject.transform.SetParent(loginCanvas, false);
        }
    }
}
