using ROSBridge;
using UnityEngine;
using SimpleJSON;
using ROS.std_msgs;

public class Subscriber : ROSBridgeSubscriber {
 
  public new static string GetMessageTopic() {
    return "/listener";
  }

  public new static string GetMessageType() {
    return "std_msgs/Float32";
  }

  public new static Float32Msg ParseMessage(JSONNode msg) {
    return new Float32Msg (msg);
  }

  public new static void CallBack(ROSBridgeMsg msg) {

    Float32Msg float_msg = (Float32Msg)msg;
    Debug.Log(float_msg.GetData());
  }
}