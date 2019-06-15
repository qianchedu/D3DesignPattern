/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              T03Strategy.cs 
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
	public class T03Strategy : MonoBehaviour
	{
		// Start is called before the first frame update
		void Start()
		{
            StrategyContext context = new StrategyContext();

            context.stragegy = new ConcreteStrategyB();
            context.Cal();
		}

		// Update is called once per frame
		void Update()
		{
			
		}

        public class StrategyContext
        {
            public IStrategy stragegy;
            public void Cal()
            {
                stragegy.Cal();
            }
        }


        public interface IStrategy
        {
            void Cal();
        }


        public class ConcreteStrategyA : IStrategy
        {
            public void Cal()
            {
                Debug.Log("user a Strategy");
            }
        }

        public class ConcreteStrategyB : IStrategy
        {
            public void Cal()
            {
                Debug.Log("user b Strategy");
            }
        }

    }
}