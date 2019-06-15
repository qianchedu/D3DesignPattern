/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              WeaponRifle.cs 
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

namespace Red
{
	public class WeaponRifle :IWeapon
	{
        public override void Fire(Vector3 targetPosition)
        {
            Debug.Log("显示特效 WeaponRifle");
            Debug.Log("播放声音 WeaponRifle");
        
        }
    }
}