using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace NSC.Models
{
    public static class  ExceptionHandler
    {
        //log error into file
        public static void HandleError(string errorMsg)
        {
            var filePath = HttpContext.Current.Server.MapPath("~/log.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"DateTime: {DateTime.Now} - Error: {errorMsg}");
            }
        }
    }
}