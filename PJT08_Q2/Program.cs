using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PJT08_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                특정 문자열의 위치 찾는 메소드->문자열.IndexOf(찾고자하는 문자열)
                부분 문자열을 추출하는 메소드 -> 문자열.Substring(위치, 길이)
                문자열을 분리하는 메소드->문자열.Split(자르고자하는 문자)
            */
            string url = "https://koreaisacademy.com/program/index.html?subject=csharp&time=1900#content";
            //url = "ftp://naver.com/file/favicpm.ico?size=256x256#download";

            int protocolEnd = url.IndexOf("://");
            string protocol = url.Substring(0, protocolEnd);
            Console.WriteLine("프로토콜 : " + protocol);

            string newUrl = url.Substring(protocolEnd + 3);
            int domainEnd = newUrl.IndexOf("/");
            string domain = newUrl.Substring(0, domainEnd);
            Console.WriteLine("도메인 : " + domain);

            int pathEnd = newUrl.IndexOf("?");
            string path = newUrl.Substring(domainEnd +1, pathEnd - domainEnd - 1);
            Console.WriteLine("경로 : " + path);

            int parameterEnd = newUrl.IndexOf("#");
            string parameter = newUrl.Substring(pathEnd, parameterEnd - pathEnd);
            Console.WriteLine("파라미터 : " + parameter);

            string fragment = newUrl.Substring(parameterEnd);
            Console.WriteLine("프래그먼트 : " + fragment);
        }
    }
}
