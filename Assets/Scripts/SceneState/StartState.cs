/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              StartState.cs 
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
using UnityEngine.UI;

namespace Red
{
	public class StartState :ISceneState
	{
        public StartState(SceneStateController controller) : base("01.StartScene", controller)
        {

        }

        private Image mLogo;
        private float mSmoothingSpeed = 2;
        private float mWaitTime = 2;

        public override void StateStart()
        {
            //base.StateStart();
            mLogo = GameObject.Find("Logo").GetComponent<Image>();

            mLogo.color = Color.black;
        }


        public override void StateUpdate()
        {
            //base.StateUpdate();
            mLogo.color = Color.Lerp(mLogo.color,Color.white,mSmoothingSpeed*Time.deltaTime);

            mWaitTime -= Time.deltaTime;
            if(mWaitTime <= 0)
            {
                mController.SetState(new MainMenuState(mController));
            }
        }



        public override void StateEnd()
        {
            //base.StateEnd();
        }





    }
}