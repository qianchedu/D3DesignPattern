/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              MainMenuState.cs 
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
	public class MainMenuState : ISceneState
    {
        public MainMenuState(SceneStateController controller) : base("02.MainMenuScene", controller)
        {
        }



        public override void StateStart()
        {
            //    base.StateStart();
             GameObject.Find("StartButton").GetComponent<Button>().onClick.AddListener(OnStartButtonOnClick);
        }



    

        private void OnStartButtonOnClick()
        {
            mController.SetState(new BattleState(mController));
        }

    }
}