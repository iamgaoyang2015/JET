using MyFirstMvc.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMvc.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            var toList = new[]
            {
                new { LocaId = "a",SkuId = "sku01"},
                new { LocaId = "b",SkuId = "sku01"},
                new { LocaId = "c",SkuId = "sku01"},
                new { LocaId = "d",SkuId = "sku01"},
            };
            var resultList = new[]
           {
                new { LocaId = "a",SkuId = "sku01"},
               
                new { LocaId = "c",SkuId = "sku01"},
           
            };

            var newList = toList.Where(to => !resultList.Any(result => to.LocaId == result.LocaId));
            int[] A = new int[9];
            for (int i = 0; i < 9; i++)
            {
                A[i] = i + 1;
            }
            this.getSubSet(A, 8, 0);
            var model = new Model1();
            model.MyEntities.Where(s => s.name == "3");
            return View();
        }

        private List<int> list = new List<int>();
        public int getSum(List<int> list) {
            int sum = 0;
            foreach(int a in list) {
                sum += a;
            }
            return sum;
        }

        /*
 * 参数step：选中数组A中第step个元素为子集元素
 * 函数功能：求取数组A中一个子集元素，其相加之和等于m
 */
        public void getSubSet(int[] A, int m, int step)
        {
            while (step < A.Length)
            {
                list.Add(A[step]);   //递归执行语句，向数组链表中添加一个元素
                if (getSum(list) == m)   //链表中元素和等于m
                    Console.WriteLine(list);
                step++;
                getSubSet(A, m, step);
                list.RemoveAt(list.Count() - 1);   //回溯执行语句，删除数组链表最后一个元素
            }
        }
    }
}