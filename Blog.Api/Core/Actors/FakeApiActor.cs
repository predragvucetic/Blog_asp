﻿using Blog.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Core.Actors
{
    public class FakeApiActor : IApplicationActor
    {
        public int Id => 1;

        public string Identity => "Test Api Actor";

        public IEnumerable<int> AllowedUseCases => new List<int> { 1 };
    }

    public class FakeAdminApiActor : IApplicationActor
    {
        public int Id => 2;

        public string Identity => "Fake Admin Api Actor";

        public IEnumerable<int> AllowedUseCases => Enumerable.Range(1, 100);
    }
}
