/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              ISceneState.cs 
    *Author:                Norlan 
    *Version:               0.1 
    *UnityVersion:          2018.3.0f2 
    *Date:                  2019-06-14 
    *Description:           AedAlter
    *History:               自定义，可以不写内容，可以删除该行
/***********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Red
{
	public class ISceneState 
	{
        /// <summary>
        /// 场景的名字
        /// </summary>
        private string mSceneName;

        /// <summary>
        /// 状态的拥有者
        /// </summary>
        protected SceneStateController mController;

        public ISceneState(string sceneName,SceneStateController controller)
        {
            mSceneName = sceneName;
            mController = controller;
        }

        public string SceneName
        {
            get
            {
                return mSceneName;
            }
        }

        //每次进入到这个状态的时候调用
        public virtual void StateStart() { }
        //每次离开的这个状态的时候调用
        public virtual void StateEnd() { }
        //每帧调用
        public virtual void StateUpdate() { }
	}
}