using UnityEngine;
using System.Collections;
using Net;

public class NetworkClient : MonoBehaviour
{

    void Start()
    {
        ClientSocket mSocket = new ClientSocket();
        mSocket.ConnectServer("127.0.0.1", 8088);
        mSocket.SendMessage("服务器傻逼！");
    }

    // Update is called once per frame  
    void Update()
    {

    }
}
