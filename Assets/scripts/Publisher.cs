using ROSBridge;
using SimpleJSON;
using ROS.std_msgs;
using UnityEngine;

public class Publisher: ROSBridgePublisher 
{

  // The following three functions are important
  public static string GetMessageTopic() 
  {
    return "/chatter";
  }

  public static string GetMessageType() 
  {
      return "std_msgs/Float32";
  }

  // public static string ToYAMLString(StringMsg msg) 
  // {
  //   return msg.ToYAMLString();
  // }

  // public new static StringMsg ParseMessage(JSONNode msg) 
  // {
  //   return new StringMsg(msg);
  // }    
}