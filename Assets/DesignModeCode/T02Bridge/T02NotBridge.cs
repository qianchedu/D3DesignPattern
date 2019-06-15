/***********************************************
    *ProjectsName:          D3DesignPattern
    *Copyright(C) 2017 by   笑笑科技公司  
    *All rights reserved. 
    *FileName:              T02NotBridge.cs 
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

namespace Red.NotBridge
{
	public class T02NotBridge : MonoBehaviour
	{
        // Start is called before the first frame update
        void Start()
        {
            Sphere sphere = new Sphere();
            sphere.Draw();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }



    public class Sphere
    {
        public string name = "Sphere";

        public OpenGL openGL = new OpenGL();

        public void Draw()
        {
            openGL.Render(name);
        }
    }


    public class Cube
    {
        public string name = "Cube";

        public OpenGL openGL = new OpenGL();

        public void Draw()
        {
            openGL.Render(name);
        }
    }

    public class Capsule
    {
        public string name = "Capsule";

        public OpenGL openGL = new OpenGL();

        public void Draw()
        {
            openGL.Render(name);
        }
    }

    public class OpenGL
    {
        public void Render(string name)
        {
            Debug.Log("OpenGL绘制了 ： " + name);
        }
    }


    public class DirectX
    {
        public void Render(string name)
        {
            Debug.Log("DirectX绘制了 ： " + name);
        }
    }



}