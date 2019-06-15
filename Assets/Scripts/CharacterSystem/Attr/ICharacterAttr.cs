/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              ICharacterAttr.cs 
    *Author:                Norlan 
    *Version:               0.1 
    *UnityVersion:          2018.3.0f2 
    *Date:                  2019-06-15 
    *Description:           角色的公共属性
    *History:               自定义，可以不写内容，可以删除该行
/***********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Red
{
	public class ICharacterAttr 
	{
        /// <summary>
        /// 名称
        /// </summary>
        protected string mName;

        /// <summary>
        /// 最大血量
        /// </summary>
        protected int mMaxHP;

        /// <summary>
        /// 移动速度
        /// </summary>
        protected float mMoveSpeed;

        /// <summary>
        /// 当前血量
        /// </summary>
        protected int mCurrentHP;

        /// <summary>
        /// 头像
        /// </summary>
        protected string mIconSprite;

        /// <summary>
        /// 角色等级
        /// </summary>
        protected int mLv;

        /// <summary>
        /// 暴击率 0-1
        /// </summary>
        protected float mCritRate;

        //增加的最大血量 抵御的伤害值 暴击增加的伤害
        protected IAttrStrategy mStrategy;
    }
}