using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 网络爬虫
{
    class Program
    {
        static void Main(string[] args)
        {
            //网络爬虫在信息检索与处理中有很大作用，是搜集网络信息的重要工具
            //爬虫的工作流程：
            //if (基地址加入未下载集合)
            //{
            //    if (未下载集合为空)
            //    {
            //        Console.WriteLine("下载完成");
            //    }
            //    else
            //    { 
            //        1、取出一个链接并加入已下载
            //        2、发送http请求
            //        3、接受服务器响应信息
            //        4、接收数据
            //        5、保存页面文件
            //        6、获取页面链接
            //        7、过滤链接
            //        8、加入未下载集合
            //        9、判断未下载集合是否为空(返回上一个判断)
            //    }
            //}
            //待下载与已下载集合：为了防止重复下载定义两个集合存放将要下载和已经下载的URL,使用有序列表Dictionary<string,ing>保存(url字符串，url深度)
            //提高效率同事下载多个url资源，做法就是采用异步请求
        }
    }
}
