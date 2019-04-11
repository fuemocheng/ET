using System;
using System.Collections.Generic;
using ETModel;
using UnityEngine;

namespace ETHotfix
{
	[ObjectSystem]
	public class UIComponentAwakeSystem : AwakeSystem<UIComponent>
	{
		public override void Awake(UIComponent self)
		{
            self.Awake();
		}
	}
	
	/// <summary>
	/// 管理所有UI
	/// </summary>
	public class UIComponent: Component
	{
		public GameObject Root;
		
		public Dictionary<string, UI> uis = new Dictionary<string, UI>();

        public void Awake()
        {
            this.Root = Component.Global.transform.Find("UI").gameObject;
        }

		public void Add(UI ui)
		{
			this.uis.Add(ui.Name, ui);
		}

		public void Remove(string name)
		{
			if (!this.uis.TryGetValue(name, out UI ui))
			{
				return;
			}
			this.uis.Remove(name);
			ui.Dispose();
		}
		
		public UI Get(string name)
		{
			UI ui = null;
			this.uis.TryGetValue(name, out ui);
			return ui;
		}
	}
}