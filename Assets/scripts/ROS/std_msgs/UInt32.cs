using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class UInt32 : ROSBridgeMsg {
			private uint _data;
			
			public UInt32(JSONNode msg) {
				_data = Convert.ToUInt32(msg["data"]);
			}
			
			public UInt32(byte data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/UInt32";
			}
			
			public uint GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "UInt32 [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{\"data\" : "+ _data.ToString() + "}";
			}
		}
	}
}