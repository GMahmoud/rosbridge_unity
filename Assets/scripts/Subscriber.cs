using ROSBridge;
using UnityEngine;
using SimpleJSON;
using ROS.std_msgs;

public class Subscriber : ROSBridgeSubscriber<UInt64> 
{
  public new static string GetMessageTopic() 
  {
    return "/listener";
  }

  public new static string GetMessageType() 
  {
    return "std_msgs/UInt64";
  }

  public new static UInt64 ParseMessage(JSONNode msg) 
  {
    return new UInt64 (msg);
  }

  public new static void CallBack(UInt64 msg) 
  {
    Debug.Log(msg.ToYAMLString());
    Debug.Log(msg.ToString());
  }
}