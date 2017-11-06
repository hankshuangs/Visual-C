using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;//新增命名空間

namespace ClsHash
{
    public class Class1
    {
        /// <summary>
        /// 雜湊加密
        /// MD5 訊息摘要5(Message Digest 5 , MD5)
        /// SHA1 安全雜湊演算法(Secure Hashing Algorithm , SHA1)
        /// </summary>
        /// <param name="enCrypType">"MD5"或"SHA1"</param>
        /// <param name="bufstring">欲進行加密字串</param>
        /// <returns>回傳加密字串</returns>
        public static string HashEncryption(string enCrypType, string bufstring)
        {
            //此法也可以
            //HashAlgorithm sha = new SHA1CryptoServiceProvider(); //雜湊大小160位元
            //HashAlgorithm md5 = new MD5CryptoServiceProvider();  //雜湊大小128位元

            //完整命名空間
            //System.Security.Cryptography.HashAlgorithm
            //System.Security.Cryptography.MD5 
            //System.Security.Cryptography.MD5CryptoServiceProvider(); 
            string msg = "";
            try
            {
                if (enCrypType == "MD5")
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] dataArray = Encoding.UTF8.GetBytes(bufstring);
                    byte[] result = md5.ComputeHash(dataArray);
                    foreach (var obj in result)
                    {
                        msg = msg + obj.ToString();
                    }
                    return msg;
                }
                else if (enCrypType == "SHA1")
                {
                    SHA1 sha1 = new SHA1CryptoServiceProvider();
                    byte[] dataArray = Encoding.UTF8.GetBytes(bufstring);
                    byte[] result = sha1.ComputeHash(dataArray);
                    foreach (var obj in result)
                    {
                        msg = msg + obj.ToString();
                    }
                    return msg;
                }
                else
                {
                    return "error:可能是加密型態錯誤";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }
    }
}
