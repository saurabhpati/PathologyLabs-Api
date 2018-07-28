﻿namespace PathologyLabs.Domain.Core
{
    public class PathologyTest : Entity
    {
        public string Name { get; set; }

        public TestType Type { get; set; }
    }

    public class TestType : Entity<short>
    {
        public string Value { get; set; }
    }
}