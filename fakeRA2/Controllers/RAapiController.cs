using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fakeRA2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RAapiController : ControllerBase
    {

        [HttpGet]
        [Route("live")]
        public string Live()
        {
            var student = new Student
            {
                Name = "顏雅茹1234",
                Age = 20
            };
            var options = new JsonSerializerOptions
            {
                //將 JSON 文字加上縮排
                WriteIndented = true,
                //Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                //允許基本拉丁英文及中日韓文字維持原字元
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.CjkUnifiedIdeographs)
            };
            var json = JsonSerializer.Serialize<Student>(student, options);

            //var json = JsonSerializer.SerializeToUtf8Bytes<Student>(student, options);
            //var json_base64Result = Convert.ToBase64String(json);

            return json;
        }

        [HttpGet]
        [Route("test1")]
        public string Test1()
        {
            return "test1";
        }

        }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
