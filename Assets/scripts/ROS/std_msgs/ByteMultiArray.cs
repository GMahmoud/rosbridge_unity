using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ROS {
	namespace std_msgs {
		public class ByteMultiArray : ROSBridgeMsg {
			private MultiArrayLayout _layout;
			private List<byte> _data;
			
			public ByteMultiArray(JSONNode msg) 
			{
				JSONArray data = (JSONArray) msg["data"];
				List<byte> list = new List<byte> ();
				for(int i=0; i<data.Count; i++)
				{ 
					list.Add(Convert.ToByte(data[i]));
				}
				_data = list;
				_layout = new MultiArrayLayout(msg["layout"]);
			}
			
			public ByteMultiArray(MultiArrayLayout layout, List<byte> data)
			{
			 	_layout = layout;
				_data = data;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/ByteMultiArray";
			}
			
			public MultiArrayLayout GetLayout() 
			{
				return _layout;
			}

			public List<byte> GetData() 
			{
				return _data;
			}
			
			public override string ToString() 
			{
				string str;
                str="[";
				for(int i=0; i<_data.Count; i++)
				{ 
					str = str + _data[i].ToString();
					if(i != _data.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";

				return "ByteMultiArray [layout=" + _layout.ToString() + ",data=" + str + "]";
			}
			
			public override string ToYAMLString() 
			{
				string str;
                str="[";
				for(int i=0; i<_data.Count; i++)
				{ 
					str = str + _data[i].ToString();
					if(i != _data.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";
				
				return "{layout : " + _layout.ToYAMLString() + ",data : " +str + "}";
			}
		}
	}
}