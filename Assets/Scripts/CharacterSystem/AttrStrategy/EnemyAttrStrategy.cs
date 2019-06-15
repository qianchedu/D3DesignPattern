/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              EnemyAttrStrategy.cs 
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
	public class EnemyAttrStrategy : IAttrStrategy
	{
        public int GetCritDmg(int critRate)
        {
            if (Random.Range(0, 10) < critRate)
            {
                return (int)( 10 * Random.Range(0.5f, 1f));
            }
            return 0;
        }

        public int GetDmgDescValue(int lv)
        {
            return 0;
        }

        public int GetExtraHPValue(int lv)
        {
            return 0;
        }

	}
}