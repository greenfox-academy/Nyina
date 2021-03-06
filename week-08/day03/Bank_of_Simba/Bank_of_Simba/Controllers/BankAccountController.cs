﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bank_of_Simba.Model;
using Bank_of_Simba.ViewModel;

namespace Bank_of_Simba.Controllers
{
    [Route("")]
    //A Controller egy előre definiált osztály, amiből származtatni kell a sajátomat
    public class BankAccountController : Controller
    {
        //Az osztály 1 példányát hozom létre és ezt adom a View-hoz (lentebb)
        //public static BankAccountViewModel bankAccountVM = new BankAccountViewModel();
        private BankAccountViewModel bankAccountVM;

        public BankAccountController(BankAccountViewModel bankAccountVM)
        {
            this.bankAccountVM = bankAccountVM;
        }

        [HttpGet("Simba")]
        public IActionResult Index()
        {
            return View(bankAccountVM);
        }

        [HttpPost("Simba")]
        public IActionResult AddBalance()
        {
            //A view modellen belül van a lista és az in utánival tudok rá hivatkozni
            //(a fenti példány.BankAccountViewModell-ben szereplő lista neve:
            foreach (var bankAccListElement in bankAccountVM.BankAccountList)
            {
                if (bankAccListElement.Owner.Equals("King"))
                {
                    bankAccListElement.Balance += 100;
                }
                else
                {
                    bankAccListElement.Balance += 10;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost("add")]
        //Az objektum paraméterként való megjelenítésével a form mezőit automatán értéket ad a megfelelő propertyknek
        public IActionResult AddPerson(BankAccount bankAccount)
        {
            bankAccountVM.BankAccountList.Add(bankAccount);
            return RedirectToAction("Index");
        }

    }
}
