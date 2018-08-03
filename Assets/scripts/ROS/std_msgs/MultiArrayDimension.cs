using System.Collections;
using System.Text;
using SimpleJSON;
using UnityEngine;
using ROSBridge;
using System;

namespace ROS {
	namespace std_msgs {
		public class MultiArrayDimension : ROSBridgeMsg 
		{
			private string _label;
			private uint _size;
			private uint _stride;
			
			public MultiArrayDimension(JSONNode msg) 
			{
				_label = msg["label"];
				_size = Convert.ToUInt32(msg["size"]);
				_stride = Convert.ToUInt32(msg["stride"]);
			}
			
			public MultiArrayDimension(string label, uint size, uint stride) 
			{
				_label = label;
				_size = size;
				_stride = stride;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/MultiArrayDimension";
			}
			
			public string GetLabel() 
			{
				return _label;
			}
			
			public uint GetSize() 
			{
				return _size;
			}

			public uint GetStride() 
			{
				return _stride;
			}

			public override string ToString() 
			{
				return "MultiArrayDimension [label=\"" + _label + "\",size=" + _size.ToString() + ",stride=" + _stride.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				return "{label: \"" + _label + "\",size: " + _size.ToString() + ",stride: " + _stride.ToString() + "}";
			}
		}
	}
}