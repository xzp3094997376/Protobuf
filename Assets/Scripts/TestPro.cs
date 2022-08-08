using UnityEngine;
using System.IO;
using ProtoBuf;
using Test.Person;


public class TestPro : MonoBehaviour
{
    void Start()
    {
        //Person person1 = new Person() { Name = "小明同学", Age = 18 };

        //序列化

        //string testInfo = ProtoBufferHelpler.Serialize<Person>(person1);

        //print("testInfo" + testInfo);

        ////反序列化
        //Person person2 = ProtoBufferHelpler.DeSerialize<Person>(testInfo);

        //print("person2" + person2.Name + "  " + person2.Age);


        person per=new person() { Name = "小明同学", Age = 19 }; ;
        string testInfo = ProtoBufferHelpler.Serialize<person>(per);

        print("testInfo" + testInfo);

        //反序列化
        person person2 = ProtoBufferHelpler.DeSerialize<person>(testInfo);

        print("person  :" + person2.Name + "  " + person2.Age);

    }
}


//定义一个序列化与反序列化对象，当然也可以是用protogen工具来实现

[ProtoContract]
class Person
{
    [ProtoMember(1)]
    public string Name { get; set; }
    [ProtoMember(2)]
    public int Age { get; set; }
}