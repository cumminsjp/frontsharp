﻿using FrontSharp.Interfaces;
using FrontSharp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontSharp.Logic
{
    public class TagLogic : BaseLogic, ITagLogic
    {
        public TagLogic(FrontSharpClient client)
            : base(client)
        {
            _baseRoute = "tags";
        }

        public Tag CreateTag(string name)
        {
            var request = base.BuildRequest(Method.POST);

            var obj = new { name = name};

            return _client.Execute<Tag>(request, obj);
        }
    }
}
