# APITestFramework


##### Resources
- [purgomalum](https://www.purgomalum.com/)
- [SpecFlow Project Template with dotnet new](https://specflow.org/blog/specflow-project-template-with-dotnet-new/)
- [SpecFlow context injection](https://docs.specflow.org/projects/specflow/en/latest/Bindings/Context-Injection.html)
- [RestSharp](https://restsharp.dev/)


### Run locally (Mac/Windows)

##### Build it
```dotnet build```

##### Run it
```dotnet test```


### Run tests in [Docker](https://www.docker.com/)

##### Build it
```docker build -t test-box .```

##### Run it
```docker run test-box```


#### MSbuild error on Mac

Issue: The below error when building the solution.
```
.nuget/packages/specflow.tools.msbuild.generation/3.1.80/build/SpecFlow.Tools.MsBuild.Generation.targets(93,5): error MSB4018: The "GenerateFeatureFileCodeBehindTask" task failed unexpectedly.
```
Fix: Run the below in Terminal.
```
export MSBUILDSINGLELOADCONTEXT=1
```