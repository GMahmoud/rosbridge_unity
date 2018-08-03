using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using UnityEngine;

namespace ROS {
	namespace std_msgs {
		public class Duration : ROSBridgeMsg {
			private time _data;
			
			public Duration(JSONNode msg) {
				_data = new time(msg["data"]);

			}
			
			public Duration(time data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Duration";
			}
			
			public time GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Duration [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{data : "+ _data.ToYAMLString() + "}";
			}
		}
	}
}