/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              T01StateDesignModel.cs 
    *Author:                Norlan 
    *Version:               0.1 
    *UnityVersion:          2018.3.0f2 
    *Date:                  2019-06-14 
    *Description:           状态设计模式
    *History:               
/***********************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Red
{
    public class T01StateDesignModel : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Context context = new Context();
            IState state = new ConcreteStatesA(context);
            context.SetState(state);
            context.Handle(19);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Context
    {
        private IState mState;
        public void SetState(IState state)
        {
            mState = state;

        }

        public void Handle(int arg)
        {
            mState.Handle(arg);
        }

    }


    public interface IState
    {
        void Handle(int arg);
    }

    public class ConcreteStatesA : IState
    {

        private Context mContext;
        public ConcreteStatesA(Context context)
        {
            mContext = context;
            Debug.Log("Init ConcreteStatesA");
        }

        public void Handle(int arg)
        {
            Debug.Log("ConcreteStateA : + " + arg);
            if (arg > 10)
            {
                //转换到B
                mContext.SetState(new ConcreteStateB(mContext));
            }
        }
    }

    public class ConcreteStateB : IState
    {
        private Context mContext;
        public ConcreteStateB(Context context)
        {
            mContext = context;
            Debug.Log("Init ConcreteStatesB");
        }
        public void Handle(int arg)
        {
            Debug.Log("ConcreteStateB : " + arg);
            if (arg <= 10)
            {
                //转换到A
                mContext.SetState(new ConcreteStatesA(mContext));
            }

        }
    }
}