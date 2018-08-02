using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;
using ROSBridge;

namespace ROS {
	namespace std_msgs {
		public class Empty : ROSBridgeMsg {
			
			public Empty(JSONNode msg) {}
			
			public Empty() {}
			
			public static string GetMessageType() 
			{
				return "std_msgs/Empty";
			}
			
			public override string ToString() 
			{
				return "Empty []";
			}
			
			public override string ToYAMLString() 
			{
				return "{}";
			}
		}
	}
}