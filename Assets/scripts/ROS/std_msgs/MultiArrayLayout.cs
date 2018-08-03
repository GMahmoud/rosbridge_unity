using System.Collections;
using System.Text;
using SimpleJSON;
using ROSBridge;
using System;
using System.Collections.Generic;

using UnityEngine;

namespace ROS {
	namespace std_msgs {
		public class MultiArrayLayout : ROSBridgeMsg {
			private List<MultiArrayDimension> _dim;
			private uint _data_offset;
			
			public MultiArrayLayout(JSONNode msg) 
			{
				JSONArray dim = (JSONArray) msg["dim"];
				MultiArrayDimension element ; 
				List<MultiArrayDimension> list = new List<MultiArrayDimension> ();
				for(int i=0; i<dim.Count; i++)
				{ 
					element = new MultiArrayDimension(dim[i]);
					list.Add(element);
				}
				_dim = list;
				_data_offset = Convert.ToUInt32(msg["data_offset"]);
			}
			
			public MultiArrayLayout(List<MultiArrayDimension> dim, uint data_offset)
			{
			 	_dim = dim;
				 _data_offset = data_offset;
			}
			
			public static string GetMessageType() 
			{
				return "std_msgs/MultiArrayLayout";
			}
			
			public List<MultiArrayDimension> GetDim() 
			{
				return _dim;
			}

			public uint GetDataOffset() 
			{
				return _data_offset;
			}
			
			public override string ToString() 
			{
				string str;
                str="[";
				for(int i=0; i<_dim.Count; i++)
				{ 
					str = str + _dim[i].ToString();
					if(i != _dim.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";

				return "MultiArrayLayout [dim=" + str + ",data_offset=" + _data_offset.ToString() + "]";
			}
			
			public override string ToYAMLString() 
			{
				string str;
                str="[";
				for(int i=0; i<_dim.Count; i++)
				{ 
					str = str + _dim[i].ToYAMLString();
					if(i != _dim.Count-1)
					{
						str = str + ",";
					}
				}
				str = str + "]";
				
				return "{dim : " + str + ",data_offset : " + _data_offset.ToString() + "}";
			}
		}
	}
}