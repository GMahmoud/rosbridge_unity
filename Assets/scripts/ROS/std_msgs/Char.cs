using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class Char : ROSBridgeMsg {
			private char _data;
			
			public Char(JSONNode msg) {
				_data = Convert.ToChar(msg["data"]);
			}
			
			public Char(char data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Char";
			}
			
			public char GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "String [data=" + _data + "]";
			}
			
			public override string ToYAMLString() {
				return "{data : \"" + _data + "\"}";
			}
		}
	}
}