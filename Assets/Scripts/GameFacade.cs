/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              GameFacade.cs 
    *Author:                Norlan 
    *Version:               0.1 
    *UnityVersion:          2018.3.0f2 
    *Date:                  2019-06-15 
    *Description:           外观模式 == 中介者
    *History:               自定义，可以不写内容，可以删除该行
/***********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Red
{
	public class GameFacade 
	{

        /// <summary>
        /// 单例模式
        /// </summary>
        private static GameFacade _instance = new GameFacade();
        /// <summary>
        /// 游戏是否结束
        /// </summary>
        private bool mIsGameOver = true;

        public static GameFacade Instance { get { return _instance; } }

        public bool isGameOver
        {
            get
            {
                return mIsGameOver;
            }
        }
		
        private GameFacade() { }


        private ArchievementSystem mArchievementSystem;
        private CampSystem mCampSystem;
        private CharacterSystem mCharacterSystem;
        private EnergySystem mEnergySystem;
        private GameEventSystem mGameEventSystem;
        private StageSystem mStageSystem;

        private CampInfoUI mCampInfoUI;
        private GamePauseUI mGamePauseUI;
        private GameStateInfoUI mGameStateInfoUI;
        private SoldierInfoUI mSoldierInfoUI;



        public void Init()
        {
            mArchievementSystem = new ArchievementSystem();
            mCampSystem = new CampSystem();
            mCharacterSystem = new CharacterSystem();
            mEnergySystem = new EnergySystem();
            mGameEventSystem = new GameEventSystem();
            mStageSystem = new StageSystem();

            mCampInfoUI = new CampInfoUI();
            mGamePauseUI = new GamePauseUI();
            mGameStateInfoUI = new GameStateInfoUI();
            mSoldierInfoUI = new SoldierInfoUI();


            mArchievementSystem.Init();
            mCampSystem.Init();
            mCharacterSystem.Init();
            mEnergySystem.Init();
            mGameEventSystem.Init();
            mStageSystem.Init();

            mCampInfoUI.Init();
            mGamePauseUI.Init();
            mGameStateInfoUI.Init();
            mSoldierInfoUI.Init();


        }


        public void Update()
        {
            mArchievementSystem.Update();
            mCampSystem.Update();
            mCharacterSystem.Update();
            mEnergySystem.Update();
            mGameEventSystem.Update();
            mStageSystem.Update();

            mCampInfoUI.Init();
            mGamePauseUI.Init();
            mGameStateInfoUI.Init();
            mSoldierInfoUI.Init();
        }


        public void Release()
        {
            mArchievementSystem.Release();
            mCampSystem.Release();
            mCharacterSystem.Release();
            mEnergySystem.Release();
            mGameEventSystem.Release();
            mStageSystem.Release();

            mCampInfoUI.Release();
            mGamePauseUI.Release();
            mGameStateInfoUI.Release();
            mSoldierInfoUI.Release();
        }
	}
}