using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using UnityEngine;

namespace ROS {
	namespace std_msgs {
		public class Time : ROSBridgeMsg {
			private time _data;
			
			public Time(JSONNode msg) {
				_data = new time(msg["data"]);

			}
			
			public Time(time data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Time";
			}
			
			public time GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Time [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{data : "+ _data.ToYAMLString() + "}";
			}
		}
	}
}