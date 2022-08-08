    using System.Collections;
using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using ProtoBuf;
    using UnityEngine;

public class ProtoBufferHelpler
    {
        //对象序列化成序列化成文件
        public static string Serialize<T>(T t)
        {
            //MemoryStream继承了IDisposable接口，所以才能被using自动释放
            //using 的作用为使用完之后就释放流对象
            using (MemoryStream ms = new MemoryStream())
            {
                //使用protobuf程序集内置方法将对象t序列化到ms中
                Serializer.Serialize<T>(ms, t);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        //根据字符串反序列化成对象
        public static T DeSerialize<T>(string content)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                T t = Serializer.Deserialize<T>(ms);
                return t;
            }
        }
    }  