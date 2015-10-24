using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldNomadsGroup.Models;

namespace WorldNomadsGroup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(NumberModel key)
        {
            if (ModelState.IsValid)
            {
                var text = GetRet(key.NumberVal);
                ViewBag.Text = text;
                return View();
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public List<int> ReturnAllNumbers(int key)
        {
            var outp = new List<int>();
            int counter = 0;
            while (counter < key)
            {
                counter++;
                outp.Add(counter);
            }
            return outp;
        }
        public List<int> ReturnOddNumbers(int key)
        {
            var outp = new List<int>();
            int counter = 0;
            //string output = "";
            while (counter < key)
            {                
                counter++;
                if (counter % 2 == 1)
                { 
                    //output = output + " " + counter; 
                    outp.Add(counter);
                }
            }
            return outp;
        }
        public List<int> ReturnEvenNumbers(int key)
        {
            var outp = new List<int>();
            int counter = 0;
            //string output = "";
            while (counter < key)
            {
                counter++;
                if (counter % 2 == 0)
                { 
                    //output = output + " " + counter;
                    outp.Add(counter);
                }
            }
            return outp;
        }
        public List<string> ReturnComplexSequence(int key)
        {
            int counter = 0;
            //string output = "";
            var outp = new List<string>();
            while (counter < key)
            {
                counter++;
                if ((counter % 5 == 0) && (counter % 3 == 0))
                {
                    //output = output + " " + "Z";
                    outp.Add("Z");
                }
                else if (counter % 5 == 0)
                {
                    //output = output + " " + "E";
                    outp.Add("E");
                }
                else if (counter % 3 == 0)
                {
                    //output = output + " " + "C";
                    outp.Add("C");
                }
                else
                { outp.Add(counter.ToString()); }
            }
            return outp;
        }
        public List<int> Fibonacci(int key)
        {
            var outp = new List<int>();
            //assume key>=1
            outp.Add(1);
            if(key>1){
                outp.Add(1);
                if (key == 2)
                {
                    return outp;
                }
                //second last not last
                while((outp[outp.Count-1]+outp[outp.Count-2])<key+1)
                {
                    var tmp = outp.Count;
                    outp.Add(outp[tmp - 1] + outp[tmp - 2]);
                }
            }
            return outp;
        }
        public string OutputList(List<int> input)
        {
            var output = "";
            foreach(var item in input)
            {
                output = output + item + " ";
            }
            return output;
        }
        public string OutputListS(List<string> input)
        {
            var output = "";
            foreach (var item in input)
            {
                output = output + item + " ";
            }
            return output;
        }
        public string GetRet(int key)
        {
            var grandoutput = "";
            grandoutput+=OutputList(ReturnAllNumbers(key))+"<br />";
            grandoutput += OutputList(ReturnEvenNumbers(key)) + "<br />";
            grandoutput += OutputList(ReturnOddNumbers(key)) + "<br />";
            grandoutput += OutputListS(ReturnComplexSequence(key)) + "<br />";
            grandoutput += OutputList(Fibonacci(key)) + "<br />";
            return grandoutput;
        }
    }
}