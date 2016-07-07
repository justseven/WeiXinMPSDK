﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Senparc.Weixin.QY.Helpers
{
	public class SHA1UtilHelper
	{
		/// <summary>
		/// 签名算法
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string GetSha1(string str)
		{
			//建立SHA1对象
			SHA1 sha = SHA1.Create();
			//将mystr转换成byte[] 
			ASCIIEncoding enc = new ASCIIEncoding();
			byte[] dataToHash = enc.GetBytes(str);
			//Hash运算
			byte[] dataHashed = sha.ComputeHash(dataToHash);
			//将运算结果转换成string
			string hash = BitConverter.ToString(dataHashed).Replace("-", "");
			return hash;
		}
	}
}