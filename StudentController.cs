using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace SampleSecureWeb.Controllers; 

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
        
    }

     public IActionResult Create()
    {
        return View();
    }
     public IActionResult Edit()
    {
        return View();
    }
     public IActionResult Delete()
    {
        return View();
    }
}