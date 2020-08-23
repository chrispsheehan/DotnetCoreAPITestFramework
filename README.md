# APITestFramework

[Purgomalum](https://www.purgomalum.com/) is a simple, free RESTful web service for filtering and removing content of profanity, obscenity and other unwanted text.

This is a automation test framework written against it.

##### Resources
- [SpecFlow Project Template with dotnet new](https://specflow.org/blog/specflow-project-template-with-dotnet-new/)
- [SpecFlow context injection](https://docs.specflow.org/projects/specflow/en/latest/Bindings/Context-Injection.html)
- [RestSharp](https://restsharp.dev/)

### Getting started
- [Install Docker](https://www.docker.com/products/docker-desktop)
- [Install .Net Core SDK](https://dotnet.microsoft.com/download)
- [Clone this repositiry to your machine](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository)


#### Open Terminal/CMD
- Mac: [Open the Terminal app](https://www.howtogeek.com/682770/how-to-open-the-terminal-on-a-mac/) and [navigate to the repository folder](https://www.macworld.com/article/2042378/master-the-command-line-navigating-files-and-folders.html)
- Windows: [Open command prompt in repository folder](https://helpdeskgeek.com/how-to/open-command-prompt-folder-windows-explorer/)
- Execute the below commands

### Run tests on your machine

```
cd src
dotnet build
dotnet run
```


### Run tests in [Docker](https://www.docker.com/)

```
docker build -t test-box .
docker run test-box
```


#### Trouble shooting

###### Mac MSBuild error
- Issue: The below error when building the project.
```
.nuget/packages/specflow.tools.msbuild.generation/3.1.80/build/SpecFlow.Tools.MsBuild.Generation.targets(93,5): error MSB4018: The "GenerateFeatureFileCodeBehindTask" task failed unexpectedly.
```
- Fix: Run the below in Terminal.
```
export MSBUILDSINGLELOADCONTEXT=1
```