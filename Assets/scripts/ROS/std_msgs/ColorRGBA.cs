using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;
using ROSBridge;

namespace ROS {
	namespace std_msgs {
		public class ColorRGBA : ROSBridgeMsg {
			private float _r;
			private float _g;
			private float _b;
			private float _a;
			
			public ColorRGBA(JSONNode msg) {
				_r = float.Parse(msg["r"]);
				_g = float.Parse(msg["g"]);
				_b = float.Parse(msg["b"]);
				_a = float.Parse(msg["a"]);
			}
			
			public ColorRGBA(float r, float g, float b, float a) {
				_r = r;
				_g = g;
				_b = b;
				_a = a;
			}
			
			public static string GetMessageType() {
				return "std_msgs/ColorRGBA";
			}
			
			public float GetR() {
				return _r;
			}
			
			public float GetG() {
				return _g;
			}

			public float GetB() {
				return _b;
			}
			
			public float GetA() {
				return _a;
			}

			public override string ToString() {
				return "ColorRGBA [r=" + _r.ToString() + ",g=" + _g.ToString() + ",b=" + _b.ToString() + ",a=" + _r.ToString() + "]";
			}
			
			public override string ToYAMLString() {
				return "{r: " + _r.ToString() + ",g: " + _g.ToString() + ",b: " + _b.ToString() + ",a: " + _r.ToString() + "}";
			}
		}
	}
}