# Dockerization and Kubernetes a basic ASP.NET Core App

**Please don't check my coding (eg. how httpClient is used), this is a solution about how you can have a kubernetes cluster locally up and running with Docker Desktop**

Basically Visual Studio 2019 automates a lot of the stuff, so if everything goes well with this setup you should be able to just push F5 and debug.

So here are what is in side this solution:

- WebFrontEnd : This is just a very basic Razor pages project, where each link in the navbar calls the back end server
- WebApi : This is a basic Web API, that has the default weather forecast returned in one endpoint, also there is a few redis cache calls made, and a call is also made to a database running in 
a container.

See images in repo, regarding how VS and Docker dashboard should look like.

These are the documents I base my code on:

Docker Desktop (maybe even kubernetes):

https://docs.docker.com/docker-for-windows/

A basic app dokerization:

https://docs.microsoft.com/en-us/dotnet/core/docker/introduction
https://docs.microsoft.com/en-us/dotnet/core/docker/build-container
https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/building-net-docker-images?view=aspnetcore-3.1

A basic example regarding how to create a container:

https://medium.com/@andreas_43774/creating-a-docker-container-for-your-net-core-website-from-scratch-b86f9f7b09dd

Basic containers in ASP.NET, Visual studio, and how to publish them:

https://docs.microsoft.com/en-us/visualstudio/containers/container-tools?view=vs-2019

Multiple containers:

https://docs.microsoft.com/en-us/visualstudio/containers/tutorial-multicontainer?view=vs-2019

Docker Compose:

https://docs.docker.com/compose/gettingstarted/

Using redis as a container

https://dotnetcorecentral.com/blog/redis-cache-in-net-core-docker-container/

DB included in the mix:

https://docs.docker.com/compose/aspnet-mssql-compose/
https://www.youtube.com/watch?v=4V7CwC_4oss