using System.Collections.Generic;
using GitVersion;

namespace GitVersionCore.Tests
{
    using System;

    public class TestEnvironment : IEnvironment
    {
        private readonly IDictionary<string, string> map;

        public TestEnvironment()
        {
            map = new Dictionary<string, string>();
        }

        public string GetEnvironmentVariable(string variableName)
        {
            return map.TryGetValue(variableName, out var val) ? val : null;
        }

        public void SetEnvironmentVariable(string variableName, string value)
        {
            map[variableName] = value;
        }

        public void SetEnvironmentVariable(string variableName, string value, EnvironmentVariableTarget target)
        {
            SetEnvironmentVariable(variableName, value);
        }
    }
}
