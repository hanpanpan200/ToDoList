using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utility;

namespace ToDoListDemo.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        //
        // GET: /Account/
        [HttpPost]
        public ActionResult LoginToSystem(string argUserName,string argPwd)
        {
            
            var ajaxResult = new AjaxResult();
            if (string.IsNullOrEmpty(argUserName) || string.IsNullOrEmpty(argPwd))
            {
                ajaxResult.Success = false;
                ajaxResult.Message = "用户名,密码不能为空!";
            }
            else
            {
                var repository = new DataRepository();
                if (!repository.Login(argUserName, argPwd))
                {
                    ajaxResult.Success = false;
                    ajaxResult.Message = "用户名或密码错误!";
                }
                else
                {
                    ajaxResult.Success = true;
                }
            }
            return Json(ajaxResult);
        }

    }
}
