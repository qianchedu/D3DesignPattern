/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              IAttrStrategy.cs 
    *Author:                Norlan 
    *Version:               0.1 
    *UnityVersion:          2018.3.0f2 
    *Date:                  2019-06-16 
    *Description:           AedAlter
    *History:               自定义，可以不写内容，可以删除该行
/***********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Red
{
	public interface IAttrStrategy 
	{
        /// <summary>
        /// 增加的血量
        /// </summary>
        /// <param name="lv"></param>
        /// <returns></returns>
        int GetExtraHPValue(int lv);


        /// <summary>
        /// 减免的伤害
        /// </summary>
        /// <param name="lv"></param>
        /// <returns></returns>
        int GetDmgDescValue(int lv);


        /// <summary>
        /// 暴击伤害
        /// </summary>
        /// <returns></returns>
        int GetCritDmg(int critRate);
	}

}