﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using DSCore.Models;

namespace DSCore.Utils
{
    public class InheritController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://localhost:3080/api");
            request.AllowAutoRedirect = false;
            //request.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                var response = request.GetResponse();
                // TODO: make sure that the json result is there
            }
            catch (WebException ex)
            {
                context.Result = View("NoServer", new PageException() { Exception = ex });
            }

            base.OnActionExecuting(context);
        }
    }
}