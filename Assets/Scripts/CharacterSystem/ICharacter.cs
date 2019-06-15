/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              ICharacter.cs 
    *Author:                Norlan 
    *Version:               0.1 
    *UnityVersion:          2018.3.0f2 
    *Date:                  2019-06-15 
    *Description:           AedAlter
    *History:               自定义，可以不写内容，可以删除该行
/***********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Red
{
    public abstract class ICharacter
    {


        ICharacterAttr mAttr;

        /// <summary>
        /// 当前角色所关联的物体
        /// </summary>
        protected GameObject mGameObject;


        /// <summary>
        /// 自动移动的组件
        /// </summary>
        protected NavMeshAgent mNavAgent;

        /// <summary>
        /// 声音
        /// </summary>
        protected AudioSource mAudio;


        //public WeaponGun gun;
        //public WeaponRifle rifle;
        protected IWeapon mWeapon;

        public IWeapon weapon { set { mWeapon = value; } }

        /// <summary>
        /// 攻击
        /// </summary>
        /// <param name="targetPosition"></param>
        public void Attack(Vector3 targetPosition)
        {
            mWeapon.Fire(targetPosition);

        }

       

        
	}
}