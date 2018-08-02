using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;
using ROSBridge;

namespace ROS {
	namespace std_msgs {
		public class Float64 : ROSBridgeMsg {
			private double _data;
			
			public Float64(JSONNode msg) {
				_data = double.Parse(msg["data"]);
			}
			
			public Float64(double data) {
				_data = data;
			}
			
			public static string GetMessageType() {
				return "std_msgs/Float64";
			}
			
			public double GetData() {
				return _data;
			}
			
			public override string ToString() {
				return "Float64 [data=" + _data.ToString() + "]";
			}
			
			public override string ToYAMLString() {
				return "{\"data\" : " + _data.ToString() + "}";
			}
		}
	}
}