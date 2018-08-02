using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class UInt64 : ROSBridgeMsg {
			private ulong _data;
			
			public UInt64(JSONNode msg) {
				_data = Convert.ToUInt64(msg["data"]);
			}
			
			public UInt64(byte data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/UInt64";
			}
			
			public ulong GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "UInt64 [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{\"data\" : "+ _data.ToString() + "}";
			}
		}
	}
}