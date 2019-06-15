/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              SceneStateController.cs 
    *Author:                Norlan 
    *Version:               0.1 
    *UnityVersion:          2018.3.0f2 
    *Date:                  2019-06-14 
    *Description:           使用状态模式进行场景的切换
    *History:              
/***********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Red
{
	public class SceneStateController 
	{

        private ISceneState mState;
        private AsyncOperation mAo;
        private bool mIsRunStart = false;

        public void SetState(ISceneState state,bool isLoadScene = true)
        {
            if(mState != null)
            {
                mState.StateEnd();      //让上一个场景状态做一下清理工作
            }
            mState = state;

            if (isLoadScene)
            {
                mAo = SceneManager.LoadSceneAsync(mState.SceneName);
                mIsRunStart = false;
            }
            else{
                mState.StateStart();
                mIsRunStart = true;
            }

           
        }

        public void StateUpdate()
        {
            if (mAo != null && mAo.isDone == false) return;

            if(mIsRunStart== false && mAo!= null&& mAo.isDone==true)
            {
                mState.StateStart();
                mIsRunStart = true;

            }

            if(mState != null)
            {
                mState.StateUpdate();
            }
        }
	}
}