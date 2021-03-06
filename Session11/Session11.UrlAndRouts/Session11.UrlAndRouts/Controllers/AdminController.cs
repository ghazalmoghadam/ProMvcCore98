﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session11.UrlAndRouts.Models;

namespace Session11.UrlAndRouts.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            return View("Result",
                new Result
                {
                    Controller = nameof(AdminController),
                    Action = nameof(Index)
                });
        }

        public ViewResult List()
        {
            return View("Result",
                new Result
                {
                    Controller = nameof(AdminController),
                    Action = nameof(List)
                });
        }
    }
}