using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class Int64 : ROSBridgeMsg {
			private long _data;
			
			// public Int64(JSONNode msg) {
			// 	_data = Convert.ToInt64(msg["data"]);
			// }
			
			public Int64(byte data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Int64";
			}
			
			public long GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Int64 [data=" + _data .ToString()+ "]";
			}
			
			public override string ToYAMLString() {
				return "{data : "+ _data.ToString() + "}";
			}
		}
	}
}