/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              T02Bridge.cs 
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

namespace Red.Bridge
{
    public class T02Bridge : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            IRenderEngine renderEngine = new DirectX();
            Sphere sphere = new Sphere(renderEngine);
            sphere.Draw();


            //ICharacter character = new SoldierCaptain();
            //WeaponRifle gun = new WeaponRifle();
            //character.rifle = gun;
            //character.Attack(Vector3.one);

            ICharacter character = new SoldierCaptain();
            character.weapon = new WeaponGun();
            character.Attack(Vector3.one);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    /// <summary>
    /// 图形
    /// </summary>
    public class IShape
    {
        public string name;
        public IRenderEngine renderEngine;

        public IShape(IRenderEngine renderEngine)
        {
            this.renderEngine = renderEngine;
        }

        public void Draw()
        {
            renderEngine.Draw(name);
        }
    }

    /// <summary>
    /// 渲染引擎
    /// </summary>
    public abstract class IRenderEngine
    {
        public abstract void Draw(string name);
    }

    public class Sphere:IShape
    {
        public Sphere(IRenderEngine renderEngine):base(renderEngine)
        {
            name = "Sphere";
        }

    }


    public class Cube:IShape
    {
        public Cube(IRenderEngine renderEngine) : base(renderEngine)
        {
            name = "Cube";
        }
    }

    public class Capsule:IShape
    {
        public Capsule(IRenderEngine renderEngine) : base(renderEngine)
        {
            name = "Capsule";
        }

    }

    public class OpenGL: IRenderEngine
    {
        public override void Draw(string name)
        {
            Debug.Log("OpenGL绘制了 ： " + name);
        }

        //public void Render(string name)
        //{
        //    Debug.Log("OpenGL绘制了 ： " + name);
        //}
    }


    public class DirectX: IRenderEngine
    {
        public override void Draw(string name)
        {
            Debug.Log("DirectX绘制了 ： " + name);
        }
    }



}