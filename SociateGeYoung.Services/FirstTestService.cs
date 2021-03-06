﻿using System;
using System.Data.Entity.Migrations;
using System.Linq;
using AutoMapper;
using Microsoft.AspNet.Identity;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Services.Interfaces;

namespace SociateGeYoung.Services
{
    public class FirstTestService : Service,IFirstTestService
    {
        private FirstTest _test;
        public bool IsThereUser { get; set; }
        public string CodeForUser { get; private set; }
        private string GenerateCode()
        {
            string code = null;
            if (!IsThereUser)
            {
                code = Guid.NewGuid().ToString();
            }
            return code;
        }
        public void AddTest(FirstTestBM bind)
        {
            _test = Mapper.Map<FirstTestBM, FirstTest>(bind);
            ApplicationUser user = this.UserManager.FindById(bind.UserId);
            _test.ApplicationUser = user;
            _test.CodeForUser = this.GenerateCode();
            this.Context.FirstTests.Add(_test);
            this.Context.SaveChanges();
            this.CodeForUser = _test.CodeForUser;
        }

        public string Calculator()
        {
            int style1 = 0;
            int style2 = 0;
            int style3 = 0;
            int style4 = 0;
            string result = "";

            if (_test.Quest1)
            {
                style1++;
            }
            if (_test.Quest8)
            {
                style1++;
            }
            if (_test.Quest9)
            {
                style1++;
            }
            if (_test.Quest13)
            {
                style1++;
            }
            if (_test.Quest17)
            {
                style1++;
            }
            if (_test.Quest24)
            {
                style1++;
            }
            if (_test.Quest26)
            {
                style1++;
            }
            if (_test.Quest31)
            {
                style1++;
            }
            if (_test.Quest33)
            {
                style1++;
            }
            if (_test.Quest40)
            {
                style1++;
            }
            if (_test.Quest41)
            {
                style1++;
            }
            if (_test.Quest48)
            {
                style1++;
            }
            if (_test.Quest50)
            {
                style1++;
            }
            if (_test.Quest53)
            {
                style1++;
            }
            if (_test.Quest57)
            {
                style1++;
            }
            if (_test.Quest63)
            {
                style1++;
            }
            if (_test.Quest65)
            {
                style1++;
            }
            if (_test.Quest70)
            {
                style1++;
            }
            if (_test.Quest74)
            {
                style1++;
            }
            if (_test.Quest79)
            {
                style1++;
            }

            if (_test.Quest2)
            {
                style2++;
            }
            if (_test.Quest7)
            {
                style2++;
            }
            if (_test.Quest10)
            {
                style2++;
            }
            if (_test.Quest14)
            {
                style2++;
            }
            if (_test.Quest18)
            {
                style2++;
            }
            if (_test.Quest23)
            {
                style2++;
            }
            if (_test.Quest25)
            {
                style2++;
            }
            if (_test.Quest30)
            {
                style2++;
            }
            if (_test.Quest34)
            {
                style2++;
            }
            if (_test.Quest37)
            {
                style2++;
            }
            if (_test.Quest42)
            {
                style2++;
            }
            if (_test.Quest47)
            {
                style2++;
            }
            if (_test.Quest51)
            {
                style2++;
            }
            if (_test.Quest55)
            {
                style2++;
            }
            if (_test.Quest58)
            {
                style2++;
            }
            if (_test.Quest62)
            {
                style2++;
            }
            if (_test.Quest66)
            {
                style2++;
            }
            if (_test.Quest69)
            {
                style2++;
            }
            if (_test.Quest75)
            {
                style2++;
            }
            if (_test.Quest78)
            {
                style2++;
            }
            if (_test.Quest3)
            {
                style3++;
            }
            if (_test.Quest6)
            {
                style3++;
            }
            if (_test.Quest11)
            {
                style3++;
            }
            if (_test.Quest15)
            {
                style3++;
            }
            if (_test.Quest19)
            {
                style3++;
            }
            if (_test.Quest22)
            {
                style3++;
            }
            if (_test.Quest27)
            {
                style3++;
            }
            if (_test.Quest29)
            {
                style3++;
            }
            if (_test.Quest35)
            {
                style3++;
            }
            if (_test.Quest38)
            {
                style3++;
            }
            if (_test.Quest43)
            {
                style3++;
            }
            if (_test.Quest46)
            {
                style3++;
            }
            if (_test.Quest49)
            {
                style3++;
            }
            if (_test.Quest56)
            {
                style3++;
            }
            if (_test.Quest59)
            {
                style3++;
            }
            if (_test.Quest64)
            {
                style3++;
            }
            if (_test.Quest67)
            {
                style3++;
            }
            if (_test.Quest71)
            {
                style3++;
            }
            if (_test.Quest76)
            {
                style3++;
            }
            if (_test.Quest80)
            {
                style3++;
            }
            if (_test.Quest4)
            {
                style4++;
            }
            if (_test.Quest5)
            {
                style4++;
            }
            if (_test.Quest12)
            {
                style4++;
            }
            if (_test.Quest16)
            {
                style4++;
            }
            if (_test.Quest20)
            {
                style4++;
            }
            if (_test.Quest21)
            {
                style4++;
            }
            if (_test.Quest28)
            {
                style4++;
            }
            if (_test.Quest32)
            {
                style4++;
            }
            if (_test.Quest36)
            {
                style4++;
            }
            if (_test.Quest39)
            {
                style4++;
            }
            if (_test.Quest44)
            {
                style4++;
            }
            if (_test.Quest45)
            {
                style4++;
            }
            if (_test.Quest52)
            {
                style4++;
            }
            if (_test.Quest54)
            {
                style4++;
            }
            if (_test.Quest60)
            {
                style4++;
            }
            if (_test.Quest61)
            {
                style4++;
            }
            if (_test.Quest68)
            {
                style4++;
            }
            if (_test.Quest72)
            {
                style4++;
            }
            if (_test.Quest73)
            {
                style4++;
            }
            if (_test.Quest77)
            {
                style4++;
            }

            if (style1 >= style2 && style1 >= style3 && style1 >= style4)
            {
                result = "style1";
            }
            if (style2 > style1 && style2 >= style3 && style2 >= style4)
            {
                result = "style2";
            }
            if (style3 > style1 && style3 > style2 && style3 >= style4)
            {
                result = "style3";
            }
            if (style4 > style1 && style4 > style2 && style4 > style3)
            {
                result = "style4";
            }
            return result;
        }

        public void AddTestCodeForUser(AddTestCodeBm bind)
        {
            FirstTest test = this.Context.FirstTests.FirstOrDefault(x => x.CodeForUser == bind.TestCode);
            ApplicationUser user = this.UserManager.FindById(bind.UserId);
            test.ApplicationUser = user;
            this.Context.FirstTests.AddOrUpdate(test);
            this.Context.SaveChanges();
        }
    }
}