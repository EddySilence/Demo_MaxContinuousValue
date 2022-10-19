using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region 題目
			/*題目：陣列裡只會有 0, 3, 找出連續3的總和,例如
				   {0,3,3,0,0,3,3,3} => 9
				   {0,3,3,0,0,3,0,3,0,3} => 6
				   {0,3,0,0} => 3
			*/
			#endregion

			int[] ints = new int[] { 0, 3, 3, 0, 0, 3, 0, 3, 0, 3 };
			int count = 0;//當前累積
			int number = 0;//累積最高
			int result = 0;//總和
			for (int i = 0; i < ints.Length; i++)
			{
				if (ints[i] == 3)
				{
					count++;
				}
				else
				{
					count = 0;
				}
				if (count > number)
				{
					number = count;
				}
			}
			result = number * 3;
			Console.WriteLine(result);


		}
	}
}
