using UnityEngine;
using ROSBridge;
using ROS.std_msgs;

public class Main : MonoBehaviour 
{
  
  void Start() {
   
    ros = new ROSBridgeConnection ("ws://localhost", 9090);

    ros.AddSubscriber (typeof(Subscriber));
    ros.AddPublisher (typeof(Publisher));

    ros.Connect ();
  }
  
  
  void OnApplicationQuit() {
    if(ros!=null) {
      Debug.Log("Disconnect");
      ros.Disconnect ();
    }
  }

  void Update () 
  {
    ros.Render ();
    Float32 msg = new Float32(100); 
    // Debug.Log(Publisher.GetMessageTopic());
ros.Publish(Publisher.GetMessageTopic(), msg);

  }

  private ROSBridgeConnection ros = null;
  
}
