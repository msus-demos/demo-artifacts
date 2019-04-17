# Introduction 
A Demo project that publishes a nuget package to Azure Artifacts

### Projects

This demo includes one project.  A single C# .NET Standard library which produces a class of randomly generated dummy data to be used in other projects.

### Versioning

Artifacts produced by this demo are versioned with a tool called [GitVersion](https://github.com/GitTools/GitVersion), which derives the approprate [Semantic Version](http://semver.org) number to assign to both the binaries and builds within Azure DevOps.
