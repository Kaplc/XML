using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class test : MonoBehaviour
{
    public SerializerDictionary<int, string> serDic = new SerializerDictionary<int, string>();
    public SerializerDictionary<int, string> resSerDic = new SerializerDictionary<int, string>();

    // Start is called before the first frame update
    void Start()
    {
        // serDic.Add(1, "123");
        // serDic.Add(2, "234");

        // XmlSerializer ser = new XmlSerializer(typeof(SerializerDictionary<int, string>));
        //
        // string path = Application.persistentDataPath + "/test1.xml";
        //
        // // using (StreamWriter fileStream = new StreamWriter(path))
        // // {
        // //     ser.Serialize(fileStream, serDic);
        // // }
        //
        // using (StreamReader fileStream = new StreamReader(path))
        // {
        //     resSerDic = ser.Deserialize(fileStream) as SerializerDictionary<int, string>;
        // }
        //
        // print(path);

        resSerDic = XmlDataManager.Instance.Load(resSerDic.GetType(), "test1.xml") as SerializerDictionary<int, string>;
    }
}
