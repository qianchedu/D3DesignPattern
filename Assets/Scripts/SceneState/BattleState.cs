/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              BattleState.cs 
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
	public class BattleState : ISceneState
    {
        public BattleState(SceneStateController controller) : base("03.BattleScene", controller)
        {

        }


        //兵营 关卡 角色管理 行动力 成就系统。。。



        public override void StateStart()
        {
            // base.StateStart();
            GameFacade.Instance.Init();
        }


        public override void StateUpdate()
        {
            //  base.StateUpdate();
            GameFacade.Instance.Update();
        }


        public override void StateEnd()
        {
            //   base.StateEnd();

            if (GameFacade.Instance.isGameOver)
            {
                mController.SetState(new MainMenuState(mController));
            }

            GameFacade.Instance.Release();
        }

    }
}